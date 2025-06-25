using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
        {
            // Verificar si el campo está vacío
            if (string.IsNullOrWhiteSpace(mtxtNumero.Text))
            {
                MessageBox.Show("Por favor, ingresa un número.", "Advertencia");
                return;
            }

            // Convertir el texto del MaskedTextBox a número
            int numero;
            bool esNumero = int.TryParse(mtxtNumero.Text, out numero);

            if (!esNumero || numero <= 1)
            {
                MessageBox.Show("Ingresa un número válido mayor que 1.", "Error");
                return;
            }

            // Verificar si el número es primo
            bool esPrimo = true;
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    esPrimo = false;
                    break;
                }
            }

            // Mostrar resultado
            if (esPrimo)
            {
                MessageBox.Show("El número ES primo.", "Resultado");
            }
            else
            {
                MessageBox.Show("El número NO es primo.", "Resultado");
            }
        }
    }
    }
}
