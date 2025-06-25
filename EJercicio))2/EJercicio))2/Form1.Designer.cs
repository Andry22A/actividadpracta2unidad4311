namespace EJercicio__2
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
            this.txtMinutos = new System.Windows.Forms.TextBox();
            this.txtSegundos = new System.Windows.Forms.TextBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.lblTiempoRestante = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Minutos = new System.Windows.Forms.Label();
            this.Segundos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMinutos
            // 
            this.txtMinutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinutos.Location = new System.Drawing.Point(213, 84);
            this.txtMinutos.Name = "txtMinutos";
            this.txtMinutos.Size = new System.Drawing.Size(136, 27);
            this.txtMinutos.TabIndex = 0;
            // 
            // txtSegundos
            // 
            this.txtSegundos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtSegundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSegundos.Location = new System.Drawing.Point(213, 147);
            this.txtSegundos.Name = "txtSegundos";
            this.txtSegundos.Size = new System.Drawing.Size(136, 27);
            this.txtSegundos.TabIndex = 1;
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.Fuchsia;
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(224, 192);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(105, 47);
            this.btnIniciar.TabIndex = 2;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // lblTiempoRestante
            // 
            this.lblTiempoRestante.AutoSize = true;
            this.lblTiempoRestante.BackColor = System.Drawing.Color.White;
            this.lblTiempoRestante.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoRestante.Location = new System.Drawing.Point(244, 262);
            this.lblTiempoRestante.Name = "lblTiempoRestante";
            this.lblTiempoRestante.Size = new System.Drawing.Size(65, 22);
            this.lblTiempoRestante.TabIndex = 3;
            this.lblTiempoRestante.Text = "00 : 00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // Minutos
            // 
            this.Minutos.AutoSize = true;
            this.Minutos.BackColor = System.Drawing.Color.White;
            this.Minutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minutos.Location = new System.Drawing.Point(136, 84);
            this.Minutos.Name = "Minutos";
            this.Minutos.Size = new System.Drawing.Size(65, 20);
            this.Minutos.TabIndex = 4;
            this.Minutos.Text = "Minutos";
            // 
            // Segundos
            // 
            this.Segundos.AutoSize = true;
            this.Segundos.BackColor = System.Drawing.Color.White;
            this.Segundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Segundos.Location = new System.Drawing.Point(119, 150);
            this.Segundos.Name = "Segundos";
            this.Segundos.Size = new System.Drawing.Size(82, 20);
            this.Segundos.TabIndex = 5;
            this.Segundos.Text = "Segundos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 377);
            this.Controls.Add(this.Segundos);
            this.Controls.Add(this.Minutos);
            this.Controls.Add(this.lblTiempoRestante);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.txtSegundos);
            this.Controls.Add(this.txtMinutos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMinutos;
        private System.Windows.Forms.TextBox txtSegundos;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label lblTiempoRestante;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Minutos;
        private System.Windows.Forms.Label Segundos;
    }
}

