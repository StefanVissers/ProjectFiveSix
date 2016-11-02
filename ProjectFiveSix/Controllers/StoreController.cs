using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectFiveSix.Models;

namespace ProjectFiveSix.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            var categories = new List<Category>
            {
                new Category { Name = "Processor" },
                new Category { Name = "Graphics Card" },
                new Category { Name = "Motherboard" },
                new Category { Name = "Hard Drives" },
                new Category { Name = "Random Access Memory" },
                new Category { Name = "Sound Systems" },
                new Category { Name = "Monitor" }
            };
            return View(categories);
        }
        public ActionResult Browse(String category)
        {
            var categoryModel = new Category { Name = category };
            return View(categoryModel);
        }
    }
}