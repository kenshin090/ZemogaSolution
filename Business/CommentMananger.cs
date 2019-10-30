using Common.Interfaces.Bll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Entities;
using Common.Interfaces.Dao.Comment;

namespace Bll
{
    /// <summary>
    /// Mananger in business layer for comments
    /// </summary>
    public class CommentMananger : ICommentMananger
    {
        /// <summary>
        /// Dao mananger
        /// </summary>
        private ICommentDao Repo = null;

        /// <summary>
        /// builder for DI
        /// </summary>
        /// <param name="repo"></param>
        public CommentMananger(ICommentDao repo)
        {
            this.Repo = repo;
        }

        /// <summary>
        /// Method to create a new comment
        /// </summary>
        /// <param name="Entity"></param>
        /// <returns></returns>
        public Comment Create(Comment Entity)
        {
            Entity.CreatedDate = DateTime.Now;
            Repo.Insert(Entity);
            Repo.Save();
            return new Comment();
        }

        /// <summary>
        /// Method for delete a comment
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Delete(int id)
        {
            Repo.Delete(id);
            Repo.Save();
            return 1;
        }

        /// <summary>
        /// Method for get an specific comment by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Comment Get(int id)
        {
            return Repo.GetById(id);
        }

        /// <summary>
        /// Method for get all the comments
        /// </summary>
        /// <param name="all"></param>
        /// <returns></returns>
        public List<Comment> Search(bool all)
        {
            return Repo.GetAll().ToList();
        }

        /// <summary>
        /// Method for update a comment
        /// </summary>
        /// <param name="id"></param>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Comment Update(int id, Comment entity)
        {
            Repo.Update(entity);
            Repo.Save();
            return Repo.GetById(id);
        }
    }
}