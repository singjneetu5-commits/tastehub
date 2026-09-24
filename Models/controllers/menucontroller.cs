using System.Collections.Generic;
using System.Web.Mvc;
using FoodHub.Models;

namespace FoodHub.Controllers
{
    public class MenuController : Controller
    {
        public ActionResult Index()
        {
            List<Food> foods = new List<Food>();

            foods.Add(new Food
            {
                Id = 1,
                Name = "Pizza",
                Category = "Fast Food",
                Price = 250,
                Description = "Delicious cheese pizza."
            });

            foods.Add(new Food
            {
                Id = 2,
                Name = "Burger",
                Category = "Fast Food",
                Price = 150,
                Description = "Fresh and tasty burger."
            });

            foods.Add(new Food
            {
                Id = 3,
                Name = "Biryani",
                Category = "Indian",
                Price = 220,
                Description = "Spicy and delicious biryani."
            });

            foods.Add(new Food
            {
                Id = 4,
                Name = "Pasta",
                Category = "Italian",
                Price = 180,
                Description = "Creamy white sauce pasta."
            });

            return View(foods);
        }

        public ActionResult Details(int id)
        {
            Food food = null;

            if (id == 1)
            {
                food = new Food
                {
                    Id = 1,
                    Name = "Pizza",
                    Category = "Fast Food",
                    Price = 250,
                    Description = "Delicious cheese pizza with fresh toppings."
                };
            }
            else if (id == 2)
            {
                food = new Food
                {
                    Id = 2,
                    Name = "Burger",
                    Category = "Fast Food",
                    Price = 150,
                    Description = "Fresh burger with cheese and vegetables."
                };
            }
            else if (id == 3)
            {
                food = new Food
                {
                    Id = 3,
                    Name = "Biryani",
                    Category = "Indian",
                    Price = 220,
                    Description = "Spicy Indian biryani with delicious flavors."
                };
            }
            else if (id == 4)
            {
                food = new Food
                {
                    Id = 4,
                    Name = "Pasta",
                    Category = "Italian",
                    Price = 180,
                    Description = "Creamy pasta with delicious white sauce."
                };
            }

            if (food == null)
            {
                return HttpNotFound();
            }

            return View(food);
        }
    }
}
