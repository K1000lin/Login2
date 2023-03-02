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
    public partial class Contactos : Form
    {
        string nombre = "";
        string ciudad = "";
        string telefono = "";
        string correo = "";
        string valor = "";
        int posicion = 0;
        int contador = 0;
        Boolean actualizar = false;
        public Contactos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nombre = textNombre.Text;
            ciudad = textCiudad.Text;
            telefono = textTelefono.Text;
            correo = textCorreo.Text;

            listBoxContactos.Items.Add(nombre+' '+ciudad+' '+telefono+' '+correo);
            textNombre.Text = "";
            textCiudad.Text = "";
            textTelefono.Text = "";
            textCorreo.Text = "";
            textNombre.Focus();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int nposicion = 0;
            nposicion = listBoxContactos.SelectedIndex;
            listBoxContactos.Items.RemoveAt(nposicion);
        }

        private void listBoxContactos_SelectedIndexChanged(object sender, EventArgs e)
        {
            valor = "";
            valor = listBoxContactos.GetItemText(listBoxContactos.SelectedItem);
            posicion = listBoxContactos.SelectedIndex;

            if (actualizar)
            {

            }
            else{
                modificoCampos(valor);
            }
        }

        private void modificoCampos(String valor) { 
        
               if (valor.Equals(""))
                {
                
                }
               else {
                    string[] subs;
                    subs = valor.Split(' ');
                    nombre = subs[0];
                    ciudad = subs[1];
                    telefono = subs[2];
                    correo = subs[3];

                    textNombre.Text = nombre;
                    textCiudad.Text = ciudad;
                    textTelefono.Text = telefono;
                    textCorreo.Text = correo;
                }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizar = true;
            int nposicion = 0;
            string valor2 = "";
            nombre = textNombre.Text;
            ciudad = textCiudad.Text;
            telefono = textTelefono.Text;
            correo = textCorreo.Text;
            valor2 = nombre + ' ' + ciudad + ' ' + telefono + ' ' + correo;
            nposicion = listBoxContactos.SelectedIndex;
            listBoxContactos.Items.RemoveAt(nposicion);
            listBoxContactos.Items.Insert(nposicion, valor2);
            actualizar = false;
        }

        private void listBoxContactos_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}