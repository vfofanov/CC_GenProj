using System.Text;
using System.Web;
using NorthWind.WebAPI.Contracts;

namespace NorthWind.WebApiServer
{
    /// <inheritdoc />
    internal sealed class WebUtilityService : IWebUtilityService
    {
        /// <inheritdoc />
        public string UrlEncode(string str)
        {
            return HttpUtility.UrlEncode(str);
        }

        /// <inheritdoc />
        public string UrlPathEncode(string str)
        {
            return HttpUtility.UrlPathEncode(str);
        }

        /// <inheritdoc />
        public string UrlEncode(string str, Encoding e)
        {
            return HttpUtility.UrlEncode(str, e);
        }

        /// <inheritdoc />
        public string UrlDecode(string str)
        {
            return HttpUtility.UrlDecode(str);
        }

        /// <inheritdoc />
        public string UrlDecode(string str, Encoding e)
        {
            return HttpUtility.UrlDecode(str, e);
        }
    }
}