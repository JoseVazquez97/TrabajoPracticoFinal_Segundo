namespace TrabajoPracticoFinalSegundo.UserControls
{
    partial class UrnaCapitan
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
            this.btn_Norte = new System.Windows.Forms.Button();
            this.btn_Oeste = new System.Windows.Forms.Button();
            this.btn_Este = new System.Windows.Forms.Button();
            this.btn_Sur = new System.Windows.Forms.Button();
            this.pbBrujula = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBrujula)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Norte
            // 
            this.btn_Norte.BackColor = System.Drawing.Color.Transparent;
            this.btn_Norte.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.btn_Norte.FlatAppearance.BorderSize = 0;
            this.btn_Norte.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_Norte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Norte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Norte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Norte.Font = new System.Drawing.Font("BlackPearl", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Norte.Location = new System.Drawing.Point(236, 16);
            this.btn_Norte.Name = "btn_Norte";
            this.btn_Norte.Size = new System.Drawing.Size(45, 45);
            this.btn_Norte.TabIndex = 0;
            this.btn_Norte.Text = "N";
            this.btn_Norte.UseVisualStyleBackColor = false;
            this.btn_Norte.Click += new System.EventHandler(this.btn_Norte_Click);
            // 
            // btn_Oeste
            // 
            this.btn_Oeste.BackColor = System.Drawing.Color.Transparent;
            this.btn_Oeste.Cursor = System.Windows.Forms.Cursors.PanEast;
            this.btn_Oeste.FlatAppearance.BorderSize = 0;
            this.btn_Oeste.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_Oeste.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Oeste.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Oeste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Oeste.Font = new System.Drawing.Font("BlackPearl", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Oeste.Location = new System.Drawing.Point(278, 51);
            this.btn_Oeste.Name = "btn_Oeste";
            this.btn_Oeste.Size = new System.Drawing.Size(45, 45);
            this.btn_Oeste.TabIndex = 1;
            this.btn_Oeste.Text = "E";
            this.btn_Oeste.UseVisualStyleBackColor = false;
            this.btn_Oeste.Click += new System.EventHandler(this.btn_Oeste_Click);
            // 
            // btn_Este
            // 
            this.btn_Este.BackColor = System.Drawing.Color.Transparent;
            this.btn_Este.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.btn_Este.FlatAppearance.BorderSize = 0;
            this.btn_Este.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_Este.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Este.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Este.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Este.Font = new System.Drawing.Font("BlackPearl", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Este.Location = new System.Drawing.Point(198, 51);
            this.btn_Este.Name = "btn_Este";
            this.btn_Este.Size = new System.Drawing.Size(45, 45);
            this.btn_Este.TabIndex = 2;
            this.btn_Este.Text = "O";
            this.btn_Este.UseVisualStyleBackColor = false;
            this.btn_Este.Click += new System.EventHandler(this.btn_Este_Click);
            // 
            // btn_Sur
            // 
            this.btn_Sur.BackColor = System.Drawing.Color.Transparent;
            this.btn_Sur.Cursor = System.Windows.Forms.Cursors.PanSouth;
            this.btn_Sur.FlatAppearance.BorderSize = 0;
            this.btn_Sur.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_Sur.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Sur.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Sur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sur.Font = new System.Drawing.Font("BlackPearl", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Sur.Location = new System.Drawing.Point(236, 93);
            this.btn_Sur.Name = "btn_Sur";
            this.btn_Sur.Size = new System.Drawing.Size(45, 45);
            this.btn_Sur.TabIndex = 3;
            this.btn_Sur.Text = "S";
            this.btn_Sur.UseVisualStyleBackColor = false;
            this.btn_Sur.Click += new System.EventHandler(this.btn_Sur_Click);
            // 
            // pbBrujula
            // 
            this.pbBrujula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbBrujula.Location = new System.Drawing.Point(180, 0);
            this.pbBrujula.Name = "pbBrujula";
            this.pbBrujula.Size = new System.Drawing.Size(160, 160);
            this.pbBrujula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBrujula.TabIndex = 4;
            this.pbBrujula.TabStop = false;
            // 
            // UrnaCapitan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btn_Sur);
            this.Controls.Add(this.btn_Oeste);
            this.Controls.Add(this.btn_Este);
            this.Controls.Add(this.btn_Norte);
            this.Controls.Add(this.pbBrujula);
            this.Name = "UrnaCapitan";
            this.Size = new System.Drawing.Size(510, 150);
            ((System.ComponentModel.ISupportInitialize)(this.pbBrujula)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_Norte;
        private Button btn_Oeste;
        private Button btn_Este;
        private Button btn_Sur;
        private PictureBox pbBrujula;
    }
}
