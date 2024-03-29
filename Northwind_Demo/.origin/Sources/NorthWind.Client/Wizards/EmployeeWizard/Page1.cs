using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using BusinessFramework.Client.Contracts.Controls;
using BusinessFramework.Client.WinForms.IG.Controls;
using BusinessFramework.Client.WinForms.IG.Controls.DataGrid;
using BusinessFramework.Client.WinForms.IG.Controls.PictureControl;
using BusinessFramework.Client.WinForms.IG.Utils;
using BusinessFramework.Client.WinForms.IG.Wizard;
using NorthWind.Client.Contracts.BusinessObjects;
using NorthWind.Common.Wizards;
using NorthWind.Contracts.Enums;


namespace NorthWind.Client.Wizards.EmployeeWizard
{
    [ToolboxItem(false)]
    public partial class Page1 : BaseWizardPage
    {
        public Page1()
        {
            InitializeComponent();
            InitializeHelpProvider("0");

            LastNameHolder = new PropertyControlHolder<CcTextEditor>(_lastnameCcLabel, _lastnameCcTextEditor, errorProvider, "LastName");
            FirstNameHolder = new PropertyControlHolder<CcTextEditor>(_firstnameCcLabel, _firstnameCcTextEditor, errorProvider, "FirstName");
            TitleHolder = new PropertyControlHolder<CcTextEditor>(_titleCcLabel, _titleCcTextEditor, errorProvider, "Title");
            TitleOfCourtesyHolder = new PropertyControlHolder<CcTextEditor>(_titleofcourtesyCcLabel, _titleofcourtesyCcTextEditor, errorProvider, "TitleOfCourtesy");
            BirthDateHolder = new PropertyControlHolder<CcDateEditor>(_birthdateCcLabel, _birthdateCcDateEditor, errorProvider, "BirthDate");
            HireDateHolder = new PropertyControlHolder<CcDateEditor>(_hiredateCcLabel, _hiredateCcDateEditor, errorProvider, "HireDate");
            PhotoHolder = new PropertyControlHolder<PictureControl>(_photoCcLabel, _photoPictureControl, errorProvider, "Photo");
            NotesHolder = new PropertyControlHolder<CcMultilineTextEditor>(_notesCcLabel, _notesCcMultilineTextEditor, errorProvider, "Notes");
            DocumentScanFileIdHolder = new PropertyControlHolder<PictureControl>(_documentscanfileidCcLabel, _documentscanfileidPictureControl, errorProvider, "DocumentScanFileId");

        }

        public PropertyControlHolder<CcTextEditor> LastNameHolder { get; private set; }
        public PropertyControlHolder<CcTextEditor> FirstNameHolder { get; private set; }
        public PropertyControlHolder<CcTextEditor> TitleHolder { get; private set; }
        public PropertyControlHolder<CcTextEditor> TitleOfCourtesyHolder { get; private set; }
        public PropertyControlHolder<CcDateEditor> BirthDateHolder { get; private set; }
        public PropertyControlHolder<CcDateEditor> HireDateHolder { get; private set; }
        public PropertyControlHolder<PictureControl> PhotoHolder { get; private set; }
        public PropertyControlHolder<CcMultilineTextEditor> NotesHolder { get; private set; }
        public PropertyControlHolder<PictureControl> DocumentScanFileIdHolder { get; private set; }

        public override IPropertyControlHolder[] GetPropertyControlHolders()
        {
            return new IPropertyControlHolder[]
            {
                 LastNameHolder,
                 FirstNameHolder,
                 TitleHolder,
                 TitleOfCourtesyHolder,
                 BirthDateHolder,
                 HireDateHolder,
                 PhotoHolder,
                 NotesHolder,
                 DocumentScanFileIdHolder,
            };
        }

        public Employees CurrentObject
        {
            [DebuggerStepThrough]
            get { return (Employees)dataObjectBindingSource.DataSource; }            
        }


        public EmployeeWizardParameters Parameters
        {
            [DebuggerStepThrough]
            get { return (EmployeeWizardParameters)parametersBindingSource.DataSource; }            
        }

        #region Acessibility
        public void SetAcessibility_lastnameCcTextEditor(bool value)
        {
            _lastnameCcTextEditor.SetReadOnly(!value);
        }
        public void SetAcessibility_firstnameCcTextEditor(bool value)
        {
            _firstnameCcTextEditor.SetReadOnly(!value);
        }
        public void SetAcessibility_titleCcTextEditor(bool value)
        {
            _titleCcTextEditor.SetReadOnly(!value);
        }
        public void SetAcessibility_titleofcourtesyCcTextEditor(bool value)
        {
            _titleofcourtesyCcTextEditor.SetReadOnly(!value);
        }
        public void SetAcessibility_birthdateCcDateEditor(bool value)
        {
            _birthdateCcDateEditor.SetReadOnly(!value);
        }
        public void SetAcessibility_hiredateCcDateEditor(bool value)
        {
            _hiredateCcDateEditor.SetReadOnly(!value);
        }
        public void SetAcessibility_photoPictureControl(bool value)
        {
            _photoPictureControl.SetReadOnly(!value);
        }
        public void SetAcessibility_notesCcMultilineTextEditor(bool value)
        {
            _notesCcMultilineTextEditor.SetReadOnly(!value);
        }
        public void SetAcessibility_documentscanfileidPictureControl(bool value)
        {
            _documentscanfileidPictureControl.SetReadOnly(!value);
        }
        #endregion
    }
}
