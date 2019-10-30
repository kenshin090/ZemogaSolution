using Common.Entities;
using System.Collections.Generic;

namespace Common.Interfaces.Dao.User
{
    public interface IUserDao : IGenericRepository<ApplicationUser>
    {
        List<ApplicationUser> GetAllUsers();
    }
}