using System;
using System.Linq;
using BusinessFramework.Client.Contracts.Services.Dialogs;
using BusinessFramework.Client.Contracts.Services.Security;
using BusinessFramework.Client.Contracts.Services.Settings;
using BusinessFramework.Client.Contracts.Utils.Formatting;
using BusinessFramework.Client.WinForms;
using BusinessFramework.Client.WinForms.IG;
using BusinessFramework.Client.WinForms.IG.Controls;
using BusinessFramework.Client.WinForms.IG.Explorer;
using BusinessFramework.Contracts;
using Northwind.Client.CustomSettings;
using Northwind.Client.Services.Contracts.DomainModel;

namespace Northwind.Client.Forms
{
    public partial class OptionsForm : BaseForm
    {
        private readonly SettingsPresenter _presenter;

        public OptionsForm(ILogger logger, ISecurityService securityService,
            ISessionSettingsService sessionSettingsService, 
            ILocalSettingsService localSettingsService,
            IApplicationStyleService applicationStyleService,
            ISysSettingPropertyCollectionManager sysSettingPropertyCollectionManager)
        {
            Logger = logger;
            SessionSettingsService = sessionSettingsService;
            LocalSettingsService = localSettingsService;
            ApplicationStyleService = applicationStyleService;

            InitializeComponent();

            helpProvider1.HelpNamespace = CcHelpProvider.FullHelpFileName;

            InitializeControls();
            _presenter = new SettingsPresenter(securityService, sessionSettingsService, settingsControl, sysSettingPropertyCollectionManager);
            _presenter.InitializeView();
        }

        #region Dependencies
        private ILogger Logger { get; set; }
        private ISessionSettingsService SessionSettingsService { get; set; }
        private ILocalSettingsService LocalSettingsService { get; set; }
        private IApplicationStyleService ApplicationStyleService { get; set; }
        #endregion

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            _presenter.Refresh();
        }

        private void InitializeControls()
        {
            applyButton.Enabled = false;
        }

        private void ApplyChanges()
        {
            Logger.Trace("[Options] Applying styles.");

            var settingsProvider = SessionSettingsService.Current;
            ApplyApplicationStyle(settingsProvider);

            Logger.Trace("[Options] Applying ExplorerBarStyle.");
            //TODO: Restore explorerBarStyle
            var explorerBarStyle = settingsProvider.GetValue<ExplorerBarStyles>(CommonSettingsInfragistics.ExplorerBarStyle);
            //ServiceManager.Service<IExplorer>().SetStyle(explorerBarStyle);

            Logger.Trace("[Options] Applying CurrencyFormat.");
            CurrencyFormatProvider.DefaultCurrencyFormat = settingsProvider.GetValue<string>(CommonSettings.CurrencyFormat);

            //Logger.Trace("[Options] Applying AutoRefreshPeriodInHours.");
            //ServiceManager.Service<AutoRefresher>().AutoRefreshPeriod = settingsProvider.GetValue<int>(CommonSettings.AutoRefreshPeriodInHours);

            Logger.Trace("[Options] Styles applied. Exiting");
        }

        private void ApplyApplicationStyle(ISessionSettingsProvider sessionSettingsProvider)
        {
            var style = sessionSettingsProvider.ApplicationStyle;
            if (ApplicationStyleService.AvailableStyles.Any(s => s == style))
            {
                ApplicationStyleService.ApplyStyle(style);
            }
            else
            {
                ApplicationStyleService.ResetStyle();
            }
        }

        private void OnCancelButtonClick(object sender, EventArgs e)
        {
            if (applyButton.Enabled)
            {
                LocalSettingsService.Reset();
                SessionSettingsService.Reset();
            }
            Close();
        }

        private void OnOkButtonClick(object sender, EventArgs e)
        {
            //Logger.Trace("[Options] Applying changed options.");

            if (!Confirmed())
            {
                //Logger.Trace("[Options] Report path does not contain report configuration file. Exiting.");
                return;
            }

            if (applyButton.Enabled)
            {
                SaveChangesAndInitOptionsHelper();
            }

            //Logger.Trace("[Options] Options succesfully updated. Exiting.");
            Close();
        }

        private void SaveChangesAndInitOptionsHelper()
        {
            SessionSettingsService.Save();
            //Logger.Trace("[Options] Saving Settings to database.");
            LocalSettingsService.Save();
            ApplyChanges();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            //Logger.Trace("[Options] Applying changed options.");

            if (!Confirmed())
            {
                //Logger.Trace("[Options] Report path does not contain report configuration file. Exiting.");
                return;
            }

            SaveChangesAndInitOptionsHelper();

            //Logger.Trace("[Options] Updting presenter with new setings.");
            _presenter.Update();

            applyButton.Enabled = false;
            //Logger.Trace("[Options] Options succesfully updated. Exiting.");
        }

        

        private static bool Confirmed()
        {
            return true;
        }
        
        private void OnAfterValueChanged(string arg1, object arg2)
        {
            OnChanged();
        }

        private void OnAfterDefaultValueChanged(string arg1, object arg2)
        {
            OnChanged();
        }

        private void OnChanged()
        {
            applyButton.Enabled = true;
        }
    }
}