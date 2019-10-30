using System;
using System.Collections.Generic;
using System.Text;
using Common.Entities;
using Common.Interfaces.Dao.Comment;
using Dao.Context;
using Dao.Repository;

namespace Dao.Access
{
    public class CommentDao : GenericRepository<Comment>, ICommentDao
    {
        public CommentDao(TestContext _context) : base(_context)
        {
        }
    }
}