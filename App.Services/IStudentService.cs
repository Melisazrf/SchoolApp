using App.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Services
{
	public interface IStudentService : IGenericService<Student>
	{
		IEnumerable<Student> GetAll();
		Task<Student> GetByIdAsync(int id);
		Task AddAsync(Student student);
		void Update(Student student);
		void Delete(Student student);
		//Task AssignStudentToClass(int studentId, int schoolClassId);
		//Task EnrollStudentInCourse(int studentId, int courseId);
	}
}
