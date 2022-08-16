using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkPattern.Domain.Entity;

namespace UnitOfWorkPattern.EntityFrameworkCore
{
    public class UnitOfWorkPatternDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public UnitOfWorkPatternDbContext(DbContextOptions<UnitOfWorkPatternDbContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new BookConfiguration());
        }
    }
}
