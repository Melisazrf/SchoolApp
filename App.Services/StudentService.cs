using App.Repositories.Models;
using App.Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Services
{
	public class StudentService : GenericService<Student>, IStudentService
	{
		private readonly IGenericRepository<Student> _studentRepository;
		private readonly IGenericRepository<SchoolClass> _schoolClassRepository;
		private readonly IGenericRepository<Course> _courseRepository;
		
		public StudentService(IGenericRepository<Student> studentRepository, IGenericRepository<SchoolClass> schoolClassRepository, IGenericRepository<Course> courseRepository) : base(studentRepository)
		{
			_studentRepository = studentRepository;
			_schoolClassRepository = schoolClassRepository;
			_courseRepository = courseRepository;
		}

		public IEnumerable<Student> GetAll()
		{
			return _studentRepository.GetAll();
		}

		public async Task<Student> GetByIdAsync(int id)
		{
			return await _studentRepository.GetByIdAsync(id);
		}

		public async Task AddAsync(Student student)
		{
			await _studentRepository.AddAsync(student);
		}

		public void Update(Student student)
		{
			_studentRepository.Update(student);
		}

		public void Delete(Student student)
		{
			_studentRepository.Delete(student);
		}





		//public async Task AssignStudentToClass(int studentId, int schoolClassId)
		//{
		//	var student = await _studentRepository.GetByIdAsync(studentId);
		//	var schoolClass = await _schoolClassRepository.GetByIdAsync(schoolClassId);

		//	if (student == null || schoolClass == null)
		//		throw new Exception("Öğrenci veya sınıf bulunamadı!");

		//	schoolClass.Students.Add(student);
		//}

		//public async Task EnrollStudentInCourse(int studentId, int courseId)
		//{
		//	var student = await _studentRepository.GetByIdAsync(studentId);
		//	var course = await _courseRepository.GetByIdAsync(courseId);

		//	if (student == null || course == null)
		//		throw new Exception("Öğrenci veya ders bulunamadı!");

		//	var studentCourse = new StudentCourse { StudentId = studentId, CourseId = courseId };
	}
	
}
