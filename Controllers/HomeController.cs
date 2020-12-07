using System;
using System.Collections.Generic;
using FinanCWebMaster.DAO;
using FinanCWebMaster.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace FinanCWebMaster.Controllers
{
    public class HomeController : Controller
    {

        SignInManager<ContaAuth> SignInManager;
        UserManager<ContaAuth> UserManager;

        private readonly CategoriaDAO _CategoriaDAO;
        private readonly LancamentoDAO _LancamentoDAO;

        public HomeController(CategoriaDAO categoriaDAO, LancamentoDAO lancamentoDAO) {
            
            _LancamentoDAO = lancamentoDAO;
            _CategoriaDAO = categoriaDAO;

        }
        
        [Authorize(Roles = "Admin,Usr")]
        public IActionResult Index()
        {

            ViewBag.Title = "Home";
            return View();

        }

    }

}
