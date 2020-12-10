using BusinessFramework.Contracts.GuiSettings.Fields;

namespace BusinessFramework.Contracts.GuiSettings.Screens.DataBlocks
{
    public abstract class DataBlockContentField : IDataBlockContentField
    {
        public Field Field { get; set; }

        public int? Format { get; set; }
    }
}