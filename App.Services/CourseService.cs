using App.Repositories.Models;
using App.Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Services
{
	public class CourseService : GenericService<Course>, ICourseService
	{
		private readonly ICourseRepository _courseRepository;
		public CourseService(IGenericRepository<Course> repository, ICourseRepository courseRepository) : base(repository)
		{
			_courseRepository = courseRepository;
		}

		public async Task<IEnumerable<Student>> GetStudentsByCourseIdAsync(int courseId)
		{
			return await _courseRepository.GetStudentsByCourseIdAsync(courseId);
		}
	}
}
