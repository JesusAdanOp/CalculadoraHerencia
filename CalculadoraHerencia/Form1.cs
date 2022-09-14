using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraHerencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void BtnSuma_Click(object sender, EventArgs e)
        {
            Suma suma = new Suma();
            txtresultado.Text = suma.operar(double.Parse(txtv1.Text),double.Parse(txtv2.Text)).ToString();
        }
        
        private void BtnResta_Click(object sender, EventArgs e)
        {
            Resta resta = new Resta();
            txtresultado.Text = resta.operar(double.Parse(txtv1.Text), double.Parse(txtv2.Text)).ToString();

        }
        
        private void BtnMult_Click(object sender, EventArgs e)
        {
            Multiplicar multi = new Multiplicar();
            txtresultado.Text = multi.operar(double.Parse(txtv1.Text), double.Parse(txtv2.Text)).ToString();

        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            Dividir div = new Dividir();
            txtresultado.Text = div.operar(double.Parse(txtv1.Text), double.Parse(txtv2.Text)).ToString();

        }

       
    }
}
