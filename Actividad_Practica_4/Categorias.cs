using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Actividad_Practica_4.Model;


namespace Actividad_Practica_4
{
    public partial class Form1 : Form
    {
        private Actividad4Model _context;

        

        public Form1()
        {
            InitializeComponent();
            _context = new Actividad4Model();
            cargarCategoria();
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
            if (int.TryParse(txt_NombreCategoria.Text, out int nombreCategoria))
            {
                MessageBox.Show("El nombre de la categoria esta vario o incorrecto.");
                return;
                   
            }
            txt_NombreCategoria.Clear();

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
                txt_NombreCategoria.Clear();

            }

        }
        
        private void btn_CargarCategoria_Click(object sender, EventArgs e)
        {
            cargarCategoria();
        }

        private void btn_EliminarCategoria_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_EliminarCategoria.Text))
            {
                MessageBox.Show("Debe introducir un Id valido.");
                return;
            }
            try
            {
                var eliminarCategoria = int.Parse(txt_EliminarCategoria.Text);
                Categorias categoriaEliminar = _context.Categorias.Find(eliminarCategoria);
                if (categoriaEliminar == null)
                {
                    MessageBox.Show("Este ID de categoria no existe.");
                    return;
                }

                _context.Categorias.Remove(categoriaEliminar);
                var resultado = _context.SaveChanges();
                if (resultado > 0)
                {
                    MessageBox.Show("Categoria eliminada correctamente.");
                    cargarCategoria();
                    txt_EliminarCategoria.Clear();
                }
            }
            catch (Exception x)
            {

                MessageBox.Show($"Error al introducir el ID: {x}");
            }
            




        }

        private void btn_ActualizarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_IdCategoriaActualizar.Text))
                {
                    MessageBox.Show("Debe introducir un Id valido.");
                    return;
                }

                if (string.IsNullOrEmpty(txt_NombreCategoriaA.Text))
                {
                    MessageBox.Show("Debe introducir un nombre de la categoria valido.");
                    return;
                }

                var eliminarCategoria = int.Parse(txt_IdCategoriaActualizar.Text);

                Categorias categoriaEliminar = _context.Categorias.FirstOrDefault(q => q.CategoriaID.Equals(eliminarCategoria));
                if (categoriaEliminar == null)
                {
                    MessageBox.Show("Este ID de categoria no existe.");
                    return;
                }

                categoriaEliminar.NombreCategoria = txt_NombreCategoriaA.Text;
                var resultado = _context.SaveChanges();
                if (resultado > 0)
                {
                    MessageBox.Show("Categoria actualizada correctamente.");

                }

                cargarCategoria();
                txt_IdCategoriaActualizar.Clear();
                txt_NombreCategoriaA.Clear();

            }
            catch (Exception x)
            {

                MessageBox.Show($"Error al actualizar Categoria{x}");
            }
            
            
            



        }
    }
}
