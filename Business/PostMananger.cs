using System;
using System.Collections.Generic;
using System.Linq;
using Common.Entities;
using Common.Interfaces.Bll;
using Common.Interfaces.Dao;
using Common.Interfaces.Dao.Post;

namespace Bll
{
    /// <summary>
    ///  Mananger in business layer for posts
    /// </summary>
    public class PostMananger : IPostMananger
    {
        /// <summary>
        /// Manager in dao layer
        /// </summary>
        private IPostDao Repo = null;

        /// <summary>
        /// builder for injection
        /// </summary>
        /// <param name="repo"></param>
        public PostMananger(IPostDao repo)
        {
            Repo = repo;
        }

        /// <summary>
        /// Method for create a new post
        /// </summary>
        /// <param name="Entity"></param>
        /// <returns></returns>
        public Post Create(Post Entity)
        {
            Entity.CreatedDate = DateTime.Now;
            Entity.Status = false;
            Repo.Insert(Entity);
            Repo.Save();
            return new Post();
        }

        /// <summary>
        /// Method for delete an existing post by id
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
        /// Method for get an specific post by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Post Get(int id)
        {
            return Repo.GetById(id);
        }

        /// <summary>
        /// Method for get all posts
        /// </summary>
        /// <param name="isAuth"></param>
        /// <returns></returns>
        public List<Post> GetAllPost(bool isAuth)
        {
            return Repo.GetAllPost(isAuth);
        }

        public List<Post> Search(bool all)
        {
            return Repo.GetAll().ToList();
        }

        /// <summary>
        /// Method for update a post
        /// </summary>
        /// <param name="id"></param>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Post Update(int id, Post entity)
        {
            entity.UpdatedDate = DateTime.Now;
            Repo.Update(entity);
            Repo.Save();
            return Repo.GetById(id);
        }
    }
}