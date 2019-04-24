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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cantidad, porcentaje, porcientoTotal, Total;
            cantidad = int.Parse(textBox1.Text);
            porcentaje = int.Parse(textBox2.Text);

            porcientoTotal = (cantidad * porcentaje) / 100;

            textBox3.Text = porcientoTotal.ToString();
            

            if (radioButton1.Checked == true) 
            {
                Total = cantidad - porcientoTotal;
                textBox4.Text = Total.ToString();
            }
            if (radioButton2.Checked == true)
            {
                Total = cantidad + porcientoTotal;
                textBox4.Text = Total.ToString();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            int cantidad, porcentaje, porcientoTotal, Total;
            cantidad = int.Parse(textBox1.Text);
            porcentaje = int.Parse(textBox2.Text);

            porcientoTotal = (cantidad * porcentaje) / 100;

            if (radioButton1.Checked == true)
            {
                Total = cantidad - porcientoTotal;
                textBox4.Text = Total.ToString();
            }
            if (radioButton2.Checked == true)
            {
                Total = cantidad + porcientoTotal;
                textBox4.Text = Total.ToString();
            }
        }
    }
}
