using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
         // en segundos
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000; // 1 segundo
             //  Asocia el evento
        }
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            // Código para iniciar el temporizador
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int minutos = 0; 
            int segundos = 0; 

            int.TryParse(txtMinutos.Text, out minutos); 
            int.TryParse(txtSegundos.Text, out segundos);

         
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Elimínalo si está vacío

        }

        private void lblTiempo_TextChanged(object sender, EventArgs e)
        {
            // Elimínalo si no haces nada al hacer clic en la etiqueta
        }

        private void lblMinutos_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click_1(object sender, EventArgs e)
        {
            // Código para iniciar el temporizador
        }

    
        
    }
}
