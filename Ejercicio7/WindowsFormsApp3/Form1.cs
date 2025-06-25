using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private bool EsPrimo(int numero)
        {
            if (numero < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                    return false;
            }
            return true;
        }

       

        private void btnBuscar_Click(object sender, EventArgs e)
        {
 lstPrimos.Items.Clear();

            // Validación de entradas
            if (!int.TryParse(txtInicio.Text, out int inicio) ||
                !int.TryParse(txtFin.Text, out int fin))
            {
                MessageBox.Show("Por favor ingresa números válidos.");
                return;
            }

            if (inicio > fin)
            {
                MessageBox.Show("El número de inicio debe ser menor o igual que el de fin.");
                return;
            }

            // Búsqueda de primos
            for (int i = inicio; i <= fin; i++)
            {
                if (EsPrimo(i))
                {
                    lstPrimos.Items.Add(i);
                }
            }
        }
    }
}
