using App.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repositories.Repositories
{
	public interface ISchoolClassRepository :IGenericRepository<SchoolClass>
	{
		Task<SchoolClass> GetSchoolClassWithStudentsAsync(int id);
	}
}
