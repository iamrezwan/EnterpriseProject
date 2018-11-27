using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Example.Controllers
{
    public class MyClass
    {       
        public int ID { get; set; }
        public string MyProperty { get; set; }
    }
    [Route("[controller]")]
    [ApiController]
    public class ValuesController : Controller
    {
        private readonly ILogger _logger;
        public ValuesController(ILoggerFactory loggerFactory)
        {            
            _logger = loggerFactory.CreateLogger<ValuesController>();
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<JsonResult> Hello(int id = 0)
        {
            var x = new MyClass { ID = id, MyProperty = "x" };            
            return Json(x);

        }
    }
}
