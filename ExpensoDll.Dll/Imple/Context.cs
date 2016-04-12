using Insights.Dll.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Configuration;

namespace Insights.Dll.Imple
{
    public class Context<T> : IContext<T> where T : class
    {
        public Context()
        {
            DbContext = new DbContext(ConfigurationManager.ConnectionStrings["ExpensoEntities"].ConnectionString);
            DbSet = DbContext.Set<T>();
        }

        public DbContext DbContext
        {
            get;

             set;
        }

        public IDbSet<T> DbSet
        {
            get;

            set;
        }

        public void Dispose()
        {
            DbContext.Dispose();
        }
     
    }
}
