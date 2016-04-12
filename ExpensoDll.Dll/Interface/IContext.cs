using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insights.Dll.Interface
{
   public interface IContext<T> :IDisposable where T :class
    {
        DbContext DbContext { get; set; }
        IDbSet<T> DbSet { get; set; }
    }
}
