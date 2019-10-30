using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Interfaces.Dao.Post
{
    public interface IPostDao : IGenericRepository<Entities.Post>
    {
        List<Entities.Post> GetAllPost(bool isAuth);
    }
}