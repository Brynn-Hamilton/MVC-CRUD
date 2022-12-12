using Microsoft.AspNetCore.Mvc;
using Potluck.Models;
using System.Text.RegularExpressions;

namespace Potluck.Controllers
{
    public class DishController : Controller
    {
        public IActionResult Index()
        {
            List<Dish> dishes = DAL.GetAllDishes();
            return View(dishes);
        }
        public IActionResult BringDish()
        {
            return View();
        }

        public IActionResult RegisteredDish(Dish dish)
        {
            bool isvalid = true;

            Regex phone = new Regex("^\\+?\\d{1,4}?[-.\\s]?\\(?\\d{1,3}?\\)?[-.\\s]?\\d{1,4}[-.\\s]?\\d{1,4}[-.\\s]?\\d{1,9}$");
            if (dish.PhoneNumber == null || !phone.IsMatch(dish.PhoneNumber))
            {
                TempData["PhoneError"] = "You have entered an invalid phone number. Please try again.";
                isvalid = false;
            }
            if (dish.DishName == null || dish.DishName.Length < 2)
            {
                TempData["DishNameError"] = "You have entered an invalid value for the dish. Please try again.";
                isvalid = false;
            }
            if (isvalid == true)
            {
                DAL.InsertDish(dish);
                return View(dish);
            }
            else
            {
                return Redirect("/dish/bringdish");
            }
        }

        [HttpGet("/dish/detail/{id}")]
        public IActionResult Detail(int id)
        {
            Dish dish = DAL.GetOneDish(id);
            return View(dish);
        }

        public IActionResult Delete(int id)
        {
            DAL.DeleteDish(id);
            return Redirect("/dish");
        }

        public IActionResult EditForm(int id)
        {
            Dish dish = DAL.GetOneDish(id);
            return View(dish);
        }

        public IActionResult SaveChanges(Dish dish)
        {
            DAL.UpdateDish(dish);
            return Redirect("/dish");
        }
    }
}

