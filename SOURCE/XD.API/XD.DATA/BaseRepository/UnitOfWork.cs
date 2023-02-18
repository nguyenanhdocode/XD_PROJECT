using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XD.DATA.EntityModels;

namespace XD.DATA.BaseRepository
{
    public class UnitOfWork
    {
        private AppDbContext _dbContext;
        public IRepository<User> UserRep { get; set; }

        public UnitOfWork(AppDbContext appDbContext
            , IRepository<User> userRep)
        {
            _dbContext = appDbContext;

            UserRep = userRep;
            UserRep.DbContext = _dbContext;
        }

        public int SaveChange()
        {
            return _dbContext.SaveChanges();
        }
    }
}
