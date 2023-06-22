using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace apitest.Controllers
{
    [ApiController]
    public class FruuuitController : ControllerBase
    {
        private readonly List<string> _fruit = new List<string>
            {
                "Pear",
                "Lemon",
                "Peach"
            };


        //The [HttpGet("test")] attribute applied to the Index method indicates the method should use
        //the route template "test" (https://localhost:5001/test) and should respond to HTTP GET requests.

        [HttpGet("test")]
        public IEnumerable<string> Index()
        {
            return _fruit;
        }

        [HttpGet("fruuuit/{id}")]
        public ActionResult<string> View(int id)
        {
            if (id >= 0 && id < _fruit.Count)
            {
                return _fruit[id];
            }

            return NotFound();
        }
    }
}