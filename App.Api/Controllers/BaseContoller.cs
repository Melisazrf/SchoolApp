using App.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BaseContoller<T> : ControllerBase where T : class
	{
		private readonly IGenericService<T> _service;

		public BaseContoller(IGenericService<T> service)
		{
			_service = service;
		}

		[HttpGet]
		public IActionResult GetAll()
		{
			var entities = _service.GetAll().ToList();
			return (IActionResult)entities;
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetById(int id)
		{
			var entity = await _service.GetByIdAsync(id);
			if (entity == null) return NotFound();
			return Ok(entity);
		}

		[HttpPost]
		public async Task<IActionResult> Add([FromBody] T entity)
		{
			await _service.AddAsync(entity);
			return CreatedAtAction(nameof(GetById), new { id = entity.GetHashCode() }, entity);
		}

		[HttpPut("{id}")]
		public IActionResult Update(int id, [FromBody] T entity)
		{
			_service.Update(entity);
			return NoContent();
		}

		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			var entity = _service.GetByIdAsync(id).Result;
			if (entity == null) return NotFound();
			_service.Delete(entity);
			return NoContent();
		}
	}
}
