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
            var data = ApiHelper.HttpGet<List<Category>>(@$"{Common.ApiUrl}Category");
            return Ok(data);
        }

        [HttpGet]
        [Route("/Home/Get/{id}")]
        public IActionResult Get(int id)
        {
            var data = ApiHelper.HttpGet<Category>(@$"{Common.ApiUrl}Category/{id}");
            return Ok(data);
        }

        [HttpPost]
        [Route("/Home/Create")]
        public IActionResult Create([FromBody] CreateCategory model)
        {
            return Ok(ApiHelper.HttpPost<CreateCategoryResult>(@$"{Common.ApiUrl}Category", "POST", model));
        }

        [HttpPut]
        [Route("/Home/ChangeStatus")]
        public IActionResult ChangeStatus([FromBody] ChangeStatusCategory model)
        {
            return Ok(ApiHelper.HttpPost<ChangeStatusCategoryResult>(@$"{Common.ApiUrl}Category/ChangeStatus", "PUT", model));
        }
        [HttpPut]
        [Route("/Home/Update")]
        public IActionResult Update([FromBody] UpdateCategory model)
        {
            return Ok(ApiHelper.HttpPost<UpdateCategoryResult>(@$"{Common.ApiUrl}Category", "PUT", model));
        }

        [HttpDelete]
        [Route("/Home/Remove/{id}")]
        public IActionResult Remove(int id)
        {
            return Ok(ApiHelper.HttpGet<DeleteCategoryResult>(@$"{Common.ApiUrl}Category/{id}", "DELETE"));
        }
    }
}
