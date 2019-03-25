using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TMS.Api.Controllers
{/// <summary>
 /// Not yet implemented
 /// </summary>
 /// 
    [System.Web.Http.Route("api/Invoice")]
    public class InvoiceController : ApiController
    {
        [HttpGet]
        // GET: api/Invoice
        public IEnumerable<string> Get() => new string[] { "value1", "value2" };

        // GET: api/Invoice/5
        // POST: api/Invoice

        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

    }
}
