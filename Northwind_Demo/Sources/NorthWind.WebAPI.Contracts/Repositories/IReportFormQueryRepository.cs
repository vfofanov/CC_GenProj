using System;
using BusinessFramework.WebAPI.Contracts.Data;
using NorthWind.WebAPI.Contracts.DataObjects;

namespace NorthWind.WebAPI.Contracts.Repositories
{
    /// <summary>
    /// Repository for  <see cref="ReportFormQuery"/> entity
    /// </summary>
    public interface IReportFormQueryRepository : IClassicQueryRepository<ReportFormQuery, int>
    {
    }
}