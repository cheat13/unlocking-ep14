using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using demoapi.Models;

namespace demoapi.Controllers
{
    [Route("[controller]/[action]")]
    public class MyApiController : Controller
    {
        [HttpGet]
        public string Greeting()
        {
            return "Hello world";
        }

        [HttpGet("{name}")]
        public string Greeting(string name)
        {
            return "Hello " + name;
        }
    }
}
