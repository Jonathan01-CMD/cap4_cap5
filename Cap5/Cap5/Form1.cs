using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cap5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cadena1 ejecutar = new cadena1();
            ejecutar.Show();
        }

        private void ejercicio1_Click(object sender, EventArgs e)
        {
            Factorial ejecutar = new Factorial();
            ejecutar.Show();
        }

        private void factorial_Click(object sender, EventArgs e)
        {

        }
    }
}
