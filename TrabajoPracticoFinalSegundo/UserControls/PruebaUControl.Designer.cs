namespace TrabajoPracticoFinalSegundo.UserControls
{
    partial class PruebaUControl
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
            this.lbl_Control = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Control
            // 
            this.lbl_Control.AutoSize = true;
            this.lbl_Control.Font = new System.Drawing.Font("BlackPearl", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Control.Location = new System.Drawing.Point(19, 33);
            this.lbl_Control.Name = "lbl_Control";
            this.lbl_Control.Size = new System.Drawing.Size(864, 114);
            this.lbl_Control.TabIndex = 0;
            this.lbl_Control.Text = "Control Sample";
            // 
            // PruebaUControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_Control);
            this.Name = "PruebaUControl";
            this.Size = new System.Drawing.Size(955, 181);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_Control;
    }
}
