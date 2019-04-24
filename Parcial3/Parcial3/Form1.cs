using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario;
            string clave;

            usuario = txtUsuario.Text;
            clave = txtClave.Text;

            if (usuario.Equals("user") && clave.Equals("password")) 
            {
                Form2 obj = new Form2();
                obj.Show();

                this.Hide();
            }
            else 
            {
                MessageBox.Show("Intente otra vez");
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
        }
    }
}
