using App.Repositories.Models;
using App.Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Services
{
	public class SchoolClassService : GenericService<SchoolClass>, ISchoolClassService
	{
		private readonly ISchoolClassRepository _schoolClassRepository;
		private readonly IStudentRepository _studentRepository;

		public SchoolClassService(IGenericRepository<SchoolClass> repository, ISchoolClassRepository schoolClassRepository, IStudentRepository studentRepository) : base(repository)
		{
			_schoolClassRepository = schoolClassRepository;
			_studentRepository = studentRepository;
		}

		public async Task<IEnumerable<Student>> GetStudentsByClassIdAsync(int classId)
		{
			return await _studentRepository.GetStudentsByClassIdAsync(classId);
		}




		//public async Task<SchoolClass> GetSchoolClassWithStudentsAsync(int id)
		//{
		//	var schoolClass = await _schoolClassRepository.GetSchoolClassWithStudentsAsync(id);

		//	if (schoolClass == null)
		//		throw new Exception("Sınıf bulunamadı.");

		//	return schoolClass;

		//}
	}
}
