using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OdeToFood.Data;

namespace OdeToFood.ViewComponents
{
    public class RestaurantCountViewComponent:ViewComponent
    {
        public IRestaurantData RestaurantData { get; }
        public RestaurantCountViewComponent(IRestaurantData restaurantData)
        {
            RestaurantData = restaurantData;
        }

        public IViewComponentResult Invoke()
        {
            var count = RestaurantData.GetCountOfRestaurants();
            return View(count);
        }
       
    }
}
