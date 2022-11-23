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
            this.lbl_Muni = new System.Windows.Forms.Label();
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
            this.p_Box.Size = new System.Drawing.Size(129, 61);
            this.p_Box.TabIndex = 0;
            this.p_Box.TabStop = false;
            // 
            // lbl_Muni
            // 
            this.lbl_Muni.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Muni.Font = new System.Drawing.Font("BlackPearl", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Muni.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Muni.Location = new System.Drawing.Point(51, 28);
            this.lbl_Muni.Name = "lbl_Muni";
            this.lbl_Muni.Size = new System.Drawing.Size(21, 29);
            this.lbl_Muni.TabIndex = 1;
            this.lbl_Muni.Text = "1";
            this.lbl_Muni.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Muni.Click += new System.EventHandler(this.lbl_Muni_Click);
            // 
            // Canon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.lbl_Muni);
            this.Controls.Add(this.p_Box);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Canon";
            this.Size = new System.Drawing.Size(129, 61);
            ((System.ComponentModel.ISupportInitialize)(this.p_Box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox p_Box;
        private Label lbl_Muni;
    }
}
