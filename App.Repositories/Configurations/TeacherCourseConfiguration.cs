//using App.Repositories.Models;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection.Emit;
//using System.Text;
//using System.Threading.Tasks;

//namespace App.Repositories.Configurations
//{
//	public class TeacherCourseConfiguration : IEntityTypeConfiguration<TeacherCourse>
//	{
//		public void Configure(EntityTypeBuilder<TeacherCourse> builder)
//		{
//			builder.HasKey(tc => new { tc.TeacherId, tc.CourseId });

//			builder.HasOne(x => x.Teacher).WithMany(x => x.TeacherCourses).HasForeignKey(x => x.TeacherId);
//			builder.HasOne(x => x.Course).WithMany(x => x.TeacherCourses).HasForeignKey(x => x.CourseId);
//		}
//	}
//}
