using System;
using BusinessFramework.Client.Contracts.DataObjects;
using Northwind.Contracts.DataObjects;


namespace Northwind.Client.Contracts.BusinessObjects
{

    [Serializable]
	public sealed class SysOperationLock : CodeBehind.CodeBehindSysOperationLock, IOperationLock
    {
        public SysOperationLock()
		{
		}

		private SysOperationLock(SysOperationLock origin)
		    :base(origin)
	    {
		}

		public override SysOperationLock Clone()
        {
            return new SysOperationLock(this);
        }	 
    }
}