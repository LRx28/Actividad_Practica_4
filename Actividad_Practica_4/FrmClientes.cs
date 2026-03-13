using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Actividad_Practica_4
{
    public class FrmClientes  :  DbContext 
    {
        
        public FrmClientes()
            : base("name=FrmClientes")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public DbSet<GestionClientes> Cliente { get; set; }


    }
}
