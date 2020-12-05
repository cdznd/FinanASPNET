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

        private readonly Context _context;

        public ContaDAO(Context context) => _context = context;

        //CREATE
        public bool Create(Conta conta)
        {

            _context.Contas.Add(conta);
            _context.SaveChanges();

            return true;

        }

        //READ
        public List<Conta> List() => _context.Contas.ToList();

        //LIST BY ID
        public Conta FindById(int Id) => _context.Contas.Find(Id);
        public Conta FindByFirstName(string name) => _context.Contas.FirstOrDefault(conta => conta.FirstName == name);
        public Conta FindByCpf(string cpf) => _context.Contas.FirstOrDefault(conta => conta.Cpf == cpf);
        public Conta FindByEmail(string email) => _context.Contas.FirstOrDefault(conta => conta.Email == email);

        //UPDATE
        public void Update(Conta conta)
        {

            _context.Contas.Update(conta);
            _context.SaveChanges();

        }

        //DELETE
        public void Delete(Conta conta)
        {

            _context.Contas.Remove(conta);
            _context.SaveChanges();

        }

    }

}
