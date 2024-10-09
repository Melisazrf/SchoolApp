using App.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repositories.Repositories
{
	public interface IStudentRepository :IGenericRepository<Student>
	{
		IEnumerable<Student> GetAll();
		Task<Student> GetByIdAsync(int id);
		Task AddAsync(Student student);
		void Update(Student student);
		void Delete(Student student);



		Task<IEnumerable<Student>> GetStudentsByClassIdAsync(int classId);



		//Task<Student> GetStudentsWithClassAsync(int id);
		//Task AssignStudentToClassAsync(Student student, SchoolClass schoolClass);
		//Task EnrollStudentToCourseAsync(Student student, StudentCourse studentCourse);
	}
}
