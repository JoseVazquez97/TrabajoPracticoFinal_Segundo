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
            this.pic_Evento = new System.Windows.Forms.PictureBox();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Barco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Evento)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Barco
            // 
            this.pic_Barco.BackColor = System.Drawing.Color.Transparent;
            this.pic_Barco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pic_Barco.Dock = System.Windows.Forms.DockStyle.Left;
            this.pic_Barco.Location = new System.Drawing.Point(0, 0);
            this.pic_Barco.Name = "pic_Barco";
            this.pic_Barco.Size = new System.Drawing.Size(516, 777);
            this.pic_Barco.TabIndex = 0;
            this.pic_Barco.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 777);
            this.progressBar1.MaximumSize = new System.Drawing.Size(300, 25);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(300, 25);
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Value = 100;
            // 
            // pic_Evento
            // 
            this.pic_Evento.BackColor = System.Drawing.Color.Transparent;
            this.pic_Evento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pic_Evento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_Evento.Location = new System.Drawing.Point(516, 0);
            this.pic_Evento.Name = "pic_Evento";
            this.pic_Evento.Size = new System.Drawing.Size(1001, 777);
            this.pic_Evento.TabIndex = 6;
            this.pic_Evento.TabStop = false;
            // 
            // progressBar2
            // 
            this.progressBar2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar2.Location = new System.Drawing.Point(1192, 777);
            this.progressBar2.MaximumSize = new System.Drawing.Size(300, 25);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(300, 25);
            this.progressBar2.TabIndex = 7;
            this.progressBar2.Value = 100;
            // 
            // Barco
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pic_Evento);
            this.Controls.Add(this.pic_Barco);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.progressBar2);
            this.Name = "Barco";
            this.Size = new System.Drawing.Size(1517, 802);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Barco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Evento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pic_Barco;
        private ProgressBar progressBar1;
        private PictureBox pic_Evento;
        private ProgressBar progressBar2;
    }
}
