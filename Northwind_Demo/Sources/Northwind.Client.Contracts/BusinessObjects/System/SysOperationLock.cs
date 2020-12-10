using System;
using BusinessFramework.Client.Contracts.DataObjects;
using NorthWind.Contracts.DataObjects;


namespace NorthWind.Client.Contracts.BusinessObjects
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