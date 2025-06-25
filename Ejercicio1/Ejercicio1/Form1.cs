using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            //     // Este método se activa cada vez que el texto en la caja de texto cambia.
            //     // Para este problema, generalmente no necesitamos poner código aquí.
            //     // Lo dejo vacío por ahora.


        }

        private void lblNumero_Click(object sender, EventArgs e)
        {
            //     // Este método se activa si haces clic en la etiqueta.
            //     // Normalmente no se usa para la lógica de negocio.
            //     // Lo dejo vacío por ahora.

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            // 1. Limpiar los elementos previos de la lista
            // Asegúrate de que tu ListBox se llame 'lstTabla'
            lstTabla.Items.Clear();

            // 2. Obtener el número del TextBox
            // Asegúrate de que tu TextBox se llame 'txtNumero'
            // 3. Generar y mostrar la tabla de multiplicar
          

        }

        private void lstTabla_SelectedIndexChanged(object sender, EventArgs e)
        {

            //     // Este método se activa si el usuario selecciona un elemento en la ListBox.
            //     // No es necesario para la funcionalidad principal de la tabla de multiplicar.
            //     // Lo dejo vacío por ahora.

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //     // Este método se ejecuta cuando el formulario se carga por primera vez.
            //     // Puedes poner código de inicialización aquí si lo necesitas,
            //     // pero para este caso, no es esencial.
            //     // Lo dejo vacío por ahora.
        }
    }
}
