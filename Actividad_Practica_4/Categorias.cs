using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Actividad_Practica_4.Model;


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
        private void cargarCategoria()
        {
            var listaCategoria = _context.Categorias
                .Select(c => new
                {
                    ID = c.CategoriaID,
                    Nombre = c.NombreCategoria 
                }).ToList();

            var n = listaCategoria.First();
            dgv_Categoria.DataSource = listaCategoria;


        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_AgregarCategoria_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_NombreCategoria.Text))
            {
                MessageBox.Show("El nombre de la categoria esta vario o incorrecto.");
                return;
            }

            Categorias nuevaCategoria = new Categorias();
            {
                nuevaCategoria.NombreCategoria = txt_NombreCategoria.Text;

            }
            _context.Categorias.Add(nuevaCategoria);
            var resultado = _context.SaveChanges();
            if (resultado > 0)
            {
                MessageBox.Show("Categoria agregada correctamente.");
                cargarCategoria();


            }

        }
        
        private void btn_CargarCategoria_Click(object sender, EventArgs e)
        {
            cargarCategoria();
        }
    }
}
