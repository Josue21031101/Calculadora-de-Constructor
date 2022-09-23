using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_de_Constructor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Suma s = new Suma(double.Parse(n1.Text)
                , double.Parse(n2.Text));

            n3.Text = s.sumar().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Division s = new Division(double.Parse(n1.Text)
               , double.Parse(n2.Text));

            n3.Text = s.Dividir().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Resta s = new Resta(double.Parse(n1.Text)
               , double.Parse(n2.Text));

            n3.Text = s.Restar().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Multiplicar s = new Multiplicar(double.Parse(n1.Text)
               , double.Parse(n2.Text));

            n3.Text = s.multiplicar().ToString();
        }
    }
}
