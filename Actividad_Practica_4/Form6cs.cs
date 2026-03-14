using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Actividad_Practica_4.Model;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_Practica_4
{
    public partial class Form6 : Form
    {
        private TiendaContext _context;

        public Form6()
        {
            InitializeComponent();
            _context = new TiendaContext();
           
        }

        private void CargarProductos()
        {
            var listaProductos = _context.Productos
                 .Select(c => new
                 {
                     ID = c.ProductoID,
                     Nombre = c.NombreProducto,
                     Precio = c.Precio,
                     Stock = c.Stock,
                     CategoriaID = c.CategoriaID,
                     ProveedorID = c.ProveedorID
                 }).ToList();
            var n = listaProductos.First();
            dgv_Productos.DataSource = listaProductos;
        }

        private void btn_AgregarProducto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_NombreProducto.Text))
            {
                MessageBox.Show("El nombre del producto esta vario o incorrecto.");
                return;
            }

            if (!decimal.TryParse(txt_Precio.Text, out decimal precio))
            {
                MessageBox.Show("El precio del producto esta vacio o incorrecto.");
                return;
            }

            if (!int.TryParse(txt_Stock.Text, out int stock))
            {
                MessageBox.Show("El stock del producto esta vacio o incorrecto.");
                return;
            }


            if (string.IsNullOrWhiteSpace(txt_Descripcion.Text))
            {
                MessageBox.Show("La descripcion del producto esta vario o incorrecto.");
                return;
            }

            cmb_AgregarProductos.DataSource = _context.Categorias.ToList();
            cmb_AgregarProductos.DisplayMember = "NombreCategoria";
            cmb_AgregarProductos.ValueMember = "CategoriaID";

            Productos nuevoProducto = new Productos();
            {
                nuevoProducto.NombreProducto = txt_NombreProducto.Text;
                nuevoProducto.Precio = precio;
                nuevoProducto.Stock = stock;
                nuevoProducto.Descripcion = txt_Descripcion.Text;
            }
            _context.Productos.Add(nuevoProducto);
            var resultado = _context.SaveChanges();
            if (resultado > 0)
            {
                MessageBox.Show("Producto agregado correctamente.");
                CargarProductos();
                txt_NombreProducto.Clear();
                txt_Precio.Clear();
                txt_Stock.Clear();
                txt_Descripcion.Clear();
            }

            else
            {
                MessageBox.Show("Error al agregar el producto.");

            }
        }

        private void btn_CargarProductos_Click(object sender, EventArgs e)
        {
            CargarProductos();
        }
    }
}
