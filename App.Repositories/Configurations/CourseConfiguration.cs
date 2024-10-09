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
	public class CourseConfiguration : IEntityTypeConfiguration<Course>
	{
		public void Configure(EntityTypeBuilder<Course> builder)
		{
			builder.HasKey(x=>x.CourseId);
			builder.Property(x=>x.Name).IsRequired();
			
		}
	}
}
