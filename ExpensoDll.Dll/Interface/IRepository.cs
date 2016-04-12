using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insights.Dll.Interface
{
   public  interface IRepository<T> where T : class
    {
        T Add(T obj);
        T Get(int id);
       Task<IQueryable<T>> GetAll();
        T Update(T obj);
        T Delete(T obj);
    }
}
