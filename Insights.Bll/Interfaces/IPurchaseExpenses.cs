using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insights.Bll.Interfaces
{
    public interface IPurchaseExpenses<TEntity> where TEntity : class
    {
        Task<IQueryable<TEntity>> GetAll();
    }
}
