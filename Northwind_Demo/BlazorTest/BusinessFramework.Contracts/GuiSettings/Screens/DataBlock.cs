using BusinessFramework.Contracts.GuiSettings.Screens.DataBlocks;

namespace BusinessFramework.Contracts.GuiSettings.Screens
{
    public class DataBlock : ScreenItem
    {
        /// <summary>
        /// Initialization rank
        /// </summary>
        public byte Rank { get; set; }

        public override bool HasQuickFilter
        {
            get { return Content.HasQuickFilter; }
        }

        /// <summary>
        /// Enabled paging or not
        /// </summary>
        public bool PagingEnabled
        {
            get { return Content.PagingEnabled; }
        }

        /// <summary>
        /// Count items on page
        /// </summary>
        public int ItemsOnPage
        {
            get { return Content.ItemsOnPage; }
        }

        /// <summary>
        ///     Type of screen item
        /// </summary>
        public override ScreenItemType Type
        {
            get { return ScreenItemType.DataBlock; }
        }

        /// <summary>
        ///     Source controller name for getting data for data block
        /// </summary>
        public string Controller { get; set; }

        public DataBlockDepend[] Depends { get; set; }

        /// <summary>
        ///     Data block content
        /// </summary>
        public DataBlockContent Content { get; set; }
    }
}