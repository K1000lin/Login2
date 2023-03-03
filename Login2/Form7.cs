using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Login2
{
    public partial class Notas : Form
    {
        public Notas()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "text files (*.txt) | *.txt";
            if (save.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(save.FileName, RichTextBoxStreamType.PlainText);
            }
            richTextBox1.Text = "";
            richTextBox1.Focus();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "All files (*.*) | *.*";
            if(open.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(open.FileName);
            }
        }
    }
}
