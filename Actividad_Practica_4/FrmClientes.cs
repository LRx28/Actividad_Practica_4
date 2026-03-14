using Actividad_Practica_4.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Actividad_Practica_4
{
    public class TiendaContext :  DbContext 
    {
        
        public TiendaContext()
            : base("name=TiendaContext")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Categorias> Categorias { get; set; }
        public DbSet<Proveedores> Proveedores { get; set; } 
        
        public DbSet<Productos> Productos { get; set; }



    }
}
