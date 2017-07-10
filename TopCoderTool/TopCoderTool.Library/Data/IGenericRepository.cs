using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopCoderTool.Library.Data
{
    public interface IGenericRepository<T> where T:Entity
    {
        void Add(T item);
        void Delete(T item);
        IEnumerable<T> GetAll();
    }
}
