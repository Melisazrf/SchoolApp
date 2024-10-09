using App.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Services
{
	public interface ICourseService :IGenericService<Course>
	{
		Task<IEnumerable<Student>> GetStudentsByCourseIdAsync(int courseId);
	}
}
