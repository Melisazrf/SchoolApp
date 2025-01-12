﻿using App.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repositories.Repositories
{
	public interface ICourseRepository : IGenericRepository<Course>
	{
		Task<IEnumerable<Student>> GetStudentsByCourseIdAsync(int courseId);
	}
}
