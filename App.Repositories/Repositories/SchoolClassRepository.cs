using App.Repositories.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repositories.Repositories
{
	public class SchoolClassRepository : GenericRepository<SchoolClass>, ISchoolClassRepository
	{
		private readonly AppDbContext _context;
		public SchoolClassRepository(AppDbContext context) : base(context)
		{
			_context = context;
		}

		public async Task<SchoolClass> GetSchoolClassWithStudentsAsync(int id)
		{
			return await _context.Set<SchoolClass>().Include(x => x.Students).FirstOrDefaultAsync(x => x.ClassId == id);
		}
	}
}
