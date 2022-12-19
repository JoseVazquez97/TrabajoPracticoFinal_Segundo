namespace TrabajoPracticoFinalSegundo.Pantallas
{
    partial class PantallaPhoto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Imagen = new System.Windows.Forms.PictureBox();
            this.ConfirmarSeleccion = new System.Windows.Forms.Button();
            this.labelAvatars = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tblArriba = new System.Windows.Forms.TableLayoutPanel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.fpl_avatars = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen)).BeginInit();
            this.tblArriba.SuspendLayout();
            this.SuspendLayout();
            // 
            // Imagen
            // 
            this.Imagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Imagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Imagen.Location = new System.Drawing.Point(64, 98);
            this.Imagen.Name = "Imagen";
            this.Imagen.Size = new System.Drawing.Size(230, 170);
            this.Imagen.TabIndex = 0;
            this.Imagen.TabStop = false;
            // 
            // ConfirmarSeleccion
            // 
            this.ConfirmarSeleccion.Font = new System.Drawing.Font("BlackPearl", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ConfirmarSeleccion.Location = new System.Drawing.Point(64, 473);
            this.ConfirmarSeleccion.Name = "ConfirmarSeleccion";
            this.ConfirmarSeleccion.Size = new System.Drawing.Size(215, 77);
            this.ConfirmarSeleccion.TabIndex = 4;
            this.ConfirmarSeleccion.Text = "Confirmar Seleccion";
            this.ConfirmarSeleccion.UseVisualStyleBackColor = true;
            this.ConfirmarSeleccion.Click += new System.EventHandler(this.ConfirmarSeleccion_Click);
            // 
            // labelAvatars
            // 
            this.labelAvatars.AutoSize = true;
            this.labelAvatars.Font = new System.Drawing.Font("BlackPearl", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAvatars.Location = new System.Drawing.Point(359, 64);
            this.labelAvatars.Name = "labelAvatars";
            this.labelAvatars.Size = new System.Drawing.Size(336, 29);
            this.labelAvatars.TabIndex = 5;
            this.labelAvatars.Text = "Avatars Seleccionables";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("BlackPearl", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Capitan",
            "Carpintero",
            "Mercader",
            "Artillero"});
            this.comboBox1.Location = new System.Drawing.Point(65, 354);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(229, 37);
            this.comboBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("BlackPearl", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(65, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 34);
            this.label1.TabIndex = 7;
            this.label1.Text = "Elije tu Rol";
            // 
            // tblArriba
            // 
            this.tblArriba.BackColor = System.Drawing.Color.Transparent;
            this.tblArriba.ColumnCount = 2;
            this.tblArriba.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblArriba.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblArriba.Controls.Add(this.btnSalir, 1, 0);
            this.tblArriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblArriba.Location = new System.Drawing.Point(0, 0);
            this.tblArriba.Name = "tblArriba";
            this.tblArriba.RowCount = 1;
            this.tblArriba.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblArriba.Size = new System.Drawing.Size(1203, 30);
            this.tblArriba.TabIndex = 8;
            this.tblArriba.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMove_MouseDown);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.Location = new System.Drawing.Point(1176, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(24, 24);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // fpl_avatars
            // 
            this.fpl_avatars.BackColor = System.Drawing.Color.Transparent;
            this.fpl_avatars.Location = new System.Drawing.Point(359, 99);
            this.fpl_avatars.Name = "fpl_avatars";
            this.fpl_avatars.Size = new System.Drawing.Size(693, 443);
            this.fpl_avatars.TabIndex = 9;
            // 
            // PantallaPhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1203, 685);
            this.Controls.Add(this.fpl_avatars);
            this.Controls.Add(this.tblArriba);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelAvatars);
            this.Controls.Add(this.ConfirmarSeleccion);
            this.Controls.Add(this.Imagen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PantallaPhoto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PantallaPhoto";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PantallaPhoto_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Imagen)).EndInit();
            this.tblArriba.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox Imagen;
        private Button ConfirmarSeleccion;
        private Label labelAvatars;
        private ComboBox comboBox1;
        private Label label1;
        private TableLayoutPanel tblArriba;
        private Button btnSalir;
        private FlowLayoutPanel fpl_avatars;
    }
}