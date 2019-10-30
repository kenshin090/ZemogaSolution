using Common.Entities;
using Common.Interfaces.Dao.User;
using Dao.Context;
using Dao.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dao.Access
{
    public class UserDao : GenericRepository<ApplicationUser>, IUserDao
    {
        public UserDao(TestContext _context) : base(_context)
        {
        }

        public List<ApplicationUser> GetAllUsers()
        {
            var listUsers = _context.Users.Include(u => u.UserRoles).ThenInclude(ur => ur.Role).ToList();
            return listUsers;
        }
    }
}