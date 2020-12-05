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

        public HomeController(CategoriaDAO categoriaDAO) => _CategoriaDAO = categoriaDAO;
        
        [Authorize(Roles = "Admin,Usr")]
        public IActionResult Index()
        {

            List<Categoria> categorias = _CategoriaDAO.List();
            List<String> CategoriasName = new List<String>();

            List<Lancamento> lancamentos = new List<Lancamento>();

            //double valorTotal;
            double valorTotal = 0;

            foreach (Categoria categoria in categorias)
            {

                if (categoria.Id == 5)
                {

                    foreach (Lancamento lancamento in categoria.Lancamentos)
                    {

                        valorTotal += lancamento.Valor;

                    }

                }

            }

            Console.WriteLine(valorTotal);

            ViewBag.Title = "Home";
            return View();

        }

    }

}
