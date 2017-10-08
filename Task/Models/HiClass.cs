using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Task.Models
{
    public class HiClass:IGreeter
    {
        public string SayHello()
        {
            return "«Hi there!»";
        }
    }
}