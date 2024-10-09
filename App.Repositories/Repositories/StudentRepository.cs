using App.Repositories.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace App.Repositories.Repositories
{
	public class StudentRepository : GenericRepository<Student>, IStudentRepository
	{
		private readonly AppDbContext _context;
		public StudentRepository(AppDbContext context) : base(context)
		{
			_context = context;
		}

		public IEnumerable<Student> GetAll()
		{
			return _context.Students.ToList(); // Veritabanından tüm öğrencileri çek
		}

		public async Task<Student> GetByIdAsync(int id)
		{
			return await _context.Students.FindAsync(id); // ID'ye göre öğrenci getir
		}

		public async Task AddAsync(Student student)
		{
			await _context.Students.AddAsync(student); // Yeni öğrenci ekle
			await _context.SaveChangesAsync(); // Değişiklikleri kaydet
		}

		public void Update(Student student)
		{
			_context.Students.Update(student); // Öğrenciyi güncelle
			_context.SaveChanges(); // Değişiklikleri kaydet
		}

		public void Delete(Student student)
		{
			_context.Students.Remove(student); // Öğrenciyi sil
			_context.SaveChanges(); // Değişiklikleri kaydet
		}



		public async Task<IEnumerable<Student>> GetStudentsByClassIdAsync(int classId)
		{
			return await _context.Students
								 .Where(s => s.SchoolClassId == classId) // classId ile eşleşen öğrenciler
								 .ToListAsync();
		}

	}




	//public async Task AssignStudentToClassAsync(Student student, SchoolClass schoolClass)
	//{
	//	schoolClass.Students.Add(student);
	//	_context.Classes.Update(schoolClass);
	//	await _context.SaveChangesAsync();
	//}

	//public async Task EnrollStudentToCourseAsync(Student student, StudentCourse studentCourse)
	//{
	//	studentCourse.StudentId = student.StudentId;
	//	studentCourse.StudentId.CompareTo(student.StudentId);
	//	_context.StudentsCourses.Update(studentCourse);
	//	await _context.SaveChangesAsync();
	//}

	//public async Task<Student> GetStudentsWithClassAsync(int id)
	//{
	//	return await _context.Set<Student>().Include(x => x.SchoolClass).FirstOrDefaultAsync(x => x.SchoolClassId == id);
	//}
}
