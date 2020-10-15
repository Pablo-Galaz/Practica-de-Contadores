namespace Practica_de_Contadores
{
    partial class Form
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
            this.NumAnterior = new System.Windows.Forms.Button();
            this.NumSiguiente = new System.Windows.Forms.Button();
            this.Numeros = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NumAnterior
            // 
            this.NumAnterior.BackColor = System.Drawing.Color.Gold;
            this.NumAnterior.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumAnterior.Location = new System.Drawing.Point(31, 112);
            this.NumAnterior.Name = "NumAnterior";
            this.NumAnterior.Size = new System.Drawing.Size(114, 55);
            this.NumAnterior.TabIndex = 0;
            this.NumAnterior.Text = "Primer Boton";
            this.NumAnterior.UseVisualStyleBackColor = false;
            this.NumAnterior.Click += new System.EventHandler(this.NumAnterior_Click);
            // 
            // NumSiguiente
            // 
            this.NumSiguiente.BackColor = System.Drawing.Color.Gold;
            this.NumSiguiente.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumSiguiente.Location = new System.Drawing.Point(231, 112);
            this.NumSiguiente.Name = "NumSiguiente";
            this.NumSiguiente.Size = new System.Drawing.Size(118, 55);
            this.NumSiguiente.TabIndex = 1;
            this.NumSiguiente.Text = "Segundo Boton";
            this.NumSiguiente.UseVisualStyleBackColor = false;
            this.NumSiguiente.Click += new System.EventHandler(this.NumSiguiente_Click);
            // 
            // Numeros
            // 
            this.Numeros.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numeros.Location = new System.Drawing.Point(126, 32);
            this.Numeros.Multiline = true;
            this.Numeros.Name = "Numeros";
            this.Numeros.Size = new System.Drawing.Size(132, 38);
            this.Numeros.TabIndex = 2;
            this.Numeros.Text = "1";
            this.Numeros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(381, 196);
            this.Controls.Add(this.Numeros);
            this.Controls.Add(this.NumSiguiente);
            this.Controls.Add(this.NumAnterior);
            this.Name = "Form";
            this.Text = "Practica Contadores";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NumAnterior;
        private System.Windows.Forms.Button NumSiguiente;
        private System.Windows.Forms.TextBox Numeros;
    }
}

