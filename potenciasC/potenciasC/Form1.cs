using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace potenciasC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valor, potencia, resultado;

            valor = Convert.ToDouble(textBox1.Text);
            potencia = Convert.ToDouble(textBox2.Text);

            resultado = Math.Pow(valor, potencia);

            label3.Text = resultado.ToString();
        }
    }
}
