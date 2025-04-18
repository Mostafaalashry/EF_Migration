using EF_Migration.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_Migration.Data.Configuration
{
    public class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id)
                .ValueGeneratedNever();
            builder.Property(c => c.Name)
                .HasColumnType("VARCHAR")
                .HasMaxLength(100)
                .IsRequired();


            builder.ToTable("Instructors");
            builder.HasData(LoadInstructors());
        }

        private static List<Instructor> LoadInstructors()
        {
            return new List<Instructor>
            {
                new Instructor {Id =1,Name="ahmed"},
                new Instructor {Id =2,Name="ali"},
                new Instructor {Id =3,Name="mohamed"},
                new Instructor {Id =4,Name="sara"},
                new Instructor {Id =5,Name="george"},

            };
        }
    }

}

