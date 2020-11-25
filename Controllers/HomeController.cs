using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanCWebMaster.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinanCWebMaster.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {

            ViewBag.Title = "Home";
            return View();

        }

    }

}
