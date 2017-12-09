using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF
{
    public class TestEntityConfig : IEntityTypeConfiguration<TestEntity>
    {
        public void Configure(EntityTypeBuilder<TestEntity> builder)
        {
            builder.ToTable("TestEntity");

            builder.HasKey(T => T.Id);
            builder.Property(i => i.Id).HasColumnName("idTestEntity");

            builder.Property(T => T.Name);
            builder.Property(T => T.Value);
        }
    }
}
