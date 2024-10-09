using App.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CourseController : ControllerBase
	{
		private readonly ICourseService _courseService;

		public CourseController(ICourseService courseService)
		{
			_courseService = courseService;
		}

		[HttpGet("[action]")]
		public async Task<IActionResult> GetStudentsByCourseId(int courseId)
		{
			var students = await _courseService.GetStudentsByCourseIdAsync(courseId);

			if (students == null || !students.Any())
			{
				return NotFound("Bu kursa kayıtlı öğrenci bulunamadı.");
			}

			return Ok(students);
		}
	}
}
