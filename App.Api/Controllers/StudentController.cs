using App.Repositories.Models;
using App.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class StudentController : ControllerBase
	{
		private readonly IStudentService _studentService;

		public StudentController(IStudentService studentService)
		{
			_studentService = studentService;
		}

		[HttpGet]
		public IActionResult GetAll()
		{
			var entities = _studentService.GetAll().ToList();
			return Ok(entities);
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetById(int id)
		{
			var entity = await _studentService.GetByIdAsync(id);
			if (entity == null) return NotFound();
			return Ok(entity);
		}

		[HttpPost]
		public async Task<IActionResult> Add(Student student)
		{
			await _studentService.AddAsync(student);
			return CreatedAtAction(nameof(GetById), new { id = student.GetHashCode() }, student);
		}

		[HttpPut("{id}")]
		public IActionResult Update(int id, Student student)
		{
			_studentService.Update(student);
			return NoContent();
		}

		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			var entity = _studentService.GetByIdAsync(id).Result;
			if (entity == null) return NotFound();
			_studentService.Delete(entity);
			return NoContent();
		}
	}
}
