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


namespace NorthWind.Client.Wizards.ReportFormQueryWizard
{
    [ToolboxItem(false)]
    public partial class Page1 : BaseWizardPage
    {
        public Page1()
        {
            InitializeComponent();
            InitializeHelpProvider("0");

            EmployeeIdHolder = new PropertyControlHolder<CcComboBox>(_employeeidCcLabel, _employeeidCcComboBox, errorProvider, "EmployeeId");
            CustomerIdHolder = new PropertyControlHolder<CcComboBox>(_customeridCcLabel, _customeridCcComboBox, errorProvider, "CustomerId");
            FromHolder = new PropertyControlHolder<CcDateEditor>(_fromCcLabel, _fromCcDateEditor, errorProvider, "From");
            ToHolder = new PropertyControlHolder<CcDateEditor>(_toCcLabel, _toCcDateEditor, errorProvider, "To");
            useExcelHolder = new PropertyControlHolder<CcCheckBox>(_useexcelCcLabel, _useexcelCcCheckBox, errorProvider, "useExcel");

        
            _employeeidCcComboBoxBindingSource.OnUpdateSource += (sender, args) =>
                args.Source.UpdateDataSource<Employees>(outs => outs.ToList());
        
            _customeridCcComboBoxBindingSource.OnUpdateSource += (sender, args) =>
                args.Source.UpdateDataSource<Customers>(outs => 
                { 
                    if (!string.IsNullOrWhiteSpace(args.FilterText)) 
                    {
                        return outs.Where(t => t.CompanyName.Contains(args.FilterText)).ToList();
                    }
                    if (CurrentObject == null)
                    {
                        return new Customers[0];
                    }  
                    return outs.Where(o => o.Id == CurrentObject.CustomerId).ToList();    
                });
        }

        public PropertyControlHolder<CcComboBox> EmployeeIdHolder { get; private set; }
        public PropertyControlHolder<CcComboBox> CustomerIdHolder { get; private set; }
        public PropertyControlHolder<CcDateEditor> FromHolder { get; private set; }
        public PropertyControlHolder<CcDateEditor> ToHolder { get; private set; }
        public PropertyControlHolder<CcCheckBox> useExcelHolder { get; private set; }

        public override IPropertyControlHolder[] GetPropertyControlHolders()
        {
            return new IPropertyControlHolder[]
            {
                 EmployeeIdHolder,
                 CustomerIdHolder,
                 FromHolder,
                 ToHolder,
                 useExcelHolder,
            };
        }

        public ReportFormQuery CurrentObject
        {
            [DebuggerStepThrough]
            get { return (ReportFormQuery)dataObjectBindingSource.DataSource; }            
        }


        public ReportFormQueryWizardParameters Parameters
        {
            [DebuggerStepThrough]
            get { return (ReportFormQueryWizardParameters)parametersBindingSource.DataSource; }            
        }


        public Employees EmployeeIdDataSourceComboBoxValue
        {
            get { return (Employees)_employeeidCcComboBox.SelectedBoundObject; }
        }

        public void SetEmployeeIdDataSource(IQueryable<Employees> items)
        {
            _employeeidCcComboBoxBindingSource.DataSource = items;
            foreach (System.Windows.Forms.Binding dataBinding in _employeeidCcComboBox.DataBindings)
            {
                dataBinding.ReadValue();
            }
        }

        public void SetEmployeeIdDataSourceNewItemAction(Action action)
        {
            _employeeidCcComboBox.SetNewItemAction(action);
        }



        public void UpdateDataSourceCustomerIdDataSource(object o, CcComboBox.NeedUpdateDataSource needUpdateDataSource)
        {
            _customeridCcComboBoxBindingSource.RefreshSource(needUpdateDataSource.TextToSearch);
        }

        public Customers CustomerIdDataSourceComboBoxValue
        {
            get { return (Customers)_customeridCcComboBox.SelectedBoundObject; }
        }

        public void SetCustomerIdDataSource(IQueryable<Customers> items)
        {
            _customeridCcComboBoxBindingSource.DataSource = items;
            foreach (System.Windows.Forms.Binding dataBinding in _customeridCcComboBox.DataBindings)
            {
                dataBinding.ReadValue();
            }
        }

        public void SetCustomerIdDataSourceNewItemAction(Action action)
        {
            _customeridCcComboBox.SetNewItemAction(action);
        }


        #region Acessibility
        public void SetAcessibility_employeeidCcComboBox(bool value)
        {
            _employeeidCcComboBox.SetReadOnly(!value);
        }
        public void SetAcessibility_customeridCcComboBox(bool value)
        {
            _customeridCcComboBox.SetReadOnly(!value);
        }
        public void SetAcessibility_fromCcDateEditor(bool value)
        {
            _fromCcDateEditor.SetReadOnly(!value);
        }
        public void SetAcessibility_toCcDateEditor(bool value)
        {
            _toCcDateEditor.SetReadOnly(!value);
        }
        public void SetAcessibility_useexcelCcCheckBox(bool value)
        {
            _useexcelCcCheckBox.SetReadOnly(!value);
        }
        #endregion
    }
}
