using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Interfaces.Dao
{
    /// <summary>
    /// Generic repository of EF core
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IGenericRepository<T> where T : class
    {
        /// <summary>
        /// get all entities
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> GetAll();

        /// <summary>
        /// get specific entity by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T GetById(object id);

        /// <summary>
        /// insert new entity
        /// </summary>
        /// <param name="obj"></param>
        void Insert(T obj);

        /// <summary>
        /// update an entity
        /// </summary>
        /// <param name="obj"></param>
        void Update(T obj);

        /// <summary>
        /// delete an entity
        /// </summary>
        /// <param name="id"></param>
        void Delete(object id);

        /// <summary>
        /// save context
        /// </summary>
        /// <returns></returns>
        int Save();
    }
}