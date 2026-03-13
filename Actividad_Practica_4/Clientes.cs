using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Actividad_Practica_4
{
    public partial class Form1 : Form
    {
        private FrmClientes _context;
        public Form1()
        {
            InitializeComponent();
            _context = new FrmClientes();

        }  

        private void cargarClientes()
        {
           var listaClientes = _context.Clientes
                .Select(c => new
                {
                    ID = c.ClienteID,
                    Nombre = c.NombreCompleto,
                    Correo = c.CorreoElectronico,
                    Telefono = c.Telefono,
                    Direccion = c.Direccion
            }).ToList();

            var n = listaClientes.First ();
            
            dgv_Clientes.DataSource = listaClientes;


        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {

        }
    }
}
