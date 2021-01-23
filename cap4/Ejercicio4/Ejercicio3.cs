using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int alum = int.Parse(cantidad.Text);
            double promedio = 0;
            int i = 0;
            while(i <= alum)
            {
                double not = double.Parse(calificacion.Text);
                resultado.Clear();

                for (int j = 0; j <= alum; j++)
                {
                    
                    promedio = promedio + not;


                }
                resultado.AppendText("" + (promedio / alum));
                i++;
            }
        }

        private void Ejercicio3_Load(object sender, EventArgs e)
        {

        }
    }
}
