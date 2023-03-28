using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ptriangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtLadoA_Validated(object sender, EventArgs e)
        { double ladoA;

            if (!double.TryParse(txtLadoA.Text, out ladoA))
                _ = MessageBox.Show("Lado A precisa ser um número");
            //= txtLadoA.Focus();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtLadoA.Clear();
            txtLadoB.Clear();
            txtLadoC.Clear();
            txtTipoTri.Clear();
        }

        private void txtLadoB_Validated(object sender, EventArgs e)
        {
            double ladoB;
            if (!double.TryParse(txtLadoB.Text, out ladoB))
                _ = MessageBox.Show("Lado B precisa ser um número");
             //= txtLadoB.Focus();

        }

        private void txtLadoC_TextChanged(object sender, EventArgs e)
        {
            double ladoC;
            if (!double.TryParse(txtLadoC.Text, out ladoC))
                _ = MessageBox.Show("Lado C precisa ser um número");
            //_ = txtLadoA.Focus();
        }

        private void btnForm_Tri_Click(object sender, EventArgs e)
        {
            double numA, numB, numC, dif1, dif2, dif3;
            numA = double.Parse(txtLadoA.Text);
            numB = double.Parse(txtLadoB.Text);
            numC = double.Parse(txtLadoC.Text);
            dif1 = Math.Abs(numA - numB);
            dif2 = Math.Abs(numA - numC);
            dif3 = Math.Abs(numB - numC);
            if(numA < numB + numC) && (numB < numA + numC) && (numC < numA + numB)
                    // tentei de tudo, não consegui. 


             
        }   
    }

