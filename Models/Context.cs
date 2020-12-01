using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanCWebMaster.Models
{

    public class Context : IdentityDbContext<ContaAuth>
    {

        public Context(DbContextOptions options) : base(options) { }

        //Table
        public DbSet<Conta> Contas { get; set; }

        public DbSet<Categoria> Categorias { get; set; }
        
        public DbSet<Lancamento> Lancamentos { get; set; }

        //If something doesn't work in relation check for LazyLoading() propertie => optionsBuilder.UseLazyLoadingProxies();


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseLazyLoadingProxies();

        }

    }   

}
