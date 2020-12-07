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
using System.Security.Principal;
using Microsoft.AspNetCore.Authorization;

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

        [Authorize(Roles = "Admin,Usr")]
        public IActionResult ContaInfo()
        {
            
            var currentUsername = User.Identity.Name;

            Conta profile = _ContaDAO.FindByEmail(currentUsername);

            ViewBag.Title = profile.FirstName + " " + profile.SecondName + " - Minha Conta";

            return View(profile);

        }

        public IActionResult OtherContaInfo(int id)
        {

            Conta profile = _ContaDAO.FindById(id);

            ViewBag.Title = profile.FirstName + " " + profile.SecondName + " - Conta";

            return View(profile);

        }

        [Authorize(Roles = "Admin,Usr")]
        public IActionResult Index()
        {

            ViewBag.Title = "Contas";

            List<Conta> Contas = _ContaDAO.List();

            return View(Contas);

        }

        //CREATE VIEW
        public IActionResult Create()
        {

            ViewBag.Title = "Criar Conta";

            return View();

        }

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
                //contaAuth.ContaId = conta.Id;
                //contaAuth.Id = conta.Id.ToString();

                IdentityResult result = await _userManager.CreateAsync(contaAuth, conta.Password);
                //await _userManager.AddToRoleAsync(contaAuth, "ADM");

                if (result.Succeeded)
                {

                    await _userManager.AddToRoleAsync(contaAuth, "Usr");

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

                    addErrors(result);

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
        public IActionResult Update(int id)
        {

            ViewBag.Title = "Atualizar conta";

            Conta conta = _ContaDAO.FindById(id);

            return View(conta);

        }

        //UPDATE
        [HttpPost]
        public async Task<IActionResult> Update(Conta conta, IFormFile file)
        {

            //ContaAuth contaAuth = new ContaAuth();
            //contaAuth.Email = conta.Email;
            //contaAuth.UserName = conta.Email;
            string userId = _userManager.GetUserId(User);
            var user = _userManager.FindByIdAsync(userId).Result;

            user.Email = conta.Email;
            user.UserName = conta.Email;

            IdentityResult result = await _userManager.UpdateAsync(user);

            if (result.Succeeded)
            {

                PictureAdapter(conta, file);

                _ContaDAO.Update(conta);

            }

            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");

        }

        //DELETE
        public async Task<IActionResult> Delete(int id)
        {

            Conta conta = _ContaDAO.FindById(id);

            _ContaDAO.Delete(conta);

            //Delete user
            string userId = _userManager.GetUserId(User);

            var user = await _userManager.FindByIdAsync(userId);

            await _userManager.DeleteAsync(user);

            await _signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");

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
