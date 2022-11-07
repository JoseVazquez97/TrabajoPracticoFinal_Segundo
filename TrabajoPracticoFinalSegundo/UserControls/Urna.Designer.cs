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
            this.btn_Si.Location = new System.Drawing.Point(3, 3);
            this.btn_Si.Margin = new System.Windows.Forms.Padding(3, 3, 25, 3);
            this.btn_Si.Name = "btn_Si";
            this.btn_Si.Size = new System.Drawing.Size(242, 120);
            this.btn_Si.TabIndex = 0;
            this.btn_Si.Text = "SI CAPITAN!";
            this.btn_Si.UseVisualStyleBackColor = true;
            this.btn_Si.Click += new System.EventHandler(this.btn_Si_Click);
            // 
            // btn_No
            // 
            this.btn_No.Location = new System.Drawing.Point(274, 3);
            this.btn_No.Name = "btn_No";
            this.btn_No.Size = new System.Drawing.Size(233, 120);
            this.btn_No.TabIndex = 1;
            this.btn_No.Text = "... hoy se levanto tonto";
            this.btn_No.UseVisualStyleBackColor = true;
            this.btn_No.Click += new System.EventHandler(this.btn_No_Click);
            // 
            // Urna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
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
