using FinanCWebMaster.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using FinanCWebMaster.DAO;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace FinanCWebMaster.Controllers
{

    public class ContaController : Controller
    {
        
        private readonly ContaDAO _ContaDAO;

        private readonly IHostingEnvironment _hosting;

        public ContaController(ContaDAO contaDAO, IHostingEnvironment hosting) {
            
            _ContaDAO = contaDAO;
            _hosting = hosting;

        }

        public IActionResult Index()
        {

            List<Conta> Contas = _ContaDAO.List();

            ViewBag.Title = "Contas";

            return View(Contas);

        }

        //CREATE VIEW
        public IActionResult Create() => View();

        //CREATE
        [HttpPost]
        public IActionResult Create(Conta conta, IFormFile file)
        {
           
            if(file != null)
            {
                //Search for Guid
                //Guid is an Globally idetifiew, Identificador unico global

                string imgFileName = $"{Guid.NewGuid()}{Path.GetExtension(file.FileName)}";

                //string imgFileName = Path.GetFileName(file.FileName);
                string pathFileStorage = Path.Combine(_hosting.WebRootPath,"images",imgFileName);

                file.CopyTo(new FileStream(pathFileStorage, FileMode.CreateNew));

                conta.Image = imgFileName;

            }
            else
            {

                conta.Image = "default.png";

            }


            if (!TryValidateModel(conta))
            {


                return View();


            }

            //Validation
            if (_ContaDAO.Create(conta))
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

        //UPDATE
        [HttpPost]
        public IActionResult Update(Conta conta)
        {

            //UPDATE
            _ContaDAO.Update(conta);

            return RedirectToAction("Index", "Conta");

        }

        public IActionResult Delete(int id)
        {

            Conta conta = _ContaDAO.ListById(id);

            //DELETE
            _ContaDAO.Delete(conta);

            return RedirectToAction("Index", "Conta");

        }

    }

}
