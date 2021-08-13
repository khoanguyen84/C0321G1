using CGShop.WebApp.Helper;
using CGShop.WebApp.Models;
using CGShop.WebApp.Models.Category;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CGShop.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/Home/Get")]
        public IActionResult Get()
        {
            WebRequest request = WebRequest.Create(@$"{Common.ApiUrl}Category");
            request.Method = "GET";
            WebResponse response = request.GetResponse();
            string responseFromServer = string.Empty;
            using (Stream dataStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(dataStream);
                responseFromServer = reader.ReadToEnd();
            }
            return Ok(JsonConvert.DeserializeObject<List<Category>>(responseFromServer));
        }


        [HttpPost]
        [Route("/Home/Create")]
        public IActionResult Create([FromBody]CreateCategory model)
        {
            WebRequest request = WebRequest.Create(@$"{Common.ApiUrl}Category");
            request.Method = "POST";
            request.ContentType = "application/json";
            
            using (var streamWrite = new StreamWriter(request.GetRequestStream()))
            {
                var data = JsonConvert.SerializeObject(model);
                streamWrite.Write(data);
            }
            WebResponse response = request.GetResponse();
            string responseFromServer = string.Empty;
            using (Stream dataStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(dataStream);
                responseFromServer = reader.ReadToEnd();
            }

            return Ok(JsonConvert.DeserializeObject<CreateCategoryResult>(responseFromServer));
        }
    }
}
