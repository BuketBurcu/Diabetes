using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiabetesControl.Controllers
{
    [Route("CHCalculate")]
    public class CHCalculateController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("CHCalculate")]
        public IActionResult CHCalculate()
        {
            return View();
        }
    }
}
