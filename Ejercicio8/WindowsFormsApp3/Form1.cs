﻿using System;
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
        private void btnContar_Click(object sender, EventArgs e)
        
        {
            string oracion = txtOracion.Text.Trim();

            // Divide por espacios eliminando vacíos
            string[] palabras = oracion.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Muestra la cantidad de palabras
            lblResultado.Text = "Total de palabras: " + palabras.Length;
        
    }
    }
}
