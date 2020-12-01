using FinanCWebMaster.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FinanCWebMaster.DAO
{
    public class CategoriaDAO
    {

        //DAO = DATA ACCESS OBJECT

        private readonly Context _context;

        public CategoriaDAO(Context context) => _context = context;

        public Categoria FindById(int id) => _context.Categorias.FirstOrDefault(x => x.Id == id);

        //CREATE
        public void Create(Categoria x)
        {

            _context.Categorias.Add(x);
            _context.SaveChanges();

        }

        //READ
        public List<Categoria> List() => _context.Categorias.ToList();


        //UPDATE
        public void Update(Categoria x)
        {

            _context.Categorias.Update(x);
            _context.SaveChanges();

        }

        //DELETE 
        public void Delete(Categoria x)
        {

            _context.Categorias.Remove(x);
            _context.SaveChanges();

        }

    }

}
