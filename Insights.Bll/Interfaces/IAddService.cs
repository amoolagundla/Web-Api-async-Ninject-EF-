using Insights.Bll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insights.Bll.Interfaces
{
    public interface IAddService<T>
    {
        T add(T a,T b);
    }
}
