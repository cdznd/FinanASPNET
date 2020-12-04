using System;
using System.Collections.Generic;
using FinanCWebMaster.DAO;
using FinanCWebMaster.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;

using Microsoft.AspNetCore.Identity;

namespace FinanCWebMaster.Controllers
{
    public class HomeController : Controller
    {

        SignInManager<ContaAuth> SignInManager;
        UserManager<ContaAuth> UserManager;

        private readonly CategoriaDAO _CategoriaDAO;

        public HomeController(CategoriaDAO categoriaDAO) => _CategoriaDAO = categoriaDAO;

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


            

            //List<Categoria> => JSON
            //Newsonsoft.Json

            /*
            var y = JsonConvert.SerializeObject(lancamentos, Formatting.Indented,
                new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                    //ReferenceLoopHandling = ReferenceLoopHandling.Serialize
                    //PreserveReferencesHandling = PreserveReferencesHandling.Objects

                });

            var x = JsonConvert.SerializeObject(categorias, Formatting.Indented,
                new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                    //ReferenceLoopHandling = ReferenceLoopHandling.Serialize
                    //PreserveReferencesHandling = PreserveReferencesHandling.Objects

                });

            */


            ViewBag.Title = "Home";
            return View();

        }

    }

}
