using BusinessFramework.Contracts.GuiSettings.Fields;

namespace BusinessFramework.Contracts.GuiSettings.Screens.DataBlocks
{
    public interface IDataBlockContentField
    {
        Field Field { get; set; }
        int? Format { get; set; }
    }
}