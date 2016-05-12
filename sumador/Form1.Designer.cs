namespace sumador
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
            this.textoNumero1 = new System.Windows.Forms.TextBox();
            this.textoNumero2 = new System.Windows.Forms.TextBox();
            this.botonCalcularSuma = new System.Windows.Forms.Button();
            this.textoResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textoNumero1
            // 
            this.textoNumero1.Location = new System.Drawing.Point(49, 60);
            this.textoNumero1.Name = "textoNumero1";
            this.textoNumero1.Size = new System.Drawing.Size(100, 20);
            this.textoNumero1.TabIndex = 0;
            // 
            // textoNumero2
            // 
            this.textoNumero2.Location = new System.Drawing.Point(49, 100);
            this.textoNumero2.Name = "textoNumero2";
            this.textoNumero2.Size = new System.Drawing.Size(100, 20);
            this.textoNumero2.TabIndex = 1;
            // 
            // botonCalcularSuma
            // 
            this.botonCalcularSuma.Location = new System.Drawing.Point(49, 143);
            this.botonCalcularSuma.Name = "botonCalcularSuma";
            this.botonCalcularSuma.Size = new System.Drawing.Size(100, 23);
            this.botonCalcularSuma.TabIndex = 2;
            this.botonCalcularSuma.Text = "Calcular Suma";
            this.botonCalcularSuma.UseVisualStyleBackColor = true;
            this.botonCalcularSuma.Click += new System.EventHandler(this.botonCalcularSuma_Click);
            // 
            // textoResultado
            // 
            this.textoResultado.Location = new System.Drawing.Point(49, 188);
            this.textoResultado.Name = "textoResultado";
            this.textoResultado.Size = new System.Drawing.Size(100, 20);
            this.textoResultado.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.textoResultado);
            this.Controls.Add(this.botonCalcularSuma);
            this.Controls.Add(this.textoNumero2);
            this.Controls.Add(this.textoNumero1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textoNumero1;
        private System.Windows.Forms.TextBox textoNumero2;
        private System.Windows.Forms.Button botonCalcularSuma;
        private System.Windows.Forms.TextBox textoResultado;
    }
}

