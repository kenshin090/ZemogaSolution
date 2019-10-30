using System;
using System.Collections.Generic;
using System.Text;
using Common.Entities;
using Common.Interfaces.Bll.Generic;

namespace Common.Interfaces.Bll
{
    public interface IPostMananger : IRepository<Post>
    {
        List<Post> GetAllPost(bool isAuth);
    }
}