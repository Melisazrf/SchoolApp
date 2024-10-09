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
	public class StudentSeed : IEntityTypeConfiguration<Student>
	{
		public void Configure(EntityTypeBuilder<Student> builder)
		{
			builder.HasData(new Student
			{
				StudentId = 1,
				Name = "Melisa Zarif",
				SchoolClassId = 1,

			},
			new Student
			{
				StudentId = 2,
				Name = "Ayşe Özkap",
				SchoolClassId = 2,
			});

		}
	}
}
