using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJercicio__2
{
    public partial class Form1 : Form
    {
        int tiempoTotal;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            int minutos = 0;
            int segundos = 0;

            if (int.TryParse(txtMinutos.Text, out minutos) && int.TryParse(txtSegundos.Text, out segundos))
            {
                tiempoTotal = (minutos * 60) + segundos;

                if (tiempoTotal > 0)
                {
                    timer1.Start();
                    ActualizarLabel();
                }
                else
                {
                    MessageBox.Show("Ingresa un tiempo mayor a 0.");
                }
            }
            else
            {
                MessageBox.Show("Por favor ingresa solo números válidos.");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tiempoTotal > 0)
            {
                tiempoTotal--;
                ActualizarLabel();
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("¡Tiempo finalizado!");
            }
        }

      
        private void ActualizarLabel()
        {
            int minutos = tiempoTotal / 60;
            int segundos = tiempoTotal % 60;
            lblTiempoRestante.Text = $"{minutos:D2}:{segundos:D2}";
        }
    }
}
