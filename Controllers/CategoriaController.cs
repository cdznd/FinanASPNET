using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanCWebMaster.DAO;
using FinanCWebMaster.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinanCWebMaster.Controllers
{
    public class CategoriaController : Controller
    {
        //DAO   
        private readonly CategoriaDAO _CategoriaDAO;

        //Constructor
        public CategoriaController(CategoriaDAO categoriaDAO) => _CategoriaDAO = categoriaDAO;

        public IActionResult Index()
        {
            
            List<Categoria> Categorias = _CategoriaDAO.List();

            return View(Categorias);

        }

        //CREATE

        //Return Create View
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(Categoria x)
        {

            //TODO Implement create funcions

            if (!TryValidateModel(x))
            {

                return View();

            }
            else
            {

                _CategoriaDAO.Create(x);
                return RedirectToAction("Index", "Categoria");

            }

        }

        //UPDATE

        //Return Update view
        public IActionResult Update(int id)
        {

            return View(_CategoriaDAO.FindById(id));

        }

        [HttpPost]
        public IActionResult Update(Categoria x)
        {

            _CategoriaDAO.Update(x);
            return RedirectToAction("Index","Categoria");

        }

        //DELETE
        public IActionResult Remove(int id)
        {

            Categoria x = _CategoriaDAO.FindById(id);
            _CategoriaDAO.Delete(x);

            return RedirectToAction("Index","Categoria");

        }

    }

}
