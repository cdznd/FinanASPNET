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

            if (!lancamento.isProfit)
            {

                lancamento.Valor = -lancamento.Valor;

            }
            else
            {

                lancamento.Valor *= -1;

            }

            _context.Lancamentos.Add(lancamento);
            _context.SaveChanges();

        }
        
        //READ

        public List<Lancamento> List() => _context.Lancamentos.ToList();

        public Lancamento FindById(int id) => _context.Lancamentos.FirstOrDefault(lancamento => lancamento.Id == id);

        public List<Lancamento> ListByMonth(int date) => _context.Lancamentos.Where(lancamento => lancamento.CreationDate.Month == date).ToList();


        //Authenticated User Methods

        public List<Lancamento> authList(string contaUsername) => _context.Lancamentos.Where(lancamento => lancamento.Conta.Email == contaUsername).ToList();

        public Lancamento authFindById(string contaUsername, int lancamentoId) => _context.Lancamentos.FirstOrDefault(lancamento => lancamento.Conta.Email == contaUsername && lancamento.Id == lancamentoId);

        public List<Lancamento> authListByMonth(string contaUsername, int date) => _context.Lancamentos.Where(lancamento => lancamento.CreationDate.Month == date && lancamento.Conta.Email == contaUsername).ToList();

        public List<Lancamento> authListDespesas(string contaUsername) => _context.Lancamentos.Where(lancamento => lancamento.isProfit == false && lancamento.Conta.Email == contaUsername).ToList();

        public List<Lancamento> authListLucro(string contaUsername) => _context.Lancamentos.Where(lancamento => lancamento.isProfit == true && lancamento.Conta.Email == contaUsername).ToList();

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

            if (!lancamento.isProfit)
            {

                if(lancamento.Valor > 0)
                {

                    lancamento.Valor = -lancamento.Valor;

                }

            }
            else
            {

                lancamento.Valor = Math.Abs(lancamento.Valor);

            }

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
