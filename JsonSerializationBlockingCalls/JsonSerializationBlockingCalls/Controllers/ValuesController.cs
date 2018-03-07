using System.Collections.Generic;
using JsonSerializationBlockingCalls.Models;
using Microsoft.AspNetCore.Mvc;

namespace JsonSerializationBlockingCalls.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        [HttpGet]
        [Route("{size}")]
        public TestResponse Get(int size)
        {
            return TestResponse.TestValues[size];
        }
    }
}
