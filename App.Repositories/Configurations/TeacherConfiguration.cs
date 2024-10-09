//using App.Repositories.Models;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace App.Repositories.Configurations
//{
//	public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
//	{
//		public void Configure(EntityTypeBuilder<Teacher> builder)
//		{
//			builder.HasKey(x => x.TeacherId);
//			builder.Property(x => x.Name).IsRequired();

//			builder.HasMany(x => x.TeacherCourses).WithOne(x => x.Teacher).HasForeignKey(x => x.TeacherId);
//			builder.HasMany(x => x.TeacherClasses).WithOne(x => x.Teacher).HasForeignKey(x => x.TeacherId);
//		}
//	}
//}
