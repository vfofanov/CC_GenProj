using System.Linq;
using Northwind.Client.Contracts.BusinessObjects;
using Northwind.Client.Services.Contracts.DomainModel;
using BusinessFramework.Client.Common.DomainModel;
using BusinessFramework.Client.Contracts.Connection;
using BusinessFramework.Client.Contracts.Services.Dialogs;

namespace Northwind.Client.ServerServices.DomainModel
{
    /// <inheritdoc cref="CodeBehind.CodeBehindSysSettingPropertyCollectionManager" />
    public sealed class SysSettingPropertyCollectionManager : CodeBehind.CodeBehindSysSettingPropertyCollectionManager, ISysSettingPropertyCollectionManager
    {
        /// <inheritdoc />
        public SysSettingPropertyCollectionManager(IControllerClientFactory clientFactory,
            IMessageBoxService messageBoxService) 
            : base(clientFactory, messageBoxService)
        {
        }

        /// <inheritdoc />
        public bool TryGetSettingProperty(string settingName, out SysSettingProperty settingProperty)
        {
            // ReSharper disable once ReplaceWithSingleCallToFirstOrDefault
            settingProperty = GetAllObjects().Where(o => o.Name == settingName).FirstOrDefault();
            return settingProperty != null;
        }
    }
}