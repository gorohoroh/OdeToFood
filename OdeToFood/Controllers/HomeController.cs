using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OdeToFood.Models;
using OdeToFood.Services;
using OdeToFood.ViewModels;

namespace OdeToFood.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        IRestaurantData _restaurantData;

        public HomeController(IRestaurantData restaurantData)
        {
            _restaurantData = restaurantData;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            var model = new HomeIndexViewModel();
            model.Restaurants = _restaurantData.GetAll();
            
            return View(model);
        }

        [AllowAnonymous]
        public IActionResult Details(int id)
        {
            var model = _restaurantData.Get(id);
            if (model == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(RestaurantEditModel model)
        {
            if (ModelState.IsValid)
            {
                var newRestaurant = new Restaurant
                {
                    Name = model.Name,
                    Cuisine = model.Cuisine
                };

                newRestaurant = _restaurantData.Add(newRestaurant);

                return RedirectToAction("Details", new {id = newRestaurant.Id});
            }

            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var restaurant = _restaurantData.Get(id);
            if (restaurant == null)
                return RedirectToAction("Index", "Home");
            return View(restaurant);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Restaurant model)
        {
            if (!ModelState.IsValid) return View(model);
            
            var restaurant = _restaurantData.Get(model.Id);
            restaurant.Name = model.Name;
            restaurant.Cuisine = model.Cuisine;
            _restaurantData.Update(restaurant);
            return RedirectToAction("Details", "Home", restaurant.Id);
        }

        public IActionResult Review() => throw new NotImplementedException();
    }
}