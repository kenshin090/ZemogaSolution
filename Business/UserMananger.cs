using Common.Entities;
using Common.Interfaces.Bll;
using Common.Interfaces.Dao.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    /// <summary>
    /// Mananger in business layer for posts
    /// </summary>
    public class UserMananger : IUserMananger
    {
        /// <summary>
        /// mananger in dao layer
        /// </summary>
        private IUserDao Repo = null;

        /// <summary>
        /// builder for injection
        /// </summary>
        /// <param name="repo"></param>
        public UserMananger(IUserDao repo)
        {
            Repo = repo;
        }

        /// <summary>
        /// return all users exist
        /// </summary>
        /// <returns></returns>
        public List<ApplicationUser> GetAllUsers()
        {
            return Repo.GetAllUsers();
        }
    }
}