using System;

namespace BusinessFramework.Contracts.GuiSettings.Wizards.Editors
{
    [Flags]
    public enum Stretching
    {
        None = 0,
        ByWidth = 0x1,
        ByHeight = 0x2,
        All = ByWidth | ByHeight
    }
}