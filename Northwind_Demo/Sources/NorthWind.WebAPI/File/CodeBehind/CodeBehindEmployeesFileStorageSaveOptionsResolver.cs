using System;
using BusinessFramework.WebAPI.Contracts.Files.Storage;
using NorthWind.WebAPI.Contracts;
using NorthWind.WebAPI.Contracts.DataObjects;

namespace NorthWind.WebAPI.File.CodeBehind
{
    /// <summary>
    /// Save file storage options resolver for <see cref="Employees"/>
    /// </summary>
    public abstract class CodeBehindEmployeesFileStorageSaveOptionsResolver : IFileStorageSaveOptionsResolver
    {
        /// <summary>
        /// Ctor
        /// </summary>
        protected CodeBehindEmployeesFileStorageSaveOptionsResolver()
        {
        }


        /// <inheritdoc />
        public FileStorageSaveOptions GetSaveOptions(FileStorageType fileStorageType, int fieldId, object entity)
        {
            switch (fieldId)
            {
                #region DocumentScanFileId
                case DomainObjectPropertyKeys.Employees.DocumentScanFileId:
                    switch (fileStorageType)
                    {
                        case FileStorageType.None:
                            return null;
                        case FileStorageType.FileSystem:
                            return GetDocumentScanFileId_FileSystemSaveOptions((Employees) entity);
                        case FileStorageType.Database:
                            return GetDocumentScanFileId_DatabaseSaveOptions((Employees) entity);
                        case FileStorageType.AzureBlob:
                            return GetDocumentScanFileId_AzureBlobSaveOptions((Employees) entity);
                        case FileStorageType.Custom:
                            return GetDocumentScanFileId_CustomSaveOptions((Employees) entity);
                        default:
                            throw new ArgumentOutOfRangeException(nameof(fileStorageType), fileStorageType, null);
                    }
                #endregion
                default:
                    throw new ArgumentOutOfRangeException(nameof(fieldId), $"Unknown fieldId={fieldId}");
            }
        }
        protected virtual FileSystemFileStorageSaveOptions GetDocumentScanFileId_FileSystemSaveOptions(Employees entity)
        {
            return new FileSystemFileStorageSaveOptions(/* ERROR: origin is null */);
			
        }
        protected virtual CustomFileStorageSaveOptions GetDocumentScanFileId_CustomSaveOptions(Employees entity)
        {
            return new CustomFileStorageSaveOptions(entity);
        }
        private AzureBlobFileStorageSaveOptions GetDocumentScanFileId_AzureBlobSaveOptions(Employees entity)
        {
            return null;
        }
		private DatabaseFileStorageSaveOptions GetDocumentScanFileId_DatabaseSaveOptions(Employees entity)
        {
            return null;
        }
    }
}