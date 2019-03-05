using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OdeToFood2.Models;

namespace OdeToFood2.Controllers
{
    public class HomeController: Controller
    {
        public HomeController(IRestaurantData restaurantData)
        {
            _restaurantData = restaurantData;
        }



        public IActionResult Index()
        {
            var model = _restaurantData.GetAll();

            return View(model);
        }
    }
}
