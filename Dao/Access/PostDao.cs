using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Entities;
using Common.Interfaces.Dao.Post;
using Dao.Context;
using Dao.Repository;
using Microsoft.EntityFrameworkCore;

namespace Dao.Access
{
    public class PostDao : GenericRepository<Post>, IPostDao
    {
        public PostDao(TestContext _context) : base(_context)
        {
        }

        public List<Post> GetAllPost(bool isAuth)
        {
            List<Post> list = null;
            list = _context.Posts.Include("Comments").Where(post => true == isAuth || post.Status == true).ToList();
            return list;
        }
    }
}