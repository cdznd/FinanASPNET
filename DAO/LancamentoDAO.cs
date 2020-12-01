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

        //FIND BY ID
        public Lancamento findById(int id) => _context.Lancamentos.FirstOrDefault(x => x.Id == id);

        //CREATE
        public void Create(Lancamento lancamento)
        {

            _context.Lancamentos.Add(lancamento);
            _context.SaveChanges();

        }

        //LIST
        public List<Lancamento> List() => _context.Lancamentos.ToList();


        //UPDATE
        public void Update(Lancamento x)
        {

            _context.Lancamentos.Update(x);
            _context.SaveChanges();

        }
        //DELETE
        public void Delete(Lancamento x)
        {

            _context.Lancamentos.Remove(x);
            _context.SaveChanges();
        }


    }

}
