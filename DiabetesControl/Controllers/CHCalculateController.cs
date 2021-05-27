using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiabetesControl.Controllers
{
    public class CHCalculateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CHCalculate()
        {
            return View();
        }
    }
}
