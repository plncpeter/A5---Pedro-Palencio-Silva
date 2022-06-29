using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            // Declarando as variaveis para armazenar os valores e converter os strings para double 
            double baser = 0;
            double altura = 0;
            double area = 0;
            if (txbN1.Text != "" && txbN2.Text != "")
            {
                baser = double.Parse(txbN1.Text);
                altura = double.Parse(txbN2.Text);
            }


            // Fazer a operação para calcular a area:
           area = (baser * altura) /2;

            // Mostrar o valor no lblResultado:
            lblResultado.Text = area.ToString();
        }

        private void lblTitulo3_Click(object sender, EventArgs e)
        {

        }
    }
}
