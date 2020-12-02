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
    /// Repository for <see cref="CodeBehindQCategoriesRepository"/> objects
    /// </summary>
    public abstract class CodeBehindQCategoriesRepository : ClassicQueryRepository<QCategories, int, Category, IApiDbContext>
    {
        /// <summary>
        /// Ctor
        /// </summary>
        protected CodeBehindQCategoriesRepository(IApiDbContext context) 
		    : base(context)
        {
        }


        /// <summary>
        /// Applying sorting to result set
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
		protected override IQueryable<QCategories> ApplySorting(IQueryable<QCategories> source)
        {
            return source.OrderBy(o => o.CategoryName);
        }

        /// <summary>
        /// Select <see cref="QCategories"/> objects from <see cref="Category"/> objects
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
		protected override IQueryable<QCategories> Set(IQueryable<Category> source)
        {
            return source.Select(o => new QCategories
            {
					Id = o.Id,
					CategoryName = o.CategoryName,
					Description = o.Description,
					Picture = o.Picture,
  
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override QCategories Create(QCategories entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override QCategories Update(QCategories entity)
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
        public override void Delete(QCategories entity)
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