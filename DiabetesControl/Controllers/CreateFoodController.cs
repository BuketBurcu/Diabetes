using DiabetesControl.Data.Enums;
using DiabetesControl.Data.Models;
using DiabetesControl.DataAccess;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiabetesControl.Controllers
{
    [Route("CreateFood")]
    public class CreateFoodController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("CreateFood")]
        public IActionResult CreateFood([FromBody] Food food)
        {
            return View();
        }

        [HttpPost, ActionName("Create")]
        public IActionResult Create([FromBody] Food food)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                uow.GetRepository<Food>().Add(food);
                uow.SaveChanges();
            }
            return RedirectToAction("CreateFood");
        }
    }
}