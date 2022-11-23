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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
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
            this.pic_Barco.Location = new System.Drawing.Point(32, 0);
            this.pic_Barco.Name = "pic_Barco";
            this.pic_Barco.Size = new System.Drawing.Size(303, 607);
            this.pic_Barco.TabIndex = 0;
            this.pic_Barco.TabStop = false;
            this.pic_Barco.Click += new System.EventHandler(this.pic_Barco_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(32, 586);
            this.progressBar1.MaximumSize = new System.Drawing.Size(300, 25);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(300, 25);
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Value = 100;
            // 
            // canon1
            // 
            this.canon1.BackColor = System.Drawing.Color.Transparent;
            this.canon1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.canon1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.canon1.Location = new System.Drawing.Point(75, 103);
            this.canon1.Name = "canon1";
            this.canon1.Size = new System.Drawing.Size(129, 61);
            this.canon1.TabIndex = 6;
            this.canon1.Load += new System.EventHandler(this.canon1_Load_1);
            // 
            // canon2
            // 
            this.canon2.BackColor = System.Drawing.Color.Transparent;
            this.canon2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.canon2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.canon2.Location = new System.Drawing.Point(75, 189);
            this.canon2.Name = "canon2";
            this.canon2.Size = new System.Drawing.Size(129, 61);
            this.canon2.TabIndex = 7;
            // 
            // canon3
            // 
            this.canon3.BackColor = System.Drawing.Color.Transparent;
            this.canon3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.canon3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.canon3.Location = new System.Drawing.Point(0, 189);
            this.canon3.Name = "canon3";
            this.canon3.Size = new System.Drawing.Size(129, 61);
            this.canon3.TabIndex = 8;
            // 
            // canon4
            // 
            this.canon4.BackColor = System.Drawing.Color.Transparent;
            this.canon4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.canon4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.canon4.Location = new System.Drawing.Point(3, 103);
            this.canon4.Name = "canon4";
            this.canon4.Size = new System.Drawing.Size(129, 61);
            this.canon4.TabIndex = 9;
            // 
            // Barco
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.canon4);
            this.Controls.Add(this.canon3);
            this.Controls.Add(this.canon2);
            this.Controls.Add(this.canon1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pic_Barco);
            this.Name = "Barco";
            this.Size = new System.Drawing.Size(366, 607);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Barco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pic_Barco;
        private ProgressBar progressBar1;
        private Canon canon1;
        private Canon canon2;
        private Canon canon3;
        private Canon canon4;
    }
}
