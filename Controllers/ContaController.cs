using FinanCWebMaster.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using FinanCWebMaster.DAO;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace FinanCWebMaster.Controllers
{

    //One level of abstraction per Function

    public class ContaController : Controller
    {
        
        private readonly ContaDAO _ContaDAO;

        private readonly IHostingEnvironment _hosting;

        private readonly UserManager<ContaAuth> _userManager;

        private readonly SignInManager<ContaAuth> _signInManager;

        public ContaController(ContaDAO contaDAO, IHostingEnvironment hosting, UserManager<ContaAuth> contaManager, SignInManager<ContaAuth> signInManager) {
            
            _ContaDAO = contaDAO;
            _hosting = hosting;
            _userManager = contaManager;
            _signInManager = signInManager;

        }

        public IActionResult ContaInfo()
        {

            string username = User.Identity.Name;

            Conta profile = _ContaDAO.FindByEmail(username);

            return View(profile);

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
        public async Task<IActionResult> Create(Conta conta, IFormFile file)
        {

            //Preciso validar o modelo antes de criar o conta Auth, ou o ContaAuth da conta de validar?
            if (TryValidateModel(conta))
            {

                ContaAuth contaAuth = new ContaAuth();
                contaAuth.UserName = conta.Email;
                contaAuth.Email = conta.Email;

                IdentityResult result = await _userManager.CreateAsync(contaAuth, conta.Password);

                if (!result.Succeeded)
                {

                    addErrors(result);

                    return View();

                }

                PictureAdapter(conta, file);

                //Validation
                if (_ContaDAO.Create(conta))
                {

                    return RedirectToAction("Index", "Conta");

                }
                else
                {

                    return View();

                }

            }
            else
            {

                return View();

            }

        }

        public void addErrors(IdentityResult result)
        {

            foreach(IdentityError error in result.Errors)
            {

                ModelState.AddModelError("", error.Description);

            }

        }

        //UPDATE VIEW
        public async Task<IActionResult> Update(int id)
        {

            //Is possible to use Viewbags too
            //LIST BY ID
            //ViewBag.Conta = _ContaDAO.ListById(id);

            return View(_ContaDAO.ListById(id));

        }

        //UPDATE
        [HttpPost]
        public async Task<IActionResult> Update(Conta conta)
        {

            //UPDATE
            _ContaDAO.Update(conta);

            return RedirectToAction("Index", "Conta");

        }

        public async Task<IActionResult> Delete(int id)
        {

            Conta conta = _ContaDAO.ListById(id);

            //DELETE
            _ContaDAO.Delete(conta);

            return RedirectToAction("Index", "Conta");

        }








        public void PictureAdapter(Conta conta, IFormFile file)
        {

            if (file != null)
            {

                //Search for Guid
                //Guid => Identificador unico global

                string imgFileName = $"{Guid.NewGuid()}{Path.GetExtension(file.FileName)}";

                string pathFileStorage = Path.Combine(_hosting.WebRootPath, "images", imgFileName);

                file.CopyTo(new FileStream(pathFileStorage, FileMode.CreateNew));

                conta.Image = imgFileName;

            }
            else
            {

                conta.Image = "default.png";

            }

        }





        //LOGIN

        public IActionResult Login()
        {

            return View();

        }

        [HttpPost]
        public async Task<IActionResult> Login([Bind("Email, Password")] Conta conta)
        {

            var result = await _signInManager.PasswordSignInAsync(conta.Email, conta.Password, false, false);

            if (result.Succeeded)
            {

                return RedirectToAction("Index", "Conta");

            }
            else
            {

                ModelState.AddModelError("", "Login invalido");
                return View(conta);

            }           

        }

        public async Task<IActionResult> Logout()
        {

            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");

        }

    }

}
