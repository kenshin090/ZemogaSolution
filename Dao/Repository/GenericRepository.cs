using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Interfaces.Dao;
using Dao.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Dao.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public TestContext _context = null;
        public DbSet<T> table = null;

        public GenericRepository(TestContext _context)
        {
            this._context = _context;
            table = _context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public T GetById(object id)
        {
            return table.Find(id);
        }

        public void Insert(T obj)
        {
            var added = table.Add(obj);
        }

        public void Update(T obj)
        {
            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }

        public void Delete(object id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }

        public int Save()
        {
            return _context.SaveChanges();
        }
    }
}