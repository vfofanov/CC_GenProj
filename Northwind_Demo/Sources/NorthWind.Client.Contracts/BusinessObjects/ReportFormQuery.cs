using System;


namespace NorthWind.Client.Contracts.BusinessObjects
{
    /// <inheritdoc />
    [Serializable]
	public sealed class ReportFormQuery : CodeBehind.CodeBehindReportFormQuery
    {
        public ReportFormQuery()
		{
		}

		private ReportFormQuery(ReportFormQuery origin)
		    :base(origin)
	    {
		}

		public override ReportFormQuery Clone()
        {
            return new ReportFormQuery(this);
        }	 
    }
}