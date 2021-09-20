using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace SudoRoux.ContactUs.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {

        private readonly IWebHostEnvironment _env;

        public HomeController(IWebHostEnvironment env)
        {
            _env = env;
        }

        [HttpPost]
        public void Post(Domain.ContactUs contactUs)
        {
            string jsonString = JsonSerializer.Serialize(contactUs);
            var path = Path.Combine(_env.ContentRootPath, "contactUs.json");
            System.IO.File.WriteAllText(path, jsonString);
        }
    }
}
