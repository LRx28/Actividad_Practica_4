using Actividad_Practica_4.Model;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Actividad_Practica_4
{
    public partial class Clientes_Form : Form
    {
        private FrmClientes _context;
        public Clientes_Form()
        {
            InitializeComponent();
            _context = new FrmClientes();
            cargarClientes();

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

            var n = listaClientes.First();

            dgv_Clientes.DataSource = listaClientes;


        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Nombre.Text))
            {
                MessageBox.Show("El nombre esta vario o incorrecto.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_Correo.Text))
            {
                MessageBox.Show("El Correo esta vacio o incorrecto.");
                return;

            }

            if (string.IsNullOrWhiteSpace(txt_Telefono.Text))
            {
                MessageBox.Show("El Telefono esta vacio o incorrecto.");
                return;
            }


            if (string.IsNullOrWhiteSpace(txt_Direccion.Text))
            {
                MessageBox.Show("La direccion esta vacia o incorrecta");
                return;
            }

            Clientes nuevoCliente = new Clientes
            {
                NombreCompleto = txt_Nombre.Text,
                CorreoElectronico = txt_Correo.Text,
                Telefono = txt_Telefono.Text,
                Direccion = txt_Direccion.Text
            };

            _context.Clientes.Add(nuevoCliente);
            var resultado = _context.SaveChanges();
            if (resultado > 0)
            {
                MessageBox.Show("Cliente agregado correctamente.");
                cargarClientes();
                txt_Nombre.Clear();
                txt_Correo.Clear();
                txt_Telefono.Clear();
                txt_Direccion.Clear();
            }
            else
            {
                MessageBox.Show("Error al agregar el cliente.");
            }

            cargarClientes();



        }



        private void btn_Cargar_Click(object sender, EventArgs e)
        {
            cargarClientes();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ClienteID.Text))
            {
                MessageBox.Show("ingresa un ID de cliente válido.");
                return;

            }
            try
            {
                var clienteID = int.Parse(txt_ClienteID.Text);

                Clientes nuevoCliente = _context.Clientes.Find(clienteID);
                if (nuevoCliente == null)
                {
                    MessageBox.Show("Cliente no encontrado.");
                    return;
                }

                _context.Clientes.Remove(nuevoCliente);
                var resultado = _context.SaveChanges();
                if (resultado > 0)
                {
                    MessageBox.Show("Cliente eliminado correctamente.");
                    cargarClientes();
                    txt_ClienteID.Clear();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el cliente.");
                }
            }
            catch (Exception x)
            {

                MessageBox.Show($"Error al introduccir el id a eliminar.{x}");
            }
            
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_IdActualizado.Text))
            {
                MessageBox.Show("Debe introducir un ID valido.");
                return;
            }

            if (string.IsNullOrEmpty(txt_NombreActualizado.Text))
            {
                MessageBox.Show("Debe introducir un nombre valido.");
                return;
            }

            if (string.IsNullOrEmpty(txt_CorreoActualizado.Text))
            {
                MessageBox.Show("Debe introducir un Correo valido.");
                return;
            }

            if (string.IsNullOrEmpty(txt_Telefono_Actualizado.Text))
            {
                MessageBox.Show("Debe introducir un Telefono valido.");
                return;
            }

            if (string.IsNullOrEmpty(txt_DireccionActualizada.Text))
            {
                MessageBox.Show("Debe introducir una Direccion valida.");
                return;
            }

            try
            {
                var clienteID = int.Parse(txt_IdActualizado.Text);
                Clientes nuevoClientes = _context.Clientes.FirstOrDefault(q => q.ClienteID.Equals(clienteID));
                if (nuevoClientes == null)
                {
                    MessageBox.Show("Este ID de cliente no existe.");
                    return;

                }


                nuevoClientes.NombreCompleto = txt_NombreActualizado.Text;
                nuevoClientes.CorreoElectronico = txt_CorreoActualizado.Text;
                nuevoClientes.Telefono = txt_Telefono_Actualizado.Text;
                nuevoClientes.Direccion = txt_DireccionActualizada.Text;

                var resultado = _context.SaveChanges();
                if (resultado > 0)
                {
                    MessageBox.Show("Cliente actualizado correctamente.");
                }

                cargarClientes();
                txt_NombreActualizado.Clear();
                txt_CorreoActualizado.Clear();
                txt_Telefono_Actualizado.Clear();
                txt_DireccionActualizada.Clear();




            }
            catch (Exception x)
            {

                MessageBox.Show($"Debe de ingresar un ID valido{x}");
            }
          
        }
    }
}