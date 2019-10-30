using Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Interfaces.Bll
{
    public interface IUserMananger
    {
        List<ApplicationUser> GetAllUsers();
    }
}