using App.Repositories.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repositories.Configurations
{
	public class StudentConfiguration : IEntityTypeConfiguration<Student>
	{
		public void Configure(EntityTypeBuilder<Student> builder)
		{
			builder.HasKey(x => x.StudentId); //Primary key olduğunu belirtiriz
			builder.Property(x => x.Name).IsRequired().HasMaxLength(150);
			builder.Property(x => x.SchoolClassId).IsRequired();
			//builder.Property(x=> x.StudentCourses).IsRequired();
			builder.HasMany(x => x.StudentCourses).WithOne(x => x.Student).HasForeignKey(x => x.StudentId);
			//bire çok ilişki icollectionı nereye yazdıysak o classa yazarız.

			builder
				.HasOne(s => s.SchoolClass)          
				.WithMany(sc => sc.Students)         
				.HasForeignKey(s => s.SchoolClassId) 
				.OnDelete(DeleteBehavior.Cascade);   			
		}
	}
}
