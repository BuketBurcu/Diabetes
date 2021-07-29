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
    public class CreateFoodController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateFood(Food food)
        {
            return View();
        }

        [HttpPost, ActionName("Create")]
        public IActionResult Create(Food food)
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