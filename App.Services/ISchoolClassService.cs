using App.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Services
{
	public interface ISchoolClassService :IGenericService<SchoolClass>
	{

		Task<IEnumerable<Student>> GetStudentsByClassIdAsync(int classId);
		//Task<SchoolClass> GetSchoolClassWithStudentsAsync(int id);
	}
}
