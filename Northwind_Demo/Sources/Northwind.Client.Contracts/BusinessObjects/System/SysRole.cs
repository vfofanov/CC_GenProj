using System;


namespace Northwind.Client.Contracts.BusinessObjects
{
    /// <inheritdoc />
    [Serializable]
	public sealed class SysRole : CodeBehind.CodeBehindSysRole
    {
        public SysRole()
		{
		}

		private SysRole(SysRole origin)
		    :base(origin)
	    {
		}

		public override SysRole Clone()
        {
            return new SysRole(this);
        }	 
    }
}