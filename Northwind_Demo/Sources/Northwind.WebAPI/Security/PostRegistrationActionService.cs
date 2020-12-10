using BusinessFramework.WebAPI.Contracts.Security;
using NorthWind.WebAPI.Contracts.Repositories;
using NorthWind.WebAPI.Contracts.Security;

namespace NorthWind.WebAPI.Security
{
    /// <summary>
    /// Class to process registered user
    /// </summary>
    public class PostRegistrationActionService : IPostRegistrationActionService
    {
        private readonly ISysUserRoleRepository _sysUserRoleRepository;
        private readonly ISysUserRepository _userRepository;

        /// <summary>
        /// Ctor
        /// </summary>
        public PostRegistrationActionService(ISysUserRoleRepository sysUserRoleRepository, ISysUserRepository userRepository)
        {
            _sysUserRoleRepository = sysUserRoleRepository;
            _userRepository = userRepository;
        }

        /// <summary>
        /// Invoked after new user registered
        /// </summary>
        /// <param name="sysUser">User</param>
        public void OnUserRegistered(ISysUser sysUser)
        {
            /*var role = new SysUserRole
            {
                RoleId = 1, // Admin
                UserId = sysUser.Id
            };
            _sysUserRoleRepository.Create(role);*/

            // just set Full access in Northwind            
            var user = _userRepository.GetByKey(sysUser.Id);                
            user.FullAccess = true;
            _userRepository.Update(user);
            _userRepository.Save();

        }
    }
}
