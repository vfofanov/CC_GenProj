namespace BusinessFramework.Contracts.GuiSettings.Wizards.Editors
{
    public abstract class WizardPageEditor
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Object"/> class.
        /// </summary>
        protected WizardPageEditor()
        {
            Stretching = Stretching.ByWidth;
        }

        public string Name { get; set; }
        public string Title { get; set; }
        public abstract WizardPageEditorType Type { get; }

        /// <summary>
        /// Shows if control should be read only
        /// </summary>
        public bool ReadOnly { get; set; }
        /// <summary>
        /// Shows if control last in line
        /// </summary>
        public bool IsEndLine { get; set; }
        /// <summary>
        ///     Minimum width of control in pixels
        /// </summary>
        public int? MinWidth { get; set; }
        /// <summary>
        ///     Minimum height of control in pixels
        /// </summary>
        public int? MinHeight { get; set; }

        /// <summary>
        ///     Maximum width of control in pixels
        /// </summary>
        public int? MaxWidth { get; set; }
        /// <summary>
        ///     Maximum height of control in pixels
        /// </summary>
        public int? MaxHeight { get; set; }

        /// <summary>
        ///     Is editor fill free space or not
        /// </summary>
        public Stretching Stretching { get; set; }

        public Validator[] Validators { get; set; }
    }
}