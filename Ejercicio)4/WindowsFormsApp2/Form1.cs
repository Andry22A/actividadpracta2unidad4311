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
            string palabra = txtPalabra.Text.ToLower();
            palabra = palabra.Replace(" ", "");
            char[] arreglo = palabra.ToCharArray();
            Array.Reverse(arreglo);
            string palabraInvertida = new string(arreglo);

            if (palabra == palabraInvertida)
            {
                MessageBox.Show("La palabra ES palíndroma.", "Resultado");
            }
            else
            {
                MessageBox.Show("La palabra NO es palíndroma.", "Resultado");
            }
        }

        private void txtPalabra_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
