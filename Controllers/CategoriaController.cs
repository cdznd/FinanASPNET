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
        //Read-only variable
        private readonly CategoriaDAO _CategoriaDAO;

        public CategoriaController(CategoriaDAO categoriaDAO) => _CategoriaDAO = categoriaDAO;

        public IActionResult Index()
        {
            
            List<Categoria> Categorias = _CategoriaDAO.List();

            ViewBag.Title = "Categorias";

            return View(Categorias);

        }

        //CREATE
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(Categoria categoria)
        {

            if (!TryValidateModel(categoria))
            {

                return View();

            }
            else
            {

                _CategoriaDAO.Create(categoria);
                return RedirectToAction("Index", "Categoria");

            }

        }

        //UPDATE
        public IActionResult Update(int id)
        {

            return View(_CategoriaDAO.FindById(id));

        }

        [HttpPost]
        public IActionResult Update(Categoria categoria)
        {

            _CategoriaDAO.Update(categoria);
            return RedirectToAction("Index","Categoria");

        }

        //DELETE
        public IActionResult Delete(int id)
        {

            Categoria categoria = _CategoriaDAO.FindById(id);
            _CategoriaDAO.Delete(categoria);

            return RedirectToAction("Index","Categoria");

        }

    }

}
