using System;
using System.Collections.Generic;
using System.Linq;
using BusinessFramework.Contracts.Actions;
using BusinessFramework.Contracts.GuiSettings.Fields;
using BusinessFramework.Contracts.Reporting;
using Northwind.WebAPI.ActionServices.CodeBehind;
using Northwind.WebAPI.Contracts.Repositories;
using Northwind.WebAPI.Custom;


namespace Northwind.WebAPI.ActionServices
{
    /// <summary>
    /// </summary>
    public sealed class TestDynamicColumnsActionService : CodeBehindTestDynamicColumnsActionService
    {

        public TestDynamicColumnsActionService(IOrderRepository orderRepository)
        {
            OrderRepository = orderRepository;
        }

        private IOrderRepository OrderRepository { get; set; }


        /// <summary>
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="periodQuantity"></param>
        public override ActionResult GetTestData(DateTime startDate, DateTime endDate, int periodQuantity)
        {
            var intervals = PeriodExtensions.GetIntervals(startDate, endDate, periodQuantity);

            var staticColumnCount = 1;
            var columns = new DynamicColumn[intervals.Length + staticColumnCount];
            #region Static columns
            columns[0] = new DynamicColumn {Name = "Клиент", DataType = FieldDataType.String};
            #endregion
            for (var i = 0; i < intervals.Length; i++)
            {
                var interval = intervals[i];
                var displayName = string.Format("{0:dd MMM yy} - {1:dd MMM yy}", interval.Start, interval.DisplayEnd);
                columns[i + staticColumnCount] = new DynamicColumn {Name = displayName, DataType = FieldDataType.String};
            }

            var columnCount = intervals.Length + staticColumnCount;
            var rows = new List<object[]>();
            for (var i = 0; i < intervals.Length; i++)
            {
                var interval = intervals[i];
                var intervalColumn = i + 1;
                var intervalValues = OrderRepository.Set().Where(o => interval.Start <= o.OrderDate && o.OrderDate < interval.End)
                    .GroupBy(o => o.Customers)
                    .Select(grouping => new
                    {
                        Customer = grouping.Key,
                        OwnerVal = grouping.Sum(o => o.Freight),
                        NotOwnerVal = grouping.Sum(o => o.OrderDetailss.Sum(p => p.UnitPrice * p.Quantity))
                    }).OrderBy(t => t.Customer.Id);

                foreach (var value in intervalValues)
                {
                    var row = rows.FirstOrDefault(r => value.Customer.ContactName.Equals(r[0]));
                    if (row == null)
                    {
                        row = new object[columnCount];
                        row[0] = value.Customer.ContactName;
                        for (var j = 1; j < columnCount; j++)
                        {
                            row[j] = 0.0m;
                        }
                        rows.Add(row);
                    }
                    if (value.Customer.ContactTitle == "Owner")
                    {
                        row[intervalColumn] = value.OwnerVal ?? 0;
                    }
                    else
                    {
                        row[intervalColumn] = value.NotOwnerVal;
                    }
                }


            }


            var data = new DynamicData
            {
                Columns = columns,
                Rows = rows
            };
            return ActionResult<DynamicData>.Success(data);
        }
    }
}