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
	public class SchoolClassSeed : IEntityTypeConfiguration<SchoolClass>
	{
		public void Configure(EntityTypeBuilder<SchoolClass> builder)
		{
			builder.HasData(new SchoolClass
			{
				ClassId = 1,
				Name = "A"
			},
			new SchoolClass
			{
				ClassId= 2,
				Name = "B"
			},
			new SchoolClass
			{
				ClassId =3,
				Name = "C"
			}
			);
		}
	}
}
