using FinanCWebMaster.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using FinanCWebMaster.DAO;

namespace FinanCWebMaster.Controllers
{

    public class ContaController : Controller
    {
        
        //DAO
        private readonly ContaDAO _ContaDAO;

        //Constructor
        public ContaController(ContaDAO contaDAO) => _ContaDAO = contaDAO;

        public IActionResult Index()
        {

            List<Conta> Contas = _ContaDAO.List();
            
            //ViewBags
            //ViewBag.Contas = Contas;
            //ViewBag.Quantidade = Contas.Count;

            //Return to the Index view with the ViewBags.
            return View(Contas);

        }

        //CREATE VIEW
        public IActionResult Create() => View();

        //CREATE
        [HttpPost]
        /*
        public IActionResult Create(string firstNameTxt, string secondNameTxt, string cpfTxt)
        {

            Conta x = new Conta
            {

                FirstName = firstNameTxt,
                SecondName = secondNameTxt,
                Cpf = cpfTxt

            };

            //Validation
            if (_ContaDAO.Create(x))
            {

                return RedirectToAction("Index", "Conta");

            }

            ModelState.AddModelError("", "Cpf ja existe");
            return View();

        }
        */

        //CREATE
        [HttpPost]
        public IActionResult Create(Conta x)
        {
           
            if (!TryValidateModel(x))
            {


                return View();


            }

            //Validation
            if (_ContaDAO.Create(x))
            {

                return RedirectToAction("Index", "Conta");

            }

            ModelState.AddModelError("", "Cpf ja existe");
            return View();

        }

        //UPDATE VIEW
        public IActionResult Update(int id)
        {

            //Is possible to use Viewbags too
            //LIST BY ID
            //ViewBag.Conta = _ContaDAO.ListById(id);

            return View(_ContaDAO.ListById(id));

        }

        /*
        //UPDATE
        [HttpPost]
        public IActionResult Update(int Id, string firstNameTxt, string secondNameTxt, string cpfTxt)
        {

            //LIST BY ID TO FIND THE CONTA TO UPDATE
            Conta x = _ContaDAO.ListById(Id);

            //UPDATING THE ACCOUNT
            x.FirstName = firstNameTxt;
            x.SecondName = secondNameTxt;
            x.Cpf = cpfTxt;

            //UPDATE
            _ContaDAO.Update(x);            

            return RedirectToAction("Index", "Conta");

        }
        */

        //UPDATE
        [HttpPost]
        public IActionResult Update(Conta x)
        {

            //UPDATE
            _ContaDAO.Update(x);

            return RedirectToAction("Index", "Conta");

        }

        public IActionResult Remove(int id)
        {

            //LIST BY ID TO FIND THE CONTA TO DELETE
            Conta x = _ContaDAO.ListById(id);

            //DELETE
            _ContaDAO.Delete(x);

            return RedirectToAction("Index", "Conta");

        }

    }

}
