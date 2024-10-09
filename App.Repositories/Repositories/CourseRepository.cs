using App.Repositories.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repositories.Repositories
{
	public class CourseRepository : GenericRepository<Course>, ICourseRepository
	{
		private readonly AppDbContext _context;
		public CourseRepository(AppDbContext context) : base(context)
		{
			_context = context;
		}

		public async Task<IEnumerable<Student>> GetStudentsByCourseIdAsync(int courseId)
		{
			return await _context.Students
								 .Where(s => s.StudentCourses.Any(c => c.CourseId == courseId)) 
								 .ToListAsync();
		}
	}
}