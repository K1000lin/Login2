using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace Login2
{
    public partial class AgendaMovil : Form
    {
        string nombre = "";
        string telefono = "" ;
        string etiqueta = "";
        public AgendaMovil()
        {
          
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            nombre = txtNombre.Text;
            telefono = txtTelefono.Text;
            etiqueta = CBoxEtiqueta.Text;
            MessageBox.Show("Contacto: \n"+"Nombre: " + nombre + "\nNúmero : " + telefono + "\nEiqueta: " + etiqueta);
            txtNombre.Text = "";
            txtTelefono.Text = "";
            CBoxEtiqueta.Text = "";
            txtNombre.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
