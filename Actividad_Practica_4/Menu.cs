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
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
        }

        

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void categoriaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Clientes_Form frm = new Clientes_Form();
            frm.Show();
        }

        private void categoriaToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form3 frm = new form3();
            frm.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 frm = new Form6();
            frm.Show();
        }
    }
}
