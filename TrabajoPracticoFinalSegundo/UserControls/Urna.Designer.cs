namespace TrabajoPracticoFinalSegundo.UserControls
{
    partial class Urna
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
            this.btn_Si = new System.Windows.Forms.Button();
            this.btn_No = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Si
            // 
            this.btn_Si.BackColor = System.Drawing.Color.Transparent;
            this.btn_Si.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Si.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Si.FlatAppearance.BorderSize = 0;
            this.btn_Si.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_Si.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Si.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Si.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Si.Font = new System.Drawing.Font("BlackPearl", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Si.Location = new System.Drawing.Point(19, 22);
            this.btn_Si.Margin = new System.Windows.Forms.Padding(3, 3, 25, 3);
            this.btn_Si.Name = "btn_Si";
            this.btn_Si.Size = new System.Drawing.Size(218, 82);
            this.btn_Si.TabIndex = 0;
            this.btn_Si.Text = "SI CAPITAN!";
            this.btn_Si.UseVisualStyleBackColor = false;
            this.btn_Si.Click += new System.EventHandler(this.btn_Si_Click);
            // 
            // btn_No
            // 
            this.btn_No.BackColor = System.Drawing.Color.Transparent;
            this.btn_No.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_No.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_No.FlatAppearance.BorderSize = 0;
            this.btn_No.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_No.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_No.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_No.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_No.Font = new System.Drawing.Font("BlackPearl", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_No.Location = new System.Drawing.Point(255, 22);
            this.btn_No.Name = "btn_No";
            this.btn_No.Size = new System.Drawing.Size(218, 82);
            this.btn_No.TabIndex = 1;
            this.btn_No.Text = "NO CAPITAN!";
            this.btn_No.UseVisualStyleBackColor = false;
            this.btn_No.Click += new System.EventHandler(this.btn_No_Click);
            // 
            // Urna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btn_No);
            this.Controls.Add(this.btn_Si);
            this.Name = "Urna";
            this.Size = new System.Drawing.Size(510, 126);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_Si;
        private Button btn_No;
    }
}
