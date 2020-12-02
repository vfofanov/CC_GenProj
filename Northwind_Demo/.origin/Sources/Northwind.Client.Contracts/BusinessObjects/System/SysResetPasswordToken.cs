using System;


namespace Northwind.Client.Contracts.BusinessObjects
{
    /// <inheritdoc />
    [Serializable]
	public sealed class SysResetPasswordToken : CodeBehind.CodeBehindSysResetPasswordToken
    {
        public SysResetPasswordToken()
		{
		}

		private SysResetPasswordToken(SysResetPasswordToken origin)
		    :base(origin)
	    {
		}

		public override SysResetPasswordToken Clone()
        {
            return new SysResetPasswordToken(this);
        }	 
    }
}