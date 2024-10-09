﻿using App.Repositories.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repositories.Configurations
{
	public class StudentCourseConfiguration : IEntityTypeConfiguration<StudentCourse>
	{
		public void Configure(EntityTypeBuilder<StudentCourse> builder)
		{
			builder.HasKey(x=> new {x.StudentId,x.CourseId});

			builder.HasOne(x => x.Student).WithMany(x => x.StudentCourses).HasForeignKey(x => x.StudentId);
			builder.HasOne(x=>x.Course).WithMany(x=>x.StudentCourses).HasForeignKey(x=> x.CourseId);
		}
	}
}