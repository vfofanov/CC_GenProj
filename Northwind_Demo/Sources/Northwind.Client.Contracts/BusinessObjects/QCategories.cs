using System;


namespace Northwind.Client.Contracts.BusinessObjects
{
    /// <inheritdoc />
    [Serializable]
	public sealed class QCategories : CodeBehind.CodeBehindQCategories
    {
        public QCategories()
		{
		}

		private QCategories(QCategories origin)
		    :base(origin)
	    {
		}

		public override QCategories Clone()
        {
            return new QCategories(this);
        }	 
    }
}