using FinanCWebMaster.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanCWebMaster.DAO
{
    public class LancamentoDAO
    {

        //DAO = DATA ACCESS OBJECT

        private readonly Context _context;

        public LancamentoDAO(Context context) => _context = context;

        //CREATE
        public void Create(Lancamento lancamento)
        {

            _context.Lancamentos.Add(lancamento);
            _context.SaveChanges();

        }
        
        //READ

        public List<Lancamento> List() => _context.Lancamentos.ToList();

        public Lancamento FindById(int id) => _context.Lancamentos.FirstOrDefault(lancamento => lancamento.Id == id);

        public List<Lancamento> ListByMonth(int date) => _context.Lancamentos.Where(lancamento => lancamento.CreationDate.Month == date).ToList();


        //Authenticated User Methods

        //public List<Lancamento> authList(int contaId) => _context.Lancamentos.Where(lancamento => lancamento.ContaId == contaId).ToList();

        //public Lancamento authFindById(int contaId, int lancamentoId) => _context.Lancamentos.FirstOrDefault(lancamento => lancamento.Id == lancamentoId && lancamento.ContaId == contaId);

        //public List<Lancamento> authListByMonth(int contaId, int date) => _context.Lancamentos.Where(lancamento => lancamento.CreationDate.Month == date && lancamento.ContaId == contaId).ToList();

        //Fixed
        //Retorna os lançamentos de um determinado mes
        //public static List<Lancamento> ListByMonth(int Id, int date) => _context.Lancamento.Where(x => x.ContaId == Id && x.CreationDate.Month == date).ToList();
        //Retorna lancamentos de um itervalo de dias
        //public static List<Lancamento> ReadByDayIntervalo(int Id, int day1, int day2) => _context.Lancamento.Where(x => x.ContaId == Id && x.CreationDate.Day > day1 && x.CreationDate.Day < day2).ToList();
        //Retorna lancamentos de um mes e intervalo de dias.
        //public static List<Lancamento> ReadByDate(int Id, int month, int day1, int day2) => _context.Lancamento.Where(x => x.ContaId == Id && x.CreationDate.Month == month && x.CreationDate.Day > day1 && x.CreationDate.Day < day2).ToList();

        //Listar todos os lancamentos de uma conta
        //public List<Lancamento> ListByContaName(string contaName) => _context.Lancamentos.Find(x => x.)

        //Listar todos os lancamentos de uma categoria



        //UPDATE
        public void Update(Lancamento lancamento)
        {

            _context.Lancamentos.Update(lancamento);
            _context.SaveChanges();

        }
        //DELETE
        public void Delete(Lancamento lancamento)
        {

            _context.Lancamentos.Remove(lancamento);
            _context.SaveChanges();
        }


    }

}
