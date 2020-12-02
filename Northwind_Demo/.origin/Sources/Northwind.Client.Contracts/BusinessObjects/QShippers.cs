using System;


namespace Northwind.Client.Contracts.BusinessObjects
{
    /// <inheritdoc />
    [Serializable]
	public sealed class QShippers : CodeBehind.CodeBehindQShippers
    {
        public QShippers()
		{
		}

		private QShippers(QShippers origin)
		    :base(origin)
	    {
		}

		public override QShippers Clone()
        {
            return new QShippers(this);
        }	 
    }
}