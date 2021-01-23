using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class Ejercicio_1 : Form
    {
        public Ejercicio_1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int a = int.Parse(multiplicador.Text);
            int b = int.Parse(multiplicado.Text);
            int resultado;

            for(int i = 1; i <= b; i++)
            {
                resultado = a * i;
                tabla.AppendText(i + "x" + a + "=" + resultado + "\t");
            }
        }
    }
}
