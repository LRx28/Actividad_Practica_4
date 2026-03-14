using Actividad_Practica_4.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_Practica_4
{
    public partial class form3 : Form
    {
        private FrmClientes _context;
        public form3()
        {
            InitializeComponent();
            _context = new FrmClientes();
            CargarProveedores();
        }
        private void CargarProveedores()
        {
            var listaProveedores = _context.Proveedores
                 .Select(c => new
                 {
                     ID = c.ProveedorID,
                     Nombre = c.NombreProveedor,
                     Correo = c.CorreoElectronico,
                     Telefono = c.Telefono,
                 }).ToList();
            var n = listaProveedores.First();
            dgv_Proveedores.DataSource = listaProveedores;
        }




        private void btn_AgregarProveedor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_NombreProveedor.Text))
            {
                MessageBox.Show("El nombre del proveedor esta vario o incorrecto.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_CorreoProveedor.Text))
            {
                MessageBox.Show("El Correo del proveedor esta vacio o incorrecto.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_TelefonoProveedor.Text))
            {
                MessageBox.Show("El Telefono del proveedor esta vacio o incorrecto.");
                return;
            }

            Proveedores nuevoProveedor = new Proveedores();
            {
                nuevoProveedor.NombreProveedor = txt_NombreProveedor.Text;
                nuevoProveedor.CorreoElectronico = txt_CorreoProveedor.Text;
                nuevoProveedor.Telefono = txt_TelefonoProveedor.Text;
            }

            _context.Proveedores.Add(nuevoProveedor);
            var resultado = _context.SaveChanges();
            if (resultado > 0)
            {
                MessageBox.Show("Proveedor agregado correctamente");
                CargarProveedores();
                txt_NombreProveedor.Clear();
                txt_CorreoProveedor.Clear();
                txt_TelefonoProveedor.Clear();

            }






        }

        private void txt_EliminarProveedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_EliminarProveedor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_EliminarProveedor.Text))
            {
                MessageBox.Show("El ID del proveedor esta vacio o incorrecto.");
                return;
            }

            try
            {
                var proveedorID = Convert.ToInt32(txt_EliminarProveedor.Text);

                Proveedores proveedorAEliminar = _context.Proveedores.Find(proveedorID);
                if (proveedorAEliminar == null)
                {
                    MessageBox.Show("No se encontró el proveedor con el ID .");
                    return;
                }

                _context.Proveedores.Remove(proveedorAEliminar);
                var resultado = _context.SaveChanges();
                if (resultado > 0)
                {
                    MessageBox.Show("Proveedor eliminado correctamente");
                    CargarProveedores();
                    txt_EliminarProveedor.Clear();
                }

            }
            catch (Exception x)
            {

                MessageBox.Show($"Error al eliminar proveedor {x}");
            }
        }

        private void btn_ActualizarProvee_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_IdProoveedorA.Text))
            {
                MessageBox.Show("El ID del proveedor esta vacio o incorrecto.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_NombreProveedorA.Text))
            {
                MessageBox.Show("El nombre del proveedor esta vario o incorrecto.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_CorreoA.Text))
            {
                MessageBox.Show("El Correo del proveedor esta vacio o incorrecto.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_TelefonoProveedorA.Text))
            {
                MessageBox.Show("El Telefono del proveedor esta vacio o incorrecto.");
                return;
            }
            try
            {
                var proveedorID = Convert.ToInt32(txt_IdProoveedorA.Text);
                Proveedores proveedorAActualizar = _context.Proveedores.FirstOrDefault(q => q.ProveedorID.Equals(proveedorID));
                if (proveedorAActualizar == null)
                {
                    MessageBox.Show("No se encontró el proveedor con el ID .");
                    return;
                }
                proveedorAActualizar.NombreProveedor = txt_NombreProveedorA.Text;
                proveedorAActualizar.CorreoElectronico = txt_CorreoA.Text;
                proveedorAActualizar.Telefono = txt_TelefonoProveedorA.Text;
                var resultado = _context.SaveChanges();
                if (resultado > 0)
                {
                    MessageBox.Show("Proveedor actualizado correctamente");
                    CargarProveedores();
                    txt_IdProoveedorA.Clear();
                    txt_NombreProveedorA.Clear();
                    txt_CorreoA.Clear();
                    txt_TelefonoProveedorA.Clear();
                }
            }
            catch (Exception x)
            {

                MessageBox.Show($"Error al actualizar proveedor {x}");
            }
        }

    }
}
