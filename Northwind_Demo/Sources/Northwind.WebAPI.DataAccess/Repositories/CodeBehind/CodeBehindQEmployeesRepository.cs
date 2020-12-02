using System;
using System.Data.Entity;
using System.Data.Entity.SqlServer;
using System.Linq;
using BusinessFramework.WebAPI.Common.Data;
using BusinessFramework.WebAPI.Contracts.Files;
using Northwind.Contracts;
using Northwind.Contracts.Enums;
using Northwind.WebAPI.Contracts;
using Northwind.WebAPI.Contracts.DataObjects;
using Northwind.WebAPI.Contracts.Repositories;


namespace Northwind.WebAPI.DataAccess.Repositories.CodeBehind
{
    /// <summary>
    /// Repository for <see cref="CodeBehindQEmployeesRepository"/> objects
    /// </summary>
    public abstract class CodeBehindQEmployeesRepository : ClassicQueryRepository<QEmployees, int, Employee, IApiDbContext>
    {
        /// <summary>
        /// Ctor
        /// </summary>
        protected CodeBehindQEmployeesRepository(IApiDbContext context) 
		    : base(context)
        {
        }


        /// <summary>
        /// Applying sorting to result set
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
		protected override IQueryable<QEmployees> ApplySorting(IQueryable<QEmployees> source)
        {
            return source.OrderBy(o => o.LastName);
        }

        /// <summary>
        /// Select <see cref="QEmployees"/> objects from <see cref="Employee"/> objects
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
		protected override IQueryable<QEmployees> Set(IQueryable<Employee> source)
        {
            return source.Select(o => new QEmployees
            {
					Id = o.Id,
					Address = o.Address,
					BirthDate = o.BirthDate,
					City = o.City,
					Country = o.Country,
					Employee_FullName = " " + (o.LastName ?? string.Empty) + " " + (o.FirstName ?? string.Empty),
					Extension = o.Extension,
					FirstName = o.FirstName,
					HireDate = o.HireDate,
					HomePhone = o.HomePhone,
					LastName = o.LastName,
					Notes = o.Notes,
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
        public override QEmployees Create(QEmployees entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override QEmployees Update(QEmployees entity)
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
        public override void Delete(QEmployees entity)
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