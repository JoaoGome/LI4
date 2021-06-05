using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Li4Fase3.Shared.Entities;

namespace Li4Fase3.Server
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {

        }

        public DbSet<Aviso> Aviso {get; set;} 
        public DbSet<Cliente> Cliente {get; set;} 
        public DbSet<Condicao> Condicao {get; set;} 
        public DbSet<Expansao> Expansao {get; set;} 
        public DbSet<Linguagem> Linguagem {get; set;} 
        public DbSet<Localizacao> Localizacao {get; set;} 
        public DbSet<Produto> Produto {get; set;} 
        public DbSet<Venda> Venda {get; set;} 
        public DbSet<Vendedor> Vendedor {get; set;} 


    }
}