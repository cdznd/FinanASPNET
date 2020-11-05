using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanCWebMaster.DAO;
using FinanCWebMaster.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinanCWebMaster.Controllers
{
    public class LancamentoController : Controller
    {

        private readonly LancamentoDAO _LancamentoDAO;
        private readonly ContaDAO _ContaDAO;
        private readonly CategoriaDAO _CategoriaDAO;

        public LancamentoController(LancamentoDAO lancamentoDAO, ContaDAO contaDAO, CategoriaDAO categoriaDAO) {

            _LancamentoDAO = lancamentoDAO;
            _ContaDAO = contaDAO;
            _CategoriaDAO = categoriaDAO;

        }

        public IActionResult Index()
        {

            List<Lancamento> Lancamentos = _LancamentoDAO.List();
            return View(Lancamentos);

        }

        //CREATE VIEW
        public IActionResult Create()
        {

            List<Conta> Contas = _ContaDAO.List();
            List<Categoria> Categorias = _CategoriaDAO.List();

            ViewBag.Contas = Contas;
            ViewBag.Categorias = Categorias;

            return View();

        }

        [HttpPost]
        public IActionResult Create(Lancamento x)
        {

            _LancamentoDAO.Create(x);
            return RedirectToAction("Index","Lancamento");

        }

        //UPDATE VIEW
        public IActionResult Update(int Id)
        {

            List<Conta> Contas = _ContaDAO.List();
            List<Categoria> Categorias = _CategoriaDAO.List();

            ViewBag.Contas = Contas;
            ViewBag.Categorias = Categorias;

            return View(_LancamentoDAO.findById(Id));

        }

        [HttpPost]
        public IActionResult Update(Lancamento x)
        {

            _LancamentoDAO.Update(x);

            return RedirectToAction("Index", "Lancamento");

        }

        //DELETE
        public IActionResult Remove(int Id)
        {

            Lancamento x = _LancamentoDAO.findById(Id);

            _LancamentoDAO.Delete(x);

            return RedirectToAction("Index", "Lancamento");

        }

    }

}
