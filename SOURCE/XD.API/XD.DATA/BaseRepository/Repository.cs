using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace XD.DATA.BaseRepository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public DbContext DbContext { get; set; }

        public DbSet<T> DbSet { get => DbContext.Set<T>(); }

        public void Create(T t)
        {
            DbSet.Add(t);
        }

        public void Delete(T t)
        {
            DbSet.Remove(t);
        }

        public IEnumerable<T> GetAll()
        {
            return DbSet.ToList();
        }

        public T Get(Expression<Func<T, bool>> expression)
        {
            return DbSet.Where(expression).SingleOrDefault();
        }

        public IEnumerable<T> Gets(Expression<Func<T, bool>> expression)
        {
            return DbSet.Where(expression);
        }

        public void Update(T t)
        {
            DbSet.Update(t);
        }
    }
}
