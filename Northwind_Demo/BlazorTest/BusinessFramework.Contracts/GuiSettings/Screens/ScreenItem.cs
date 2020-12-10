using System.Linq;
using BusinessFramework.Contracts.GuiSettings.Actions;

namespace BusinessFramework.Contracts.GuiSettings.Screens
{
    public abstract class ScreenItem
    {
        public virtual bool HasQuickFilter
        {
            get { return false; }
        }

        public bool HasToolbar
        {
            get
            {
                return Actions != null &&
                       Actions.Any(a => (a.Position & WorkActionPosition.Toolbar) == WorkActionPosition.Toolbar);
            }
        }

        public WorkActionItem[] Actions { get; set; }

        /// <summary>
        ///     Unique name of screen item
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        ///     Type of screen item
        /// </summary>
        public abstract ScreenItemType Type { get; }

        /// <summary>
        ///     Grid appearance, if item is a child of GridLayout otherwise null
        /// </summary>
        public GridAppearance GridAppearance { get; set; }

        
    }
}