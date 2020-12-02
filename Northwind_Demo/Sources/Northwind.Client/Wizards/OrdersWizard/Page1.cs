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
using Northwind.Client.Contracts.BusinessObjects;
using Northwind.Common.Wizards;
using Northwind.Contracts.Enums;


namespace Northwind.Client.Wizards.OrdersWizard
{
    [ToolboxItem(false)]
    public partial class Page1 : BaseWizardPage
    {
        public Page1()
        {
            InitializeComponent();
            InitializeHelpProvider("0");

            OrderDateHolder = new PropertyControlHolder<CcDateEditor>(_orderdateCcLabel, _orderdateCcDateEditor, errorProvider, "OrderDate");
            CustomerIDHolder = new PropertyControlHolder<CcComboBox>(_customeridCcLabel, _customeridCcComboBox, errorProvider, "CustomerID");
            EmployeeIDHolder = new PropertyControlHolder<CcComboBox>(_employeeidCcLabel, _employeeidCcComboBox, errorProvider, "EmployeeID");
            RequiredDateHolder = new PropertyControlHolder<CcDateEditor>(_requireddateCcLabel, _requireddateCcDateEditor, errorProvider, "RequiredDate");

        
            _customeridCcComboBoxBindingSource.OnUpdateSource += (sender, args) =>
                args.Source.UpdateDataSource<QCustomers>(outs => 
                { 
                    if (!string.IsNullOrWhiteSpace(args.FilterText)) 
                    {
                        return outs.Where(t => t.CompanyName.Contains(args.FilterText)).ToList();
                    }
                    if (CurrentObject == null)
                    {
                        return new QCustomers[0];
                    }  
                    return outs.Where(o => o.Id == CurrentObject.CustomerID).ToList();    
                });
        
            _employeeidCcComboBoxBindingSource.OnUpdateSource += (sender, args) =>
                args.Source.UpdateDataSource<QEmployees>(outs => outs.ToList());
        }

        public PropertyControlHolder<CcDateEditor> OrderDateHolder { get; private set; }
        public PropertyControlHolder<CcComboBox> CustomerIDHolder { get; private set; }
        public PropertyControlHolder<CcComboBox> EmployeeIDHolder { get; private set; }
        public PropertyControlHolder<CcDateEditor> RequiredDateHolder { get; private set; }

        public override IPropertyControlHolder[] GetPropertyControlHolders()
        {
            return new IPropertyControlHolder[]
            {
                 OrderDateHolder,
                 CustomerIDHolder,
                 EmployeeIDHolder,
                 RequiredDateHolder,
            };
        }

        public Order CurrentObject
        {
            [DebuggerStepThrough]
            get { return (Order)dataObjectBindingSource.DataSource; }            
        }


        public OrdersWizardParameters Parameters
        {
            [DebuggerStepThrough]
            get { return (OrdersWizardParameters)parametersBindingSource.DataSource; }            
        }


        public void UpdateDataSourceCustomerIDDataSource(object o, CcComboBox.NeedUpdateDataSource needUpdateDataSource)
        {
            _customeridCcComboBoxBindingSource.RefreshSource(needUpdateDataSource.TextToSearch);
        }

        public QCustomers CustomerIDDataSourceComboBoxValue
        {
            get { return (QCustomers)_customeridCcComboBox.SelectedBoundObject; }
        }

        public void SetCustomerIDDataSource(IQueryable<QCustomers> items)
        {
            _customeridCcComboBoxBindingSource.DataSource = items;
            foreach (System.Windows.Forms.Binding dataBinding in _customeridCcComboBox.DataBindings)
            {
                dataBinding.ReadValue();
            }
        }

        public void SetCustomerIDDataSourceNewItemAction(Action action)
        {
            _customeridCcComboBox.SetNewItemAction(action);
        }



        public QEmployees EmployeeIDDataSourceComboBoxValue
        {
            get { return (QEmployees)_employeeidCcComboBox.SelectedBoundObject; }
        }

        public void SetEmployeeIDDataSource(IQueryable<QEmployees> items)
        {
            _employeeidCcComboBoxBindingSource.DataSource = items;
            foreach (System.Windows.Forms.Binding dataBinding in _employeeidCcComboBox.DataBindings)
            {
                dataBinding.ReadValue();
            }
        }

        public void SetEmployeeIDDataSourceNewItemAction(Action action)
        {
            _employeeidCcComboBox.SetNewItemAction(action);
        }


        #region Acessibility
        public void SetAcessibility_orderdateCcDateEditor(bool value)
        {
            _orderdateCcDateEditor.SetReadOnly(!value);
        }
        public void SetAcessibility_customeridCcComboBox(bool value)
        {
            _customeridCcComboBox.SetReadOnly(!value);
        }
        public void SetAcessibility_employeeidCcComboBox(bool value)
        {
            _employeeidCcComboBox.SetReadOnly(!value);
        }
        public void SetAcessibility_requireddateCcDateEditor(bool value)
        {
            _requireddateCcDateEditor.SetReadOnly(!value);
        }
        #endregion
    }
}
