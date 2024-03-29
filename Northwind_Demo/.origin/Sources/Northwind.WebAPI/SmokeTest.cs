using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using BusinessFramework.WebAPI;
using BusinessFramework.WebAPI.Contracts.Data.Sys;
using Newtonsoft.Json;

namespace NorthWind.WebAPI
{
    public static class SmokeTest
    {
        private static Guid _session;
        private static int _totalPassedTests;
        private static int _totalFailedTests;
        private static HttpClient _client;


        private static string Address
        {
            get
            {
                var address = Program.Address;

                if (address.Contains("*"))
                {
                    address = address.Replace("*", "localhost");
                }

                return address;
            }
        }

        public static void Start()
        {
            try
            {
                Logger.DebugWriteToConsole = false;

                WriteHeader("Executing smoke tests...");
                using (_client = new HttpClient())
                {
                    if (OpenSession())
                    {
                        _client.DefaultRequestHeaders.Authorization = CreateSessionCredentials(_session);
                    }
                    else
                    {
                        Console.WriteLine("Unable to execute tests.");
                        return;
                    }

                    _totalPassedTests = 0;
                    _totalFailedTests = 0;


                    RunControllersGetTests();
                    RunCCSystemCustomGetTests();
                    RunOperationLockTests();
                }

                Console.WriteLine("\r\n=================================");
                Console.ForegroundColor = _totalFailedTests > 0 ? ConsoleColor.Red : ConsoleColor.Green;
                Console.WriteLine("Testing completed.\r\n\tTotal tests passed: {0}\r\n\tTotal tests failed: {1}", _totalPassedTests, _totalFailedTests);
                Console.ResetColor();
                Console.WriteLine("=================================");
                Console.WriteLine();
            }
            finally
            {
                Logger.DebugWriteToConsole = true;
            }
        }

        private static bool OpenSession()
        {
            Console.WriteLine("Opening session for user Admin...");
            var session = Authorize(CreateBasicCredentials("Admin", "66-C4-3E-FE-5E-CF-A5-33-D3-09-7B-D9-FF-7C-11-48-E7-30-9E-5A")).Result;
            if (session == null)
            {
                Console.WriteLine("Error opening session.");
                return false;
            }
            _session = session.Value;
            Console.WriteLine("Opened new session " + _session);
            return true;
        }

        private static async Task<Guid?> Authorize(AuthenticationHeaderValue authorization)
        {
            using (var request = new HttpRequestMessage(HttpMethod.Get, Address + "/api/Session"))
            {
                request.Headers.Authorization = authorization;
                using (var response = await _client.SendAsync(request))
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        return null;
                    }

                    var model = await response.Content.ReadAsAsync<Guid>();
                    return model;
                }
            }
        }

        private static AuthenticationHeaderValue CreateBasicCredentials(string userName, string password)
        {
            var toEncode = userName + ":" + password;
            var encoding = Encoding.UTF8;
            var toBase64 = encoding.GetBytes(toEncode);
            var parameter = Convert.ToBase64String(toBase64);

            return new AuthenticationHeaderValue("Basic", parameter);
        }

        private static AuthenticationHeaderValue CreateSessionCredentials(Guid session)
        {
            return new AuthenticationHeaderValue("Session", session.ToString());
        }

        private static void RunControllersGetTests()
        {
            WriteHeader("Controllers GET tests");

            var types = AppDomain.CurrentDomain.GetAssemblies().Where(a => a.FullName.Contains("WebAPI")  || a.FullName.Contains("WebApiServer"))
                .SelectMany(a => a.GetTypes()
                    .Where(t => !t.IsAbstract && t.Name.EndsWith("Controller") && t.IsSubclassOf(typeof (ApiController)))
                    .Select(t => (t.IsSubclassOf(typeof (System.Web.OData.ODataController)) ? "odata/" : "") + t.Name.Substring(0, t.Name.Length - "Controller".Length)))
                .Except(new[] {"SysActionLogEntry", "SysObjectLogEntry", "Session"})
                .ToList();

            if (types.Count == 0)
            {
                Console.WriteLine("Controllers not found.");
                return;
            }

            RunGetTests(types);
        }

        private static void RunCCSystemCustomGetTests()
        {
            WriteHeader("CC system custom GET tests");

            var queries = new List<string>();

            var json = JsonConvert.SerializeObject(new[] {new DateTime(2009, 1, 1), new DateTime(2015, 1, 1)});
            queries.Add("/SysObjectLogEntry/GetByPeriod/" + HttpUtility.UrlEncode(json));

            json = JsonConvert.SerializeObject(new[] {new DateTime(2009, 1, 1), new DateTime(2015, 1, 1)});
            queries.Add("/SysObjectLogEntry/GetByPeriod/" + HttpUtility.UrlEncode(json));

            json = JsonConvert.SerializeObject(new[] {"TestObjectType", "TestObjectId"});
            queries.Add("/SysObjectLogEntry/GetByObject/" + HttpUtility.UrlEncode(json));

            queries.Add("/SysGridFilterInfo?Owner=Donain%5cUsername");

            queries.Add("/SysDataAnalyser/GetProcedures/all");

            RunGetTests(queries);
        }

        private static void RunGetTests(IEnumerable<string> queries)
        {
            var passed = 0;
            var failed = 0;

            foreach (var query in queries)
            {
                var uri = Address + "/api/" + query;
                using (var request = new HttpRequestMessage(HttpMethod.Get, uri))
                {
                    Console.Write("{0} ", uri.PadRight(60, ' '));
                    using (var response = _client.SendAsync(request).Result)
                    {
                        if (response.StatusCode == HttpStatusCode.OK)
                        {
                            passed++;
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else
                        {
                            failed++;
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        Console.WriteLine("{0} {1}", (int) response.StatusCode, response.ReasonPhrase);
                        Console.ResetColor();
                    }
                }
            }
            Console.WriteLine("\r\n\tTests passed: {0}\r\n\tTests failed: {1}\r\n", passed, failed);
            _totalPassedTests += passed;
            _totalFailedTests += failed;
        }

        private static void RunOperationLockTests()
        {
            WriteHeader("Operation locks test");
            string uri;
            try
            {
                var operationName = "TestOperation";
                var operationContext = "TestContext_" + Guid.NewGuid();
                uri = Address + "/api/SysOperationLock/" + operationName + "/" + operationContext;

                using (var request = new HttpRequestMessage(HttpMethod.Get, uri))
                {
                    using (var response = _client.SendAsync(request).Result)
                    {
                        if (response.StatusCode != HttpStatusCode.NotFound)
                        {
                            throw new Exception("It should return 404(NotFound) for not existing lock");
                        }
                    }
                }
                Console.WriteLine("Verified 404(NotFound) for not existing lock.");

                SysOperationLock aquiredLock;
                {
                    var data = new SysOperationLock
                    {
                        OperationName = operationName,
                        OperationContext = operationContext,
                        MachineName = "FAKE01",
                        UserId = 1
                    };
                    var content = CreateContent(data);
                    var resp = _client.PostAsync(uri, content).Result;
                    resp.EnsureSuccessStatusCode();
                    aquiredLock = JsonConvert.DeserializeObject<SysOperationLock>(resp.Content.ReadAsStringAsync().Result);
                    if ((aquiredLock.ExpirationTime - DateTime.Now).TotalMinutes <= 1 || (aquiredLock.ExpirationTime - DateTime.Now).TotalMinutes >= 3)
                    {
                        throw new Exception("Invalid expiration time");
                    }
                    Console.WriteLine("Created new lock.");
                }

                {
                    var data = new SysOperationLock
                    {
                        OperationName = operationName,
                        OperationContext = operationContext,
                        MachineName = "FAKE02",
                        UserId = 2
                    };
                    var content = CreateContent(data);
                    using (var response = _client.PostAsync(uri, content).Result)
                    {
                        if (response.StatusCode != HttpStatusCode.Forbidden)
                        {
                            throw new Exception("It should return 403(Forbidden) on attempt to lock a locked object");
                        }
                    }
                    Console.WriteLine("Verified 403(Forbidden) returned for attempt to lock a locked object.");
                }

                {
                    var content = CreateContent(aquiredLock);
                    var resp = _client.PutAsync(uri, content).Result;
                    resp.EnsureSuccessStatusCode();

                    aquiredLock = JsonConvert.DeserializeObject<SysOperationLock>(resp.Content.ReadAsStringAsync().Result);
                    if ((aquiredLock.ExpirationTime - DateTime.Now).TotalMinutes <= 1 || (aquiredLock.ExpirationTime - DateTime.Now).TotalMinutes >= 3)
                    {
                        throw new Exception("Invalid expiration time");
                    }
                    Console.WriteLine("Updated expiration time.");
                }
                {
                    var resp = _client.DeleteAsync(uri).Result;
                    resp.EnsureSuccessStatusCode();
                    Console.WriteLine("Removed lock.");
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Test passed.");
                _totalPassedTests++;
            }
            catch (Exception exc)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Test failed:  {0}\r\n",
                    exc.Message);
                _totalFailedTests++;
            }
            Console.ResetColor();
        }

        private static StringContent CreateContent(object data)
        {
            var content = new StringContent(
                JsonConvert.SerializeObject(data),
                Encoding.UTF8,
                "application/json");
            return content;
        }

        private static void WriteHeader(string header)
        {
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("=================================");
            Console.WriteLine("===   " + header);
            Console.WriteLine("=================================");
            Console.WriteLine();
        }
    }
}