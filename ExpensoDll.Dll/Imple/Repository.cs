using ExpensoDll.Dll.Model;
using Insights.Dll.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insights.Dll.Imple
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly IContext<T> _context;
        public Repository(IContext<T> context)
        {
            _context = context;
        }

        public object DataContext { get; private set; }

        public T Add(T obj)
        {
            throw new NotImplementedException();
        }

        public T Delete(T obj)
        {
            throw new NotImplementedException();
        }

        public T Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IQueryable<T>> GetAll()
        {

            using (var ctx = new ExpensoEntities())
            {
                return await Task.Run(()=>ctx.Database.SqlQuery<T>("exec [dbo].[sp_GetPurchaseExpenses] ").ToList<T>().AsQueryable<T>());
            }
        }

        public T Update(T obj)
        {
            throw new NotImplementedException();
        }
    }
}
