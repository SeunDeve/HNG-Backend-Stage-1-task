using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hngbackend.Model;
using Microsoft.AspNetCore.Mvc;



namespace Hngbackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HngTask1Controller : Controller
    {
        [HttpGet]
        public IActionResult GetUserDetails()
        {
            var res = new Response()
            {
                slackUsername = "Oluwaseun Oyewole",
                backend = true,
                age = 26,
                bio = "Tech Bro"
            };

            return Ok(res);
        }

    }
}

