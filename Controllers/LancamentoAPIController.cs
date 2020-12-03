using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanCWebMaster.DAO;
using FinanCWebMaster.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FinanCWebMaster.Controllers
{
    [Route("api/Lancamento")]
    [ApiController]
    public class LancamentoAPIController : ControllerBase
    {
        
        private readonly LancamentoDAO _LancamentoDAO;

        public LancamentoAPIController(LancamentoDAO lancamentoDAO)
        {

            _LancamentoDAO = lancamentoDAO;

        }

        //GET: /api/Lancamento/List
        [HttpGet]
        [Route("List")]
        public IActionResult List()
        {

            List<Lancamento> lancamentos = _LancamentoDAO.List();

            if (lancamentos.Count > 0)
            {

                return Ok(lancamentos);

            }

            return BadRequest(new { msg = "Não existe nenhum lancamento." });

        }

        [HttpGet]
        [Route("Search/{id}")]
        public IActionResult Search(int id)
        {

            Lancamento lancamento = _LancamentoDAO.FindById(id);

            if (lancamento != null)
            {

                return Ok(lancamento);

            }

            return BadRequest(new { msg = "Lancamento não encontrado!" });

        }

        [HttpGet]
        [Route("Search/Month/{month}")]
        public IActionResult SearchByMonth(int month)
        {

            List<Lancamento> lancamentos = _LancamentoDAO.ListByMonth(month);

            if(lancamentos != null)
            {

                return Ok(lancamentos);

            }

            return BadRequest(new { msg = "Lancamento não encontrado!" });

        }

    }
}
