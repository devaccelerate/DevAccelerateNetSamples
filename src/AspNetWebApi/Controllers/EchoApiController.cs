using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Ejyle.DevAccelerate.Samples.AspNetWebApi.Controllers
{
    public class EchoApiController : ApiController
    {
        public string Get(string message)
        {
            var headers = Request.Headers;
            string result = $"Message: {message} | Headers: ";

            if(headers != null)
            {
                foreach(var header in headers)
                {
                    result = result + $"{header.Key} = {header.Value.SingleOrDefault()}";
                }
            }

            return result;
        }
    }
}
