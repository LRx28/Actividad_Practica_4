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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        public object ProductoID { get; internal set; }
        public object NombreProducto { get; internal set; }
        public object Precio { get; internal set; }
        public object Stock { get; internal set; }
        public object CategoriaID { get; internal set; }
        public object ProveedorID { get; internal set; }
        public string Descripcion { get; internal set; }
    }
}
