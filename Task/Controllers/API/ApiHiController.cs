using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Task.Models;

namespace Task.Controllers.API
{
    public class ApiHiController : ApiController
    {
        public string Get()
        {
            return new HiClass().SayHello();
        }

    }
}
