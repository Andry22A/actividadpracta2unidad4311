using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbEntrada.Items.AddRange(new string[] { "Metro", "Centímetro", "Pulgada" });
            cmbSalida.Items.AddRange(new string[] { "Metro", "Centímetro", "Pulgada" });

            cmbEntrada.SelectedIndex = 0;
            cmbSalida.SelectedIndex = 1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtValor.Text, out double valorEntrada))
            {
                MessageBox.Show("Por favor, ingresa un número válido.");
                return;
            }

            string unidadEntrada = cmbEntrada.SelectedItem.ToString();
            string unidadSalida = cmbSalida.SelectedItem.ToString();

            double valorEnMetros = valorEntrada;

            switch (unidadEntrada)
            {
                case "Metro":
                    break;
                case "Centímetro":
                    valorEnMetros = valorEntrada / 100;
                    break;
                case "Pulgada":
                    valorEnMetros = valorEntrada * 0.0254;
                    break;
            }

            double resultado = valorEnMetros;

            switch (unidadSalida)
            {
                case "Metro":
                    break;
                case "Centímetro":
                    resultado = valorEnMetros * 100;
                    break;
                case "Pulgada":
                    resultado = valorEnMetros / 0.0254;
                    break;
            }

            lblResultado.Text = $"Resultado: {resultado:F2} {unidadSalida}";
        }
    }
}
