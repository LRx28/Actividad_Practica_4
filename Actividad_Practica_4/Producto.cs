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
    public partial class Productos : Form
    {
        private Actividad4Model _context;


        public Productos()
        {
            InitializeComponent();

            _context = new Actividad4Model();
            CargarProductos();



        }

        public void CargarProductos()
        {
            var listaProductos = _context.Productos
                 .Select(c => new
                 {
                     ID = c.ProductoID,
                     Nombre = c.NombreProducto,
                     Precio = c.Precio,
                     Stock = c.Stock,
                     CategoriaID = c.CategoriaID,

                 }).ToList();

            dgv_Productos.DataSource = listaProductos;
        }

        private void btn_AgregarProducto_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txt_NombreProducto.Text))
            {
                MessageBox.Show("El nombre del producto esta vacio o incorrecto.");
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



            Model.Productos nuevoProducto = new Model.Productos();
            {
                nuevoProducto.NombreProducto = txt_NombreProducto.Text;
                nuevoProducto.Precio = precio;
                nuevoProducto.Stock = stock;
                nuevoProducto.Descripcion = txt_Descripcion.Text;
                nuevoProducto.CategoriaID = (int)cmb_AgregarProductos.SelectedValue;
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

        private void Productos_Load(object sender, EventArgs e)
        {

            cmb_AgregarProductos.DataSource = _context.Categorias.ToList();
            cmb_AgregarProductos.DisplayMember = "NombreCategoria";
            cmb_AgregarProductos.ValueMember = "CategoriaID";

            cmb_ProductosA.DataSource = _context.Categorias.ToList();
            cmb_ProductosA.DisplayMember = "NombreCategoria";
            cmb_ProductosA.ValueMember = "CategoriaID";
        }

        private void btn_EliminarProducto_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(txt_EliminarProducto.Text, out int productoEliminar))
            {
                MessageBox.Show("ID incorrecto o vacio");
                return;
            }

            Model.Productos productos = _context.Productos.Find(productoEliminar);
            if (productos == null)
            {
                MessageBox.Show("Producto no encontrado.");
                return;
            }

            _context.Productos.Remove(productos);
            var resultado = _context.SaveChanges();

            if (resultado > 0)
            {
                MessageBox.Show("Producto eliminado correctamente.");
                CargarProductos();
                txt_EliminarProducto.Clear();
            }
            else
            {
                MessageBox.Show("Error al eliminar el producto.");
            }


        }
        private void btn_ActualizarProductos_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_IdProductosA.Text, out int productoActualizarID))
            {
                MessageBox.Show("ID incorrecto o vacio");
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_NombreProductoA.Text))
            {
                MessageBox.Show("El nombre del producto esta vacio o incorrecto.");
                return;
            }

            if (!decimal.TryParse(txt_PrecioA.Text, out decimal precio))
            {
                MessageBox.Show("El precio del producto esta vacio o incorrecto.");
                return;
            }

            if (!int.TryParse(txt_StockA.Text, out int stock))
            {
                MessageBox.Show("El stock del producto esta vacio o incorrecto.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_DescripcionA.Text))
            {
                MessageBox.Show("La descripcion del producto esta vacia o incorrecta.");
                return;
            }

            if (cmb_ProductosA.SelectedValue == null)
            {
                MessageBox.Show("Seleccione una categoria valida.");
                return;
            }

            Model.Productos productoActualizar = _context.Productos.Find(productoActualizarID);
            if (productoActualizar == null)
            {
                MessageBox.Show("Producto no encontrado.");
                return;
            }

            productoActualizar.NombreProducto = txt_NombreProductoA.Text;
            productoActualizar.Precio = precio;
            productoActualizar.Stock = stock;
            productoActualizar.Descripcion = txt_DescripcionA.Text;
            productoActualizar.CategoriaID = (int)cmb_ProductosA.SelectedValue;

            var resultado = _context.SaveChanges();
            if (resultado > 0)
            {
                MessageBox.Show("Producto actualizado correctamente.");
                CargarProductos();
                txt_IdProductosA.Clear();
                txt_NombreProductoA.Clear();
                txt_PrecioA.Clear();
                txt_StockA.Clear();
                txt_DescripcionA.Clear();
            }
            else
            {
                MessageBox.Show("Error al actualizar el producto.");
            }
        }


    }

}

