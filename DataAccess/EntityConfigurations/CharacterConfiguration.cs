using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityConfigurations
{
    public class CharacterConfiguration : IEntityTypeConfiguration<Character>
    {
        public void Configure(EntityTypeBuilder<Character> builder)
        {
            builder.ToTable("Characters").HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("Id").IsRequired();
            builder.Property(c => c.Name).HasColumnName("Name");
            builder.Property(c => c.Status).HasColumnName("Status");
            builder.Property(c => c.Species).HasColumnName("Species");
            builder.Property(c => c.Type).HasColumnName("Type");
            builder.Property(c => c.Gender).HasColumnName("Gender");
            builder.Property(c => c.Image).HasColumnName("Image");
            builder.Property(c => c.Url).HasColumnName("Url");
            //builder.Property(c => c.Episode).HasColumnName("Episode");

            //builder.HasOne(c => c.Location);
            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
        }
    }
}
