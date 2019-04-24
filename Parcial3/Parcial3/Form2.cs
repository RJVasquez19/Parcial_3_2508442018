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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void datosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 obj = new Form3();
            obj.MdiParent = this;
            obj.Show();

        }

        private void operacionesMatematicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 obj = new Form4();
            obj.MdiParent = this;
            obj.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
