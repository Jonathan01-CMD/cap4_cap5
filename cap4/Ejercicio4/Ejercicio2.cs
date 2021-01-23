using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int potencia = int.Parse(numero.Text);
            int elevar = int.Parse(elevado.Text);
            int total = 1;
            int cont = 1;

            while(cont <= elevar )
            {
            total *= potencia;
            cont ++;
            }
            resultado.Text = total.ToString();
        }
    }
}
