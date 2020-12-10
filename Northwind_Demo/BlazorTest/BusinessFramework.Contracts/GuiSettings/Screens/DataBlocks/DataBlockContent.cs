using System;

namespace BusinessFramework.Contracts.GuiSettings.Screens.DataBlocks
{
    public abstract class DataBlockContent
    {
        public abstract DataBlockContentType Type { get; }

        #region Move to specific(Grid)
        //TODO: Move to specific
        public virtual bool HasQuickFilter
        {
            get { return false; }
            set { }
        }

        /// <summary>
        /// Enabled paging or not
        /// </summary>
        public bool PagingEnabled { get; set; }
        /// <summary>
        /// Count items on page
        /// </summary>
        public int ItemsOnPage { get; set; }
        #endregion

        /// <summary>
        /// PTS specific.
        /// </summary>
        public string DataSourceQueryPrefix { get; set; }
    }
}