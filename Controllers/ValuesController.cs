using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.SessionState;

namespace Server462.Controllers
{
    public class ValuesController : ApiController
    {
        public HttpResponseMessage Get(int id)
        {

            var res = new HttpResponseMessage();
            res.StatusCode = HttpStatusCode.OK;
            res.Content = new StringContent("content!");

            return res;
        }
    }
}
