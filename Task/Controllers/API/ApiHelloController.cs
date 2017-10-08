using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Task.Models;

namespace Task.Controllers.API
{
    public class ApiHelloController : ApiController
    {
        public string Get()
        {
            return new HelloClass().SayHello();
        }
    }
}
