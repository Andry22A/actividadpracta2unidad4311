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

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            int minutos, segundos;

            // Validar y convertir entradas
            if (int.TryParse(txtMinutos.Text, out minutos) && int.TryParse(txtSegundos.Text, out segundos))
            {
                tiempoRestante = (minutos * 60) + segundos;

                if (tiempoRestante > 0)
                {
                    timer1.Start(); // Inicia el temporizador
                    ActualizarEtiquetaTiempo(); // Muestra el tiempo actual
                }
                else
                {
                    MessageBox.Show("Ingrese un tiempo mayor a 0.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese valores válidos para minutos y segundos.");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tiempoRestante > 0)
            {
                tiempoRestante--;
                ActualizarEtiquetaTiempo();
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("¡Tiempo agotado!");
            }
        }

      
            {
          
           
        }
    }
    }
}
