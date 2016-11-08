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
            {

            };
            return View();
        }
        public ActionResult Browse(String category)
        {
            return View();
        }
    }
}