using Insights.Bll.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Insights.Bll.Models;

namespace Insights.Bll.Impl
{
    public class AddService<T> : IAddService<T>
    {
        public T add(T a, T b)
        {
            return (dynamic)a + (dynamic)b;
        }
    }
}
