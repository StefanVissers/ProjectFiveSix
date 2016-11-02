using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectFiveSix.Models;

namespace ProjectFiveSix.Controllers
{
    public class DetailsController : Controller
    {
        // GET: Details
        public ActionResult Index(String category)
        {
            var categoryModel = new Category { Name = category };
            return View(categoryModel);
        }
    }
}