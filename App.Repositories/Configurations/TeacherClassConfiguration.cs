

//using App.Repositories.Models;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using System.Reflection.Emit;

//namespace app.repositories.configurations
//{
//	public class teacherclassconfiguration : IEntityTypeConfiguration<TeacherClass>
//	{
//		public void Configure(EntityTypeBuilder<TeacherClass> builder)
//		{
//			builder.HasKey(tc => new { tc.TeacherId, tc.ClassId });

//			builder.HasOne(x => x.Teacher).WithMany(x => x.TeacherClasses).HasForeignKey(x => x.TeacherId);
//			builder.HasOne(x => x.SchoolClass).WithMany(x => x.TeacherClasses).HasForeignKey(x => x.ClassId);
//		}
//	}
//}
