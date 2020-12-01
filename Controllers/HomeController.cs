using System;
using System.Collections.Generic;
using FinanCWebMaster.DAO;
using FinanCWebMaster.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace FinanCWebMaster.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly CategoriaDAO _CategoriaDAO;

        public HomeController(CategoriaDAO categoriaDAO) => _CategoriaDAO = categoriaDAO;

        public IActionResult Index()
        {

            List<Categoria> Categorias = _CategoriaDAO.List();
            List<String> CategoriasName = new List<String>();

   

            


            ViewBag.Title = "Home";
            return View();

        }

    }

}
