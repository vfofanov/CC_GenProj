using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using BusinessFramework.Contracts.Actions;
using BusinessFramework.Contracts.Reporting;
using NorthWind.WebAPI.Contracts.Reporting;
using NorthWind.WebAPI.Contracts.Repositories;
using ReportingFramework.Central.Contracts.Reports;
using ReportSystem.Contracts.Utils.Serialization;


namespace NorthWind.WebAPI.ActionServices
{

    /// <summary>
    /// 
    /// </summary>

    public sealed class ReportService : CodeBehind.CodeBehindReportService
    {
        private readonly IOrdersQueryRepository _ordersRepository;
        private readonly IReportDataExtractor _reportDataExtractor;
        private readonly IReportingService _reportingService;
        private readonly IOrderProductQueryRepository _productsRepository;
        private readonly ICustomersRepository _customersRepository;
        private readonly IEmployeesRepository _employeeRepository;

        public ReportService(
            IOrdersQueryRepository ordersRepository, 
            IReportDataExtractor reportDataExtractor, 
            IReportingService reportingService, 
            IOrderProductQueryRepository productsRepository,
            ICustomersRepository customersRepository,
            IEmployeesRepository employeeRepository
            )
        {
            _ordersRepository = ordersRepository;
            _reportDataExtractor = reportDataExtractor;
            _reportingService = reportingService;
            _productsRepository = productsRepository;
            this._customersRepository = customersRepository;
            this._employeeRepository = employeeRepository;
        }


        private class Stat
        {
            public double Ammount { get; set; }
        }


        public override ActionResult<Report> ServerPrintSimple()
        {
            var orders = _ordersRepository.Set().Where(o => o.Id > 12000);
            return new ActionResult<Report>()
            {
                Data = _reportingService.GetReport("ReportWithoutParameters",
                    _reportDataExtractor.GetData("Data1", orders), ReportFormat.Pdf)
            };
        }

        public override ActionResult<Report> ServerPrintWithParameter(int id)
        {
            var orders = _ordersRepository.Set().Where(o => o.Id == id).ToList();
            var sources = new Dictionary<string, IEnumerable>();
            sources.Add("Data", orders);
            var products = _productsRepository.Set().Where(o => o.OrderID == id).ToList();
            sources.Add("Products", products);
            double stat = _productsRepository.Set().Where(o => o.OrderID == id).Sum(x => x.Quantity * (1 - x.Discount) * (double)x.UnitPrice);
            var lst = new List<Stat> { new Stat { Ammount = stat } };
            sources.Add("Stat", lst);

            var data = _reportDataExtractor.GetData(sources);
            return new ActionResult<Report>()
            {
                Data = _reportingService.GetReport("OrderInvoice", data, ReportFormat.Pdf, "OrderInvoice")
            };
        }

        public override ActionResult<Report> ServerPrintWithForm(int? employeeId, DateTime? fromDate, DateTime? toDate, bool useExcel, int? customerId)
        {
            var orders = _ordersRepository.Set().Where(o => (employeeId==null || o.EmployeeID == employeeId) && (customerId==null || o.CustomerID == customerId)).ToList();
            orders = orders.Where(d => (fromDate == null || d.OrderDate >= fromDate) && (toDate == null || d.OrderDate <= toDate)).ToList();

            var employee = _employeeRepository.Set().FirstOrDefault(x => x.Id == employeeId);
            var employeeName = (employee != null) ? (employee.FirstName+" "+ employee.LastName) : string.Empty;

            var customer = _customersRepository.Set().FirstOrDefault(x => x.Id == customerId);
            var customerName = (customer != null) ? (customer.CompanyName) : string.Empty;

            var sources = new Dictionary<string, IEnumerable>();
            sources.Add("Data", orders);
            sources.Add("Static", new[] { new
            {
                FromDate = fromDate.ToString(),
                ToDate = toDate.ToString(),
                EmployeeName = employeeName,
                CustomerName = customerName
            } }.ToList());

            var data = _reportDataExtractor.GetData(sources);

            return new ActionResult<Report>()
            {
                Data = _reportingService.GetReport("OrderReport", data, useExcel ? ReportFormat.Auto : ReportFormat.Pdf, "OrderReport")
            };
        }
    }
}