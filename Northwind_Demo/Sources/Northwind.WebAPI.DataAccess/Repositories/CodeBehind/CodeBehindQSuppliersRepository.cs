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
    /// Repository for <see cref="CodeBehindQSuppliersRepository"/> objects
    /// </summary>
    public abstract class CodeBehindQSuppliersRepository : ClassicQueryRepository<QSuppliers, int, Supplier, IApiDbContext>
    {
        /// <summary>
        /// Ctor
        /// </summary>
        protected CodeBehindQSuppliersRepository(IApiDbContext context) 
		    : base(context)
        {
        }


        /// <summary>
        /// Applying sorting to result set
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
		protected override IQueryable<QSuppliers> ApplySorting(IQueryable<QSuppliers> source)
        {
            return source.OrderBy(o => o.CompanyName);
        }

        /// <summary>
        /// Select <see cref="QSuppliers"/> objects from <see cref="Supplier"/> objects
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
		protected override IQueryable<QSuppliers> Set(IQueryable<Supplier> source)
        {
            return source.Select(o => new QSuppliers
            {
					Id = o.Id,
					Address = o.Address,
					City = o.City,
					CompanyName = o.CompanyName,
					ContactName = o.ContactName,
					ContactTitle = o.ContactTitle,
					Country = o.Country,
					Fax = o.Fax,
					HomePage = o.HomePage,
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
        public override QSuppliers Create(QSuppliers entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override QSuppliers Update(QSuppliers entity)
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
        public override void Delete(QSuppliers entity)
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