using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Task.Models
{
    public class HelloClass:IGreeter
    {
        public string SayHello()
        {
            return "«Hi everyone!»";
        }
    }
}