using FinanCWebMaster.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanCWebMaster.DAO
{
    public class ContaDAO
    {

        //DAO = Data Access Object

        //Database context
        private readonly Context _context;

        public ContaDAO(Context context) => _context = context;



        //Validations

        //FirstOrDefault => Return the first element of an sequence    (Lambda)
        public Conta SearchForName(string name) => _context.Contas.FirstOrDefault(x => x.FirstName == name);
        public Conta SearchForCpf(string cpf) => _context.Contas.FirstOrDefault(x => x.Cpf == cpf);

        //CRUD OPERATIONS


        //CREATE
        public bool Create(Conta x)
        {

            if(SearchForCpf(x.Cpf) == null)
            {

                _context.Contas.Add(x);
                _context.SaveChanges();

                return true;

            }
           
            return false;

        }

        //LIST ALL
        public List<Conta> List() => _context.Contas.ToList();

        //LIST BY ID
        public Conta ListById(int Id) => _context.Contas.Find(Id);

        //UPDATE
        public void Update(Conta x)
        {

            _context.Contas.Update(x);
            _context.SaveChanges();

        }

        //DELETE
        public void Delete(Conta x)
        {

            _context.Contas.Remove(x);
            _context.SaveChanges();

        }

    }

}
