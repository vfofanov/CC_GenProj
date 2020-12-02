using System;


namespace Northwind.Client.Contracts.BusinessObjects
{
    /// <inheritdoc />
    [Serializable]
	public sealed class QEmployees : CodeBehind.CodeBehindQEmployees
    {
        public QEmployees()
		{
		}

		private QEmployees(QEmployees origin)
		    :base(origin)
	    {
		}

		public override QEmployees Clone()
        {
            return new QEmployees(this);
        }	 
    }
}