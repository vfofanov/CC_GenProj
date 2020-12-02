using System.Collections.Generic;

namespace Northwind.WebAPI.Custom
{
    public sealed class DynamicData
    {
        public DynamicColumn[] Columns { get; set; }
        public List<object[]> Rows { get; set; }
    }
}