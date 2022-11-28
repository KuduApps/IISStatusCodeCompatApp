using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;

namespace Server462.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values/5
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
            else if (id == 429)
            {
                res.StatusCode = (HttpStatusCode)429;
                res.Headers.Add("x-ms-cache-throttling", "true");
                //res.Headers.RetryAfter = new RetryConditionHeaderValue(TimeSpan.FromSeconds(5));
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
