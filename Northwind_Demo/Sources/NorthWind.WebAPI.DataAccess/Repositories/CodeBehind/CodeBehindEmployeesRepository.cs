using System;
using System.Data.Entity;
using System.Linq;
using BusinessFramework.Contracts;
using BusinessFramework.WebAPI.Common.Data;
using BusinessFramework.WebAPI.Contracts.Data;
using BusinessFramework.WebAPI.Contracts.Files;
using NorthWind.Contracts.DataObjects;
using NorthWind.WebAPI.Contracts;
using NorthWind.WebAPI.Contracts.DataObjects;
using NorthWind.WebAPI.Contracts.Repositories;


namespace NorthWind.WebAPI.DataAccess.Repositories.CodeBehind
{
    /// <summary>
    /// Repository for <see cref="CodeBehindEmployeesRepository"/> objects
    /// </summary>
    public abstract class CodeBehindEmployeesRepository : ClassicEntityRepository<Employees, int, IApiDbContext>
    {
        /// <summary>
        /// Ctor
        /// </summary>
        protected CodeBehindEmployeesRepository(IApiDbContext context, IFileLinkRepository fileLinkRepository) 
		    :base(context)
        {
		    FileLinkRepository = fileLinkRepository;

        }

		/// <summary>
		/// Dependency
		/// </summary>
		protected IFileLinkRepository FileLinkRepository { get; set; }

        /// <inheritdoc />
        public override IQueryable<Employees> Set(bool securedSelect = true, QuickFilter quickFilter = null)
        {
            return base.Set(securedSelect, quickFilter)
                .Include(o => o.DocumentScanFileId);
        }
        
        /// <inheritdoc />
        public override Employees Create(Employees obj)
        {

            #region DocumentScanFileId
            obj.FileLink_DocumentScanFileId = null;
            if (obj.DocumentScanFileId == null || string.IsNullOrEmpty(obj.DocumentScanFileId.UploadLink))
            {
                obj.DocumentScanFileId = null;
            }
            else
            {
                obj.DocumentScanFileId.Id = 0;
                obj.DocumentScanFileId = FileLinkRepository.Create(obj.DocumentScanFileId);
            }
            #endregion
            return base.Create(obj);
        }

        /// <inheritdoc />
        public override Employees Update(Employees obj)
        {
            var dbObj = GetByKey(obj.GetKey());
            //NOTE: Handle File links
            #region DocumentScanFileId
            if (obj.DocumentScanFileId == null)
            {
                dbObj.FileLink_DocumentScanFileId = obj.FileLink_DocumentScanFileId = null;
                dbObj.DocumentScanFileId = null;
            }
            else if (obj.DocumentScanFileId.Id == 0)
            {
                if (string.IsNullOrEmpty(obj.DocumentScanFileId.UploadLink))
                {
                    throw new Exception("Trying add file link with empty upload link");
                }

                obj.DocumentScanFileId.Id = 0;
                dbObj.FileLink_DocumentScanFileId = obj.FileLink_DocumentScanFileId = 0;
                obj.DocumentScanFileId = dbObj.DocumentScanFileId = FileLinkRepository.Create(obj.DocumentScanFileId);
            }
            else
            {
                obj.FileLink_DocumentScanFileId = dbObj.FileLink_DocumentScanFileId;
                obj.DocumentScanFileId = dbObj.DocumentScanFileId;
            }
            #endregion
            return base.Update(obj);
        }
    
    }
}