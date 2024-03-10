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
    public class EpisodeConfiguration : IEntityTypeConfiguration<Episode>
    {
        public void Configure(EntityTypeBuilder<Episode> builder)
        {
            builder.ToTable("Episodes").HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("Id").IsRequired();
            builder.Property(c => c.Name).HasColumnName("Name");
            builder.Property(c => c.Air_Date).HasColumnName("Air_Date");
            builder.Property(c => c.EpisodeCode).HasColumnName("EpisodeCode");
            builder.Property(c => c.Url).HasColumnName("Url");
            //builder.Property(c => c.Characters).HasColumnName("Characters");

            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
        }
    }
}
