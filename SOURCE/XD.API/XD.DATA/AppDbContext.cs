using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XD.DATA.EntityModels;

namespace XD.DATA
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>().HasKey("Email");
            builder.Entity<User>(e => 
            {
                e.Property(p => p.APK).IsRequired().HasDefaultValue(Guid.NewGuid());
                e.Property(p => p.Email).IsRequired().HasColumnType("varchar(255)");
                e.Property(p => p.Password).IsRequired();
                e.Property(p => p.FirstName).IsRequired(false);
                e.Property(p => p.LastName).IsRequired(false);
                e.Property(p => p.Dob).IsRequired(false);
                e.Property(p => p.IsActivated).IsRequired().HasDefaultValue(false);
                e.Property(p => p.IsDisabled).IsRequired().HasDefaultValue(false);
                e.Property(p => p.Created).IsRequired(false).HasDefaultValue(DateTime.Now);
                e.Property(p => p.Updated).IsRequired(false);
                e.Property(p => p.Facebook).IsRequired(false);
                e.Property(p => p.Twitter).IsRequired(false);
                e.Property(p => p.Instagram).IsRequired(false);
            });
        }
        public DbSet<User> Users { get; set; }
    }
}
