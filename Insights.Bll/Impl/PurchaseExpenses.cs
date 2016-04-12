using Insights.Dll.Interface;
using Insights.Bll.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Insights.Dll.Imple;
using Insights.Bll.Impl;
using Insights.Bll.Models;
using Insights.Dll.Model;

namespace Insights.Bll.Impl
{
    public class PurchaseExpenses<TEntity> : IPurchaseExpenses<TEntity> where TEntity : PurchaseExpense
    {
        private readonly IRepository<PurchaseExpenseDao> _irepository;
        private readonly AutoMapper.MapperConfiguration _autoMapper = new AutoMapper.MapperConfiguration(x => x.CreateMap<PurchaseExpenseDao, TEntity>().ReverseMap());
       
        public PurchaseExpenses(IRepository<PurchaseExpenseDao> irepository)
        {
            _irepository = irepository;
        }

        public async Task<IQueryable<TEntity>> GetAll()
        {
            return _autoMapper.CreateMapper().Map<List<TEntity>>(await _irepository.GetAll()).ToList<TEntity>().AsQueryable();
        }
    }
}
