using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zero_Hunger.DB;

namespace Zero_Hunger.Controllers
{
    public class RestaurantController : Controller
    {
        ZeroContext obj = new ZeroContext();
        // GET: Restaurant
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult addRestaurant()
        {
            return View();
        }

        [HttpPost]
        public ActionResult addRestaurant(Restaurant model) 
        {
            Restaurant restaurant = new Restaurant();
            restaurant.RestaurantID = model.RestaurantID;
            restaurant.RestaurantName = model.RestaurantName;
            restaurant.RestaurantDescription = model.RestaurantDescription;
            restaurant.RestaurantCont = model.RestaurantCont;
            restaurant.RestaurantEmail = model.RestaurantEmail;
            restaurant.RestaurantOwner = model.RestaurantOwner;
            restaurant.RestaurantAddress = model.RestaurantAddress;

            obj.Restaurants.Add(restaurant);
            obj.SaveChanges();

            ModelState.Clear();

            return View("addRestaurant");
        }

        public ActionResult ShowRestaurant()
        {
            var show = obj.Restaurants.ToList();
            return View(show);
        }

        public ActionResult Delete(int id) 
        {
            Restaurant restaurant = new Restaurant();
            var delete = obj.Restaurants.Where(x=>x.RestaurantID == id).First();
            obj.Restaurants.Remove(delete);
            obj.SaveChanges();

            return RedirectToAction("ShowRestaurant");
        }

    }
}