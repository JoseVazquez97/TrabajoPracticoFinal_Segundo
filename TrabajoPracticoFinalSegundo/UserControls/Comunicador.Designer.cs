namespace TrabajoPracticoFinalSegundo.UserControls
{
    partial class Comunicador
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
            this.LABEL_PRUEBA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LABEL_PRUEBA
            // 
            this.LABEL_PRUEBA.AutoSize = true;
            this.LABEL_PRUEBA.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LABEL_PRUEBA.Location = new System.Drawing.Point(11, 24);
            this.LABEL_PRUEBA.Name = "LABEL_PRUEBA";
            this.LABEL_PRUEBA.Size = new System.Drawing.Size(307, 128);
            this.LABEL_PRUEBA.TabIndex = 0;
            this.LABEL_PRUEBA.Text = "label1";
            // 
            // Comunicador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LABEL_PRUEBA);
            this.Name = "Comunicador";
            this.Size = new System.Drawing.Size(321, 179);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LABEL_PRUEBA;
    }
}
