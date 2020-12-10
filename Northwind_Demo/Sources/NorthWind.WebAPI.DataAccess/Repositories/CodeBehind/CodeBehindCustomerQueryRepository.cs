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
    /// Repository for <see cref="CodeBehindCustomerQueryRepository"/> objects
    /// </summary>
    public abstract class CodeBehindCustomerQueryRepository : ClassicQueryRepository<CustomerQuery, int, Customers, IApiDbContext>
    {
        /// <summary>
        /// Ctor
        /// </summary>
        protected CodeBehindCustomerQueryRepository(IApiDbContext context) 
		    : base(context)
        {
        }


        /// <summary>
        /// Applying sorting to result set
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
		protected override IQueryable<CustomerQuery> ApplySorting(IQueryable<CustomerQuery> source)
        {
            return source.OrderBy(o => o.CompanyName);
        }

        /// <summary>
        /// Select <see cref="CustomerQuery"/> objects from <see cref="Customers"/> objects
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
		protected override IQueryable<CustomerQuery> Set(IQueryable<Customers> source)
        {
            return source.Select(o => new CustomerQuery
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
        public override CustomerQuery Create(CustomerQuery entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override CustomerQuery Update(CustomerQuery entity)
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
        public override void Delete(CustomerQuery entity)
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