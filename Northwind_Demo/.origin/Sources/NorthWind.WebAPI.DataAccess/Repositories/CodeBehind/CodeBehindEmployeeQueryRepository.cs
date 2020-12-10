using System;
using System.Data.Entity;
using System.Data.Entity.SqlServer;
using System.Linq;
using BusinessFramework.WebAPI.Common.Data;
using BusinessFramework.WebAPI.Contracts.Files;
using NorthWind.Contracts;
using NorthWind.Contracts.Enums;
using NorthWind.WebAPI.Contracts;
using NorthWind.WebAPI.Contracts.DataObjects;
using NorthWind.WebAPI.Contracts.Repositories;


namespace NorthWind.WebAPI.DataAccess.Repositories.CodeBehind
{
    /// <summary>
    /// Repository for <see cref="CodeBehindEmployeeQueryRepository"/> objects
    /// </summary>
    public abstract class CodeBehindEmployeeQueryRepository : ClassicQueryRepository<EmployeeQuery, int, Employees, IApiDbContext>
    {
        /// <summary>
        /// Ctor
        /// </summary>
        protected CodeBehindEmployeeQueryRepository(IApiDbContext context) 
		    : base(context)
        {
        }


        /// <summary>
        /// Applying sorting to result set
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
		protected override IQueryable<EmployeeQuery> ApplySorting(IQueryable<EmployeeQuery> source)
        {
            return source.OrderBy(o => o.LastName);
        }

        /// <summary>
        /// Select <see cref="EmployeeQuery"/> objects from <see cref="Employees"/> objects
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
		protected override IQueryable<EmployeeQuery> Set(IQueryable<Employees> source)
        {
            return source.Select(o => new EmployeeQuery
            {
					Id = o.Id,
					Address = o.Address,
					BirthDate = o.BirthDate,
					City = o.City,
					Country = o.Country,
					DocumentScanFileId = o.DocumentScanFileId,
					Employee_FullName = " " + (o.LastName ?? string.Empty) + " " + (o.FirstName ?? string.Empty),
					Extension = o.Extension,
					FirstName = o.FirstName,
					HireDate = o.HireDate,
					HomePhone = o.HomePhone,
					LastName = o.LastName,
					Notes = o.Notes,
					Photo = o.Photo,
					PostalCode = o.PostalCode,
					Region = o.Region,
					ReportsTo = o.ReportsTo,
					Title = o.Title,
					TitleOfCourtesy = o.TitleOfCourtesy,
  
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override EmployeeQuery Create(EmployeeQuery entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override EmployeeQuery Update(EmployeeQuery entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Delete(int key)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Delete(EmployeeQuery entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public override void Save()
        {
            Context.SaveChanges();
        }
    }
}