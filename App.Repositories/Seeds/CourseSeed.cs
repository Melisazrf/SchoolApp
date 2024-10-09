using App.Repositories.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repositories.Seeds
{
	public class CourseSeed : IEntityTypeConfiguration<Course>
	{
		public void Configure(EntityTypeBuilder<Course> builder)
		{
			builder.HasData(new Course
			{
				CourseId = 1,
				Name = "Türkçe"
			},
			new Course
			{
				CourseId = 2,
				Name = "Matematik"
			},
			new Course
			{
				CourseId = 3,
				Name = "İngilizce"
			});
		}
	}
}
