using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustBlog.Core.Abstract
{
	interface IRepository<T>
	{
		void Initialize();
		T Get(int id);
		IEnumerable<T> GetAll();
		void Update();
		void Insert(T entity);
		void Delete();

	}
}
