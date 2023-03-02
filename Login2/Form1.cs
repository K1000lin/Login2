namespace Login2
{
    public partial class Form1 : Form
    {
        int contador = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string usuario = textUsuario.Text;
            string clave = textClave.Text;
            if (usuario == "Camilo" && clave == "1234")
            {

                Form2 frm = new Form2();
                frm.Show();
                this.Hide();
            }
            else
            {
                if (contador > 3)
                {
                    MessageBox.Show("Número de intentos excedido");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El usuario o contraseña no son correctas", "Mensaje de Programa");
                    textUsuario.Text = "";
                    textClave.Text = "";
                    textUsuario.Focus();
                }
                contador++;
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}