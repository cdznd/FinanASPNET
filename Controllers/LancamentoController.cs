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

            ViewBag.Title = "Lancamentos";

            return View(Lancamentos);

        }

        //CREATE 
        public IActionResult Create()
        {

            List<Conta> Contas = _ContaDAO.List();
            List<Categoria> Categorias = _CategoriaDAO.List();

            ViewBag.Contas = Contas;
            ViewBag.Categorias = Categorias;

            return View();

        }

        [HttpPost]
        public IActionResult Create(Lancamento lancamento)
        {

            _LancamentoDAO.Create(lancamento);
            return RedirectToAction("Index","Lancamento");

        }

        //UPDATE 
        public IActionResult Update(int Id)
        {

            List<Conta> Contas = _ContaDAO.List();
            List<Categoria> Categorias = _CategoriaDAO.List();

            ViewBag.Contas = Contas;
            ViewBag.Categorias = Categorias;

            return View(_LancamentoDAO.findById(Id));

        }

        [HttpPost]
        public IActionResult Update(Lancamento lancamento)
        {

            _LancamentoDAO.Update(lancamento);

            return RedirectToAction("Index", "Lancamento");

        }

        //DELETE
        public IActionResult Delete(int Id)
        {

            Lancamento x = _LancamentoDAO.findById(Id);

            _LancamentoDAO.Delete(x);

            return RedirectToAction("Index", "Lancamento");

        }

    }

}
