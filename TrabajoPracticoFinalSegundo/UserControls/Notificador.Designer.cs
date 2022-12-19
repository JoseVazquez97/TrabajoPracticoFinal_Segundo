namespace TrabajoPracticoFinalSegundo.UserControls
{
    partial class Notificador
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_texto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_texto
            // 
            this.lbl_texto.BackColor = System.Drawing.Color.Transparent;
            this.lbl_texto.Font = new System.Drawing.Font("BlackPearl", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_texto.ForeColor = System.Drawing.Color.Black;
            this.lbl_texto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_texto.Location = new System.Drawing.Point(0, 0);
            this.lbl_texto.Name = "lbl_texto";
            this.lbl_texto.Size = new System.Drawing.Size(220, 83);
            this.lbl_texto.TabIndex = 1;
            this.lbl_texto.Text = "ORDENES CAPITAN!!!";
            this.lbl_texto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Notificador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lbl_texto);
            this.Name = "Notificador";
            this.Size = new System.Drawing.Size(220, 83);
            this.ResumeLayout(false);

        }

        #endregion

        private Label lbl_texto;
    }
}
