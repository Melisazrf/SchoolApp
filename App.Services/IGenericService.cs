using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace App.Services
{
	public interface IGenericService<T> where T : class
	{
		Task<T> GetByIdAsync(int id);
		IQueryable<T> Where(Expression<Func<T, bool>> predicate);
		IQueryable<T> GetAll();	

		ValueTask AddAsync(T entity);
		void Update(T entity);
		void Delete(T entity); 
	}
}
