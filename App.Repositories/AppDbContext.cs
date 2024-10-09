using App.Repositories.Configurations;
using App.Repositories.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace App.Repositories
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
		{
		}

		public DbSet<Student> Students { get; set; }
		//public DbSet<Teacher> Teachers { get; set; }
		public DbSet<SchoolClass> Classes { get; set; }
		public DbSet<Course> Courses { get; set; }
		public DbSet<StudentCourse> StudentsCourses { get;set; }
		//public DbSet<TeacherCourse> TeachersCourses { get;set;}
		//public DbSet<TeacherClass> TeachersClasses { get; set; }


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			//dbye geçilecek olan gerekli bilgileri burdaki method yerine daha temiz dursun diye configuration kısmında yazarız buraya da o yazdığımızı haber vermek için newleriz.
			//modelBuilder.ApplyConfiguration(new StudentConfiguration());
			//modelBuilder.ApplyConfiguration(new SchoolClassConfiguration());
			//modelBuilder.ApplyConfiguration(new CourseConfiguration());
			//modelBuilder.ApplyConfiguration(new StudentCourseConfiguration());
			//modelBuilder.ApplyConfiguration(new TeacherClassConfiguration());
			//modelBuilder.ApplyConfiguration(new TeacherCourseConfiguration());
			//modelBuilder.ApplyConfiguration(new TeacherConfiguration());
			//bu şekilde tek tek de yazabiliriz ama bunun daha kısa yolu aşağıdaki gibidir .

			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

			//modelBuilder.Entity<TeacherClass>().HasKey(tc => new { tc.TeacherId, tc.ClassId });
			//modelBuilder.Entity<StudentCourse>().HasKey(sc => new { sc.StudentId, sc.CourseId });
			//modelBuilder.Entity<TeacherCourse>().HasKey(tc => new { tc.TeacherId, tc.CourseId });
		}
	}
}
