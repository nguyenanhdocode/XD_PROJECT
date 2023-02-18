using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace XD.DATA.BaseRepository
{
    public interface IRepository<T> where T: class
    {
        public DbContext DbContext { get; set; }
        public DbSet<T> DbSet { get; }
        IEnumerable<T> GetAll();
        T Get(Expression<Func<T, bool>> expression);
        IEnumerable<T> Gets(Expression<Func<T, bool>> expression);
        void Create(T t);
        void Update(T t);
        void Delete(T t);
    }
}
