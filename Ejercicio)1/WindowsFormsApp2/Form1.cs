using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.LinkLabel;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
      
        {
            lstTabla.Items.Clear(); // Limpiar lista antes de agregar nuevos valores

            if (int.TryParse(txtNumero.Text, out int numero))
            {
                for (int i = 1; i <= 10; i++)
                {
                    int resultado = numero * i;
                    lstTabla.Items.Add($"{numero} x {i} = {resultado}");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
            }
        }
    }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
