namespace TrabajoPracticoFinalSegundo.UserControls
{
    partial class Barco
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
            this.pic_Barco = new System.Windows.Forms.PictureBox();
            this.canon1 = new TrabajoPracticoFinalSegundo.UserControls.Canon();
            this.canon2 = new TrabajoPracticoFinalSegundo.UserControls.Canon();
            this.canon3 = new TrabajoPracticoFinalSegundo.UserControls.Canon();
            this.canon4 = new TrabajoPracticoFinalSegundo.UserControls.Canon();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Barco)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Barco
            // 
            this.pic_Barco.BackColor = System.Drawing.Color.Transparent;
            this.pic_Barco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_Barco.Location = new System.Drawing.Point(0, 0);
            this.pic_Barco.Name = "pic_Barco";
            this.pic_Barco.Size = new System.Drawing.Size(364, 712);
            this.pic_Barco.TabIndex = 0;
            this.pic_Barco.TabStop = false;
            // 
            // canon1
            // 
            this.canon1.BackColor = System.Drawing.Color.Transparent;
            this.canon1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.canon1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.canon1.IMG = null;
            this.canon1.Location = new System.Drawing.Point(3, 220);
            this.canon1.Name = "canon1";
            this.canon1.Size = new System.Drawing.Size(170, 67);
            this.canon1.TabIndex = 1;
            // 
            // canon2
            // 
            this.canon2.BackColor = System.Drawing.Color.Transparent;
            this.canon2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.canon2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.canon2.IMG = null;
            this.canon2.Location = new System.Drawing.Point(194, 379);
            this.canon2.Name = "canon2";
            this.canon2.Size = new System.Drawing.Size(170, 67);
            this.canon2.TabIndex = 2;
            // 
            // canon3
            // 
            this.canon3.BackColor = System.Drawing.Color.Transparent;
            this.canon3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.canon3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.canon3.IMG = null;
            this.canon3.Location = new System.Drawing.Point(194, 220);
            this.canon3.Name = "canon3";
            this.canon3.Size = new System.Drawing.Size(170, 67);
            this.canon3.TabIndex = 3;
            // 
            // canon4
            // 
            this.canon4.BackColor = System.Drawing.Color.Transparent;
            this.canon4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.canon4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.canon4.IMG = null;
            this.canon4.Location = new System.Drawing.Point(0, 379);
            this.canon4.Name = "canon4";
            this.canon4.Size = new System.Drawing.Size(170, 67);
            this.canon4.TabIndex = 4;
            // 
            // Barco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.canon4);
            this.Controls.Add(this.canon3);
            this.Controls.Add(this.canon2);
            this.Controls.Add(this.canon1);
            this.Controls.Add(this.pic_Barco);
            this.Name = "Barco";
            this.Size = new System.Drawing.Size(364, 712);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Barco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pic_Barco;
        public Canon canon1;
        public Canon canon2;
        public Canon canon3;
        public Canon canon4;
    }
}
