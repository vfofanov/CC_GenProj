using BusinessFramework.Contracts.GuiSettings.Fields;

namespace Northwind.WebAPI.Custom
{
    public class DynamicColumn
    {
        public string Name { get; set; }
        public FieldDataType DataType { get; set; }
    }
}