using System;
using EF_Migration.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_Migration.Data.Configuration
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id)
                .ValueGeneratedNever();
            builder.Property(c => c.CourseName)
                .HasColumnType("VARCHAR")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(c => c.Price)
             .HasColumnType("decimal(15,2)");

            builder.ToTable("Courses");
            builder.HasData(LoadCourses());
        }

        private static List<Course> LoadCourses()
        {
            return new List<Course>
            {
                new Course {Id =1,CourseName="mathmatics",Price=1000m},
                new Course {Id =2,CourseName="physics",Price=2000m},
                new Course {Id =3,CourseName="chemistry",Price=4000m},
                new Course {Id =4,CourseName="Biology",Price=1660m},
                new Course {Id =5,CourseName="english",Price=3000m},

            };
        }
    }

}

