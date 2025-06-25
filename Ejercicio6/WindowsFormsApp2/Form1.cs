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
            // Validar que no esté vacío
            if (string.IsNullOrWhiteSpace(mtxtNumero.Text))
            {
                MessageBox.Show("Por favor, ingresa un número.", "Advertencia");
                return;
            }

            // Convertir el texto a número
            int numero;
            bool esNumero = int.TryParse(mtxtNumero.Text, out numero);

            if (!esNumero || numero <= 0)
            {
                MessageBox.Show("Debes ingresar un número entero positivo.", "Error");
                return;
            }

            // Calcular suma de divisores propios
            int suma = 0;
            for (int i = 1; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    suma += i;
                }
            }

            // Evaluar si es perfecto
            if (suma == numero)
            {
                MessageBox.Show("El número ES perfecto.", "Resultado");
            }
            else
            {
                MessageBox.Show("El número NO es perfecto.", "Resultado");
            }
        }
    }
    }
}
