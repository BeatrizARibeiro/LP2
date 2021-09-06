using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVolume
{
    public partial class Form1 : Form
    {
        Double raio;
        Double altura;

        public Form1()
        {
            InitializeComponent();
        }


        private void txtRaio_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtRaio.Text, out raio))
            {
                MessageBox.Show("O valor do raio é inválido!");
                txtRaio.Focus();
            }
        }



        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtVolume.Text = (Math.PI * Math.Pow(Convert.ToDouble(txtRaio.Text), 2) * Convert.ToDouble(txtAltura.Text)).ToString("N2");
        }

        private void txtAltura_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtAltura.Text, out altura))
            {
                MessageBox.Show("O valor da altura é inválido!");
                txtAltura.Focus();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtRaio.Text = "";
            txtAltura.Text = "";
            txtVolume.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
