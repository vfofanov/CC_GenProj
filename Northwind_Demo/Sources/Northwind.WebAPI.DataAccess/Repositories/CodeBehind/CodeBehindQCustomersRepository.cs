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
    /// Repository for <see cref="CodeBehindQCustomersRepository"/> objects
    /// </summary>
    public abstract class CodeBehindQCustomersRepository : ClassicQueryRepository<QCustomers, int, Customer, IApiDbContext>
    {
        /// <summary>
        /// Ctor
        /// </summary>
        protected CodeBehindQCustomersRepository(IApiDbContext context) 
		    : base(context)
        {
        }


        /// <summary>
        /// Applying sorting to result set
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
		protected override IQueryable<QCustomers> ApplySorting(IQueryable<QCustomers> source)
        {
            return source.OrderBy(o => o.CompanyName);
        }

        /// <summary>
        /// Select <see cref="QCustomers"/> objects from <see cref="Customer"/> objects
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
		protected override IQueryable<QCustomers> Set(IQueryable<Customer> source)
        {
            return source.Select(o => new QCustomers
            {
					Id = o.Id,
					Address = o.Address,
					City = o.City,
					CompanyName = o.CompanyName,
					ContactName = o.ContactName,
					ContactTitle = o.ContactTitle,
					Country = o.Country,
					Fax = o.Fax,
					Phone = o.Phone,
					PostalCode = o.PostalCode,
					Region = o.Region,
  
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override QCustomers Create(QCustomers entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override QCustomers Update(QCustomers entity)
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
        public override void Delete(QCustomers entity)
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