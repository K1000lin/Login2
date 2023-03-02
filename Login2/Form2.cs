using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Ventana Calculadora
            Calculadora frm3 = new Calculadora();
            frm3.MdiParent = this;
            frm3.Show();

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Ventana Contactos
            Contactos frm4 = new Contactos();
            frm4.MdiParent = this;
            frm4.Show();
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Ventana Agenda Móvil
            AgendaMovil frm5 = new AgendaMovil();
            frm5.MdiParent = this;
            frm5.Show();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Ventana Hora y Fecha
            HorayFecha frm6 = new HorayFecha();
            frm6.MdiParent = this;
            frm6.Show();
        }
    }
}
