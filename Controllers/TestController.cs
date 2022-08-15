using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.SessionState;

namespace Server462.Controllers
{
    public class TestController : ApiController
    {
        // GET api/test/5
        public HttpResponseMessage Get(int id)
        {
            var res = new HttpResponseMessage();


            if (id == 204)
            {
                res.StatusCode = HttpStatusCode.NoContent;
            }
            else if (id == 205)
            {
                res.StatusCode = HttpStatusCode.ResetContent;
            }
            else
            {
                res.StatusCode = HttpStatusCode.OK;
            }

            res.Content = new StringContent("content!");

            return res;
        }
    }
}
