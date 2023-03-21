using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pimc
{
    public partial class Form1 : Form
    {
        double var_peso = 0;
        double var_alt = 0;
        double IMC = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
           

            IMC = Math.Round(var_peso / (var_alt * var_alt));
            txtImc.Text = IMC.ToString();
        }

        private void BtnFecha_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtPeso_Leave(object sender, EventArgs e)
        {
       
        }

        private void TxtPeso_Validating(object sender, CancelEventArgs e)
        {
            if (double.TryParse(txtPeso.Text, out var_peso))
            {
              if(double.Parse(txtPeso.Text) < 0)
                {
                    MessageBox.Show("Peso deve ser maior que zero");
                    txtPeso.Focus();
                }
            }
            else
            {
                    MessageBox.Show("Peso deve ser um número");
                txtPeso.Focus();
            }

        }

        private void TxtAltura_Validating(object sender, CancelEventArgs e)
        {
            if (double.TryParse(txtAltura.Text, out var_alt))
            {
                if (double.Parse(txtAltura.Text) < 0)
                 {
                    MessageBox.Show("Altura deve ser maior que zero");
                    txtPeso.Focus();
                 }
            }
            else
            {
               MessageBox.Show("Altura deve ser um número");
                txtPeso.Focus();
            }
        }
    }
}
