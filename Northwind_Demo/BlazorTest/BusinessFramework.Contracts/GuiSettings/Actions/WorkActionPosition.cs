using System;

namespace BusinessFramework.Contracts.GuiSettings.Actions
{
    [Flags]
    public enum WorkActionPosition
    {
        None = 0,

        /// <summary>
        ///     Action shows in context menu
        /// </summary>
        Context = 0x001,

        /// <summary>
        ///     Action shows on local toolbar
        /// </summary>
        Toolbar = 0x002,

        /// <summary>
        ///     Action shows on main toolbar
        /// </summary>
        MainToolbar = 0x004,

        /// <summary>
        ///     Action always shows in context menu
        /// </summary>
        ContextRequired = 0x008 | Context,
        /// <summary>
        ///     Action optional shows in context menu, can be hidden under ellipsis
        /// </summary>
        ContextOptional = 0x010 | Context,

        /// <summary>
        ///     Action always shows on local toolbar
        /// </summary>
        ToolbarRequired = 0x020 | Toolbar,
        /// <summary>
        ///     Action optional shows on local toolbar, can be hidden under ellipsis
        /// </summary>
        ToolbarOptional = 0x040 | Toolbar,

        /// <summary>
        ///     Action always shows on main toolbar
        /// </summary>
        MainToolbarRequired = 0x080 | MainToolbar,
        /// <summary>
        ///     Action optional shows on main toolbar, can be hidden under ellipsis
        /// </summary>
        MainToolbarOptional = 0x100 | MainToolbar
    }
}