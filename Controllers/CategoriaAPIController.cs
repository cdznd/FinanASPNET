using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanCWebMaster.DAO;
using FinanCWebMaster.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinanCWebMaster.Controllers
{
    [Route("api/Categoria")]
    [ApiController]
    public class CategoriaAPIController : ControllerBase
    {

        //Read-only variable
        private readonly CategoriaDAO _CategoriaDAO;

        public CategoriaAPIController(CategoriaDAO categoriaDao)
        {

            _CategoriaDAO = categoriaDao;

        }

        //GET: /api/Categoria/List
        [HttpGet]
        [Route("List")]
        public IActionResult List()
        {

            List<Categoria> categorias = _CategoriaDAO.List();
            
            if(categorias.Count > 0)
            {

                return Ok(categorias);

            }

            return BadRequest(new { msg = "Não existe nenhuma categoria." });

        }

        [HttpGet]
        [Route("Search/{id}")]
        public IActionResult Search(int id)
        {

            Categoria categoria = _CategoriaDAO.findById(id);

            if(categoria != null)
            {

                return Ok(categoria);

            }

            return BadRequest(new { msg = "Categoria não encontrada!" });

        }

        [HttpGet]
        [Route("Search/{id}/Lancamentos")]
        public IActionResult ListLancamentos(int id)
        {

            Categoria categoria = _CategoriaDAO.findById(id);

            if (categoria != null)
            {

                return Ok(categoria.Lancamentos);

            }

            return BadRequest(new { msg = "Categoria não encontrada!" });

        }

        [HttpGet]
        [Route("Search/{id}/ListLancamentosValueByConta")]
        public IActionResult ListLancamentosValueByConta(int id)
        {

            List<Categoria> categorias = _CategoriaDAO.List();

            double valorTotal = 0.0;

            String ContaUserName = User.Identity.Name;

            foreach (Categoria categoria in categorias)
            {

                if (categoria.Id == id)
                {

                    foreach (Lancamento lancamento in categoria.Lancamentos)
                    {

                        if(lancamento.Conta.Email == ContaUserName)
                        {

                            valorTotal += lancamento.Valor;

                        }

                    }

                }

            }

            return Ok(valorTotal);

        }


        [HttpGet]
        [Route("Search/{CategoriaName}/LancamentosValueByName")]
        public IActionResult ListLancamentosValueByName(string CategoriaName)
        {

            List<Categoria> categorias = _CategoriaDAO.List();

            double valorTotal = 0.0;

            foreach (Categoria categoria in categorias)
            {

                if (categoria.Nome == CategoriaName)
                {

                    foreach (Lancamento lancamento in categoria.Lancamentos)
                    {

                        valorTotal += lancamento.Valor;

                    }

                }

            }

            return Ok(valorTotal);

        }

        /*
        [HttpPost]
        [Route("Cadastrar")]
        public IActionResult Create(Categoria categoria)
        {

            
            if (!TryValidateModel(categoria))
            {

                return BadRequest(ModelState);

            }
            else
            {

                if (_CategoriaDAO.Create(categoria))
                {

                    return Created("", categoria);

                }
                return RedirectToAction("Index", "Categoria");

            }
            */

    }

}


