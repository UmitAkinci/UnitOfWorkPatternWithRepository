using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkPattern.Domain.Entity;

namespace UnitOfWorkPattern.EntityFrameworkCore
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(m => m.Name).IsRequired().HasMaxLength(100);

            builder.ToTable("Books");
        }
    }
}
