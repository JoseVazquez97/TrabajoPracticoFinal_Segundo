namespace TrabajoPracticoFinalSegundo.UserControls
{
    partial class Canon
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
            this.p_Box = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.p_Box)).BeginInit();
            this.SuspendLayout();
            // 
            // p_Box
            // 
            this.p_Box.BackColor = System.Drawing.Color.Transparent;
            this.p_Box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.p_Box.InitialImage = null;
            this.p_Box.Location = new System.Drawing.Point(0, 0);
            this.p_Box.Name = "p_Box";
            this.p_Box.Size = new System.Drawing.Size(170, 67);
            this.p_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p_Box.TabIndex = 0;
            this.p_Box.TabStop = false;
            // 
            // Canon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.p_Box);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Canon";
            this.Size = new System.Drawing.Size(170, 67);
            ((System.ComponentModel.ISupportInitialize)(this.p_Box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox p_Box;
    }
}
