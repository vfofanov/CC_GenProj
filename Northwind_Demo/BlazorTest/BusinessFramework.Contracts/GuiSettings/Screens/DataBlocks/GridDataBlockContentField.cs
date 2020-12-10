using BusinessFramework.Contracts.GuiSettings.Screens.DataBlocks.FieldViewers;
using Newtonsoft.Json;

namespace BusinessFramework.Contracts.GuiSettings.Screens.DataBlocks
{
    public sealed class GridDataBlockContentField : DataBlockContentField
    {
        public string Title { get; set; }
        public bool Hidden { get; set; }
        public double? Width { get; set; }
        public bool Sortable { get; set; }
        public Sorting Sorting { get; set; }

        public FieldViewer Viewer { get; set; }

        [JsonIgnore]
        public bool AutoSize
        {
            get { return !Width.HasValue; }
        }
    }
}