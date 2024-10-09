using App.Repositories.Models;
using App.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SchoolClassController : ControllerBase
	{
		private readonly ISchoolClassService _schoolClassService;

		public SchoolClassController(ISchoolClassService schoolClassService)
		{
			_schoolClassService = schoolClassService;
		}

		[HttpGet("[action]")]
		public async Task<IActionResult> GetStudentsByClassId(int classId)
		{
			var students = await _schoolClassService.GetStudentsByClassIdAsync(classId);

			if (students == null || !students.Any())
			{
				return NotFound("Bu sınıfa ait öğrenci bulunamadı.");
			}

			return Ok(students); // 200 OK ile öğrenci listesini döndür
		}

		




		//[HttpGet("{id}/students")]
		//public async Task<IActionResult> GetSchoolClassWithStudents(int id)
		//{
		//	var schoolClass = await _schoolClassService.GetSchoolClassWithStudentsAsync(id);
		//	return Ok(schoolClass);
		//}
	}
}
