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
            this.canon4 = new TrabajoPracticoFinalSegundo.UserControls.Canon();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.canon2 = new TrabajoPracticoFinalSegundo.UserControls.Canon();
            this.canon5 = new TrabajoPracticoFinalSegundo.UserControls.Canon();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Barco)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Barco
            // 
            this.pic_Barco.BackColor = System.Drawing.Color.Transparent;
            this.pic_Barco.Location = new System.Drawing.Point(0, 0);
            this.pic_Barco.Name = "pic_Barco";
            this.pic_Barco.Size = new System.Drawing.Size(302, 604);
            this.pic_Barco.TabIndex = 0;
            this.pic_Barco.TabStop = false;
            this.pic_Barco.Click += new System.EventHandler(this.pic_Barco_Click);
            // 
            // canon1
            // 
            this.canon1.BackColor = System.Drawing.Color.Transparent;
            this.canon1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.canon1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.canon1.IMG = null;
            this.canon1.Location = new System.Drawing.Point(3, 141);
            this.canon1.Name = "canon1";
            this.canon1.Size = new System.Drawing.Size(127, 57);
            this.canon1.TabIndex = 1;
            this.canon1.Load += new System.EventHandler(this.canon1_Load);
            // 
            // canon4
            // 
            this.canon4.BackColor = System.Drawing.Color.Transparent;
            this.canon4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.canon4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.canon4.IMG = null;
            this.canon4.Location = new System.Drawing.Point(0, 238);
            this.canon4.Name = "canon4";
            this.canon4.Size = new System.Drawing.Size(127, 57);
            this.canon4.TabIndex = 4;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 584);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(303, 23);
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Value = 100;
            // 
            // canon2
            // 
            this.canon2.BackColor = System.Drawing.Color.Transparent;
            this.canon2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.canon2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.canon2.IMG = null;
            this.canon2.Location = new System.Drawing.Point(171, 150);
            this.canon2.Name = "canon2";
            this.canon2.Size = new System.Drawing.Size(129, 61);
            this.canon2.TabIndex = 6;
            this.canon2.Load += new System.EventHandler(this.canon2_Load);
            // 
            // canon5
            // 
            this.canon5.BackColor = System.Drawing.Color.Transparent;
            this.canon5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.canon5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.canon5.IMG = null;
            this.canon5.Location = new System.Drawing.Point(171, 247);
            this.canon5.Name = "canon5";
            this.canon5.Size = new System.Drawing.Size(129, 61);
            this.canon5.TabIndex = 8;
            // 
            // Barco
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.canon5);
            this.Controls.Add(this.canon2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.canon4);
            this.Controls.Add(this.canon1);
            this.Controls.Add(this.pic_Barco);
            this.Name = "Barco";
            this.Size = new System.Drawing.Size(303, 607);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Barco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pic_Barco;
        public Canon canon1;
        public Canon canon4;
        private ProgressBar progressBar1;
        private Canon canon2;
        private Canon canon5;
    }
}
