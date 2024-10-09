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
	public class SchoolClassConfiguration : IEntityTypeConfiguration<SchoolClass>
	{
		public void Configure(EntityTypeBuilder<SchoolClass> builder)
		{
			builder.HasKey(x=>x.ClassId);
			builder.Property(x=>x.Name).IsRequired();
			builder.HasMany(x => x.Students).WithOne(x => x.SchoolClass).HasForeignKey(x => x.SchoolClassId);
			
			//studenttaki schoolclassıd foreign keydir biz bunu ama schoolclassta yazdık 
			//foreign key olan classta config yapmıyoruz
		}
	}
}
