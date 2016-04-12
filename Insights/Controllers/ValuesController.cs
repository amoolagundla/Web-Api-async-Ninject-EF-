using Insights.Bll.Interfaces;
using Insights.Bll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Insights.Controllers
{
    [Authorize]
    public class ValuesController : ApiController
    {
       // private Bll.Interfaces.IAddService<int> _iAddService;
        private Bll.Interfaces.IPurchaseExpenses<PurchaseExpense> _iPurchaseExpense;

        // GET api/values
        public ValuesController( Bll.Interfaces.IPurchaseExpenses<PurchaseExpense> iPurchaseExpense)
        {
             _iPurchaseExpense = iPurchaseExpense;
        }
        public async Task<IHttpActionResult> Get()
        {
            return Ok(await _iPurchaseExpense.GetAll());
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
