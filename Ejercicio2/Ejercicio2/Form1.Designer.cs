namespace Ejercicio2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblMinutos = new System.Windows.Forms.Label();
            this.txtMinutos = new System.Windows.Forms.TextBox();
            this.lblSegundos = new System.Windows.Forms.Label();
            this.txtSegundos = new System.Windows.Forms.TextBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblMinutos
            // 
            this.lblMinutos.AutoSize = true;
            this.lblMinutos.Location = new System.Drawing.Point(367, 70);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(44, 13);
            this.lblMinutos.TabIndex = 0;
            this.lblMinutos.Text = "Minutos";
            this.lblMinutos.TextChanged += new System.EventHandler(this.lblTiempo_TextChanged);
            this.lblMinutos.Click += new System.EventHandler(this.lblMinutos_Click);
            // 
            // txtMinutos
            // 
            this.txtMinutos.Location = new System.Drawing.Point(364, 112);
            this.txtMinutos.Name = "txtMinutos";
            this.txtMinutos.Size = new System.Drawing.Size(79, 20);
            this.txtMinutos.TabIndex = 1;
            this.txtMinutos.TextChanged += new System.EventHandler(this.lblTiempo_TextChanged);
            // 
            // lblSegundos
            // 
            this.lblSegundos.AutoSize = true;
            this.lblSegundos.Location = new System.Drawing.Point(371, 164);
            this.lblSegundos.Name = "lblSegundos";
            this.lblSegundos.Size = new System.Drawing.Size(55, 13);
            this.lblSegundos.TabIndex = 2;
            this.lblSegundos.Text = "Segundos";
            this.lblSegundos.TextChanged += new System.EventHandler(this.lblTiempo_TextChanged);
            this.lblSegundos.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSegundos
            // 
            this.txtSegundos.Location = new System.Drawing.Point(372, 200);
            this.txtSegundos.Name = "txtSegundos";
            this.txtSegundos.Size = new System.Drawing.Size(70, 20);
            this.txtSegundos.TabIndex = 3;
            this.txtSegundos.TextChanged += new System.EventHandler(this.lblTiempo_TextChanged);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(374, 251);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(67, 36);
            this.btnIniciar.TabIndex = 4;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.TextChanged += new System.EventHandler(this.lblTiempo_TextChanged);
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click_1);
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(379, 322);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(34, 13);
            this.lblTiempo.TabIndex = 5;
            this.lblTiempo.Text = "00:00";
            this.lblTiempo.TextChanged += new System.EventHandler(this.lblTiempo_TextChanged);
            this.lblTiempo.Click += new System.EventHandler(this.lblTiempo_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.txtSegundos);
            this.Controls.Add(this.lblSegundos);
            this.Controls.Add(this.txtMinutos);
            this.Controls.Add(this.lblMinutos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMinutos;
        private System.Windows.Forms.TextBox txtMinutos;
        private System.Windows.Forms.Label lblSegundos;
        private System.Windows.Forms.TextBox txtSegundos;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Timer timer1;
    }
}

