using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanCWebMaster.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FinanCWebMaster.Controllers
{
    public class RoleController : Controller
    {

        private readonly Context _context;

        public RoleController(Context context)
        {

            _context = context;

        }

        [Authorize(Roles = "Admin")]
        public ActionResult Index()
        {

            var Roles = _context.Roles.ToList();
            return View(Roles);

        }

        public ActionResult Create()
        {

            var Role = new IdentityRole();
            return View(Role);

        }

        [HttpPost]
        public ActionResult Create(IdentityRole Role)
        {

            Role.NormalizedName = Role.Name.ToUpper();

            _context.Roles.Add(Role);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }

    }

}
