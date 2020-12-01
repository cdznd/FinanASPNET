using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanCWebMaster.DAO;
using FinanCWebMaster.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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

            ViewBag.Title = "Lancamentos";

            List<Lancamento> lancamentos = _LancamentoDAO.List();

            return View(lancamentos);

        }

        //CREATE VIEW RETURNS
        public IActionResult Create()
        {

            ViewBag.Title = "Criar lançamento";

            Conta conta = _ContaDAO.SearchByEmail(User.Identity.Name);
            ViewBag.Conta = conta;

            //ViewBag.Contas = new SelectList(_ContaDAO.List(), "Id", "FirstName");
            ViewBag.Categorias = new SelectList(_CategoriaDAO.List(), "Id", "Nome");

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

            ViewBag.Title = "Atualizar lançamento";

            ViewBag.Contas = new SelectList(_ContaDAO.List(), "Id", "FirstName");
            ViewBag.Categorias = new SelectList(_CategoriaDAO.List(), "Id", "Nome");

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

            Lancamento lancamento = _LancamentoDAO.findById(Id);

            _LancamentoDAO.Delete(lancamento);

            return RedirectToAction("Index", "Lancamento");

        }

    }

}
