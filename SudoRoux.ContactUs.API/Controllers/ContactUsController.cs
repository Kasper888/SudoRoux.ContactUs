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
    public class ContactUsController : ControllerBase
    {

        private readonly IWebHostEnvironment _env;

        public ContactUsController(IWebHostEnvironment env)
        {
            _env = env;
        }

        [HttpPost]
        public ContentResult Post([FromForm] Domain.ContactUs contactUs)
        {
            string jsonString = JsonSerializer.Serialize(contactUs);
            var path = _env.ContentRootPath + "/contactUs.json";
            System.IO.File.WriteAllText(path, jsonString);
            return Content("Contact Us Request Created Successfully");
        }
    }
}
