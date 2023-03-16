using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close(); // Só um Close(); ja fecha. 
        }

        private void button1_Click(object sender, EventArgs e)
        {/* Aqui que surgiu a maior parte das dúvidas, não consegui fazer funcionar com nomes diferentes dos componentes. 
         Note que o TryParse faz uso do (out var valor), então o resultado direto da execução dele é um bool e
         não o valor convertido em sí. Este valor pode ser extraído da variável definida no out.
         */
            double raio; // Criando uma variável para receber o valor da entrada, caso passe pelo try parse. 
            if (!double.TryParse(textBox1.Text, out raio))  // esse .Text que obtém o texto contido no textBox1 (Altura)
                                                            // O ponto de exclamação, indica que o If executará o código caso o valor do bool seja falso. 
            {
                MessageBox.Show("Raio inválido");     // MessageBox, é como chamamos a caixa de avisos e Show o apresenta.
                textBox1.Focus(); // o Focus deixa o usuário focado em acertar o tipo de dado que deve ser colocado.
            }

            else if (raio <= 0)
            {
                MessageBox.Show("Raio tem que ser maior que 0");
                textBox1.Focus();
            }
            double altura; // Mesma ideia, declarar uma variável para receber o dado, ja convertido pelo tryparse. 
            if (!double.TryParse(textBox2.Text, out altura))
            {
                MessageBox.Show("Altura Inválida");
                textBox2.Focus();
            }

            else if (altura <= 0)
            {
                MessageBox.Show("Altura precisa ser maior que 0");
                textBox2.Focus();
            }

           double volume;
            volume = Math.PI * Math.Pow(raio, 2) * altura; // Aqui usei o math.Pi e o math.Pow( variavel, valor do exmpoente)
            textBox3.Text = volume.ToString("N2"); // .ToString converte o resultado double para string novamente. 

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
