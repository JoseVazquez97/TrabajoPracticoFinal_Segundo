namespace TrabajoPracticoFinalSegundo.UserControls
{
    partial class Turnero
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Turno = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 133);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("BlackPearl", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Nombre.Location = new System.Drawing.Point(268, 45);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(266, 45);
            this.lbl_Nombre.TabIndex = 1;
            this.lbl_Nombre.Text = "JUGADOR";
            this.lbl_Nombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Nombre.Click += new System.EventHandler(this.lbl_Nombre_Click);
            // 
            // lbl_Turno
            // 
            this.lbl_Turno.AutoSize = true;
            this.lbl_Turno.Font = new System.Drawing.Font("BlackPearl", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Turno.Location = new System.Drawing.Point(88, 75);
            this.lbl_Turno.Name = "lbl_Turno";
            this.lbl_Turno.Size = new System.Drawing.Size(40, 56);
            this.lbl_Turno.TabIndex = 2;
            this.lbl_Turno.Text = "1";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("BlackPearl", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Title.Location = new System.Drawing.Point(38, 18);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(147, 45);
            this.lbl_Title.TabIndex = 3;
            this.lbl_Title.Text = "Turno";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Turnero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.lbl_Turno);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Turnero";
            this.Size = new System.Drawing.Size(560, 133);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label lbl_Nombre;
        private Label lbl_Turno;
        private Label lbl_Title;
        private System.Windows.Forms.Timer timer1;
    }
}
