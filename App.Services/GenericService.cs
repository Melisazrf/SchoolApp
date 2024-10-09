using App.Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace App.Services
{
	public class GenericService<T> : IGenericService<T> where T : class
	{
		private readonly IGenericRepository<T> _repository;

		public GenericService(IGenericRepository<T> repository)
		{
			_repository = repository;
		}

		public async ValueTask AddAsync(T entity)
		{
			await _repository.AddAsync(entity);
		}

		public IQueryable<T> GetAll()
		{
			return _repository.GetAll();
		}

		public async Task<T> GetByIdAsync(int id)
		{
			return await _repository.GetByIdAsync(id);
		}

		public void Delete(T entity)
		{
			_repository.Delete(entity);
		}

		public void Update(T entity)
		{
			_repository.Update(entity);
		}

		public IQueryable<T> Where(Expression<Func<T, bool>> predicate)
		{
			return _repository.Where(predicate);
		}
	}
}
