using System;
using BusinessFramework.WebAPI.Contracts.Files.Storage;
using FutureTechnologies.DI.Contracts;
using NorthWind.WebAPI.Contracts;


namespace NorthWind.WebAPI.File
{
    /// <inheritdoc />
    public sealed class FileStorageSaveOptionsSwitcher : FileStorageSaveOptionsSwitcherBase
    {
        private readonly IScope _scope;

        /// <inheritdoc />
        public FileStorageSaveOptionsSwitcher(IScope scope)
        {
            _scope = scope;
        }

        /// <inheritdoc />
        protected override IFileStorageSaveOptionsResolver GetResolver(int fieldId)
        {
            switch (fieldId)
            {
                case DomainObjectPropertyKeys.Employees.DocumentScanFileId:
                    return _scope.Resolve<EmployeesFileStorageSaveOptionsResolver>();
                default:
                    throw new ArgumentOutOfRangeException(nameof(fieldId), $"Unknown fieldId={fieldId}");
            }
        }
    }
}