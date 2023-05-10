using System;
using CourseManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CourseManager.Persistence.Configurations
{
    internal sealed class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable(nameof(Course));

            builder.HasKey(x => new { x.Id });
        }
    }
}

