namespace TrabajoPracticoFinalSegundo.Pantallas
{
    partial class Prueba
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
            this.LBL_PRUEBA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBL_PRUEBA
            // 
            this.LBL_PRUEBA.AutoSize = true;
            this.LBL_PRUEBA.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBL_PRUEBA.Location = new System.Drawing.Point(203, 155);
            this.LBL_PRUEBA.Name = "LBL_PRUEBA";
            this.LBL_PRUEBA.Size = new System.Drawing.Size(294, 65);
            this.LBL_PRUEBA.TabIndex = 0;
            this.LBL_PRUEBA.Text = "LBL_PRUEBA";
            // 
            // Prueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LBL_PRUEBA);
            this.Name = "Prueba";
            this.Text = "Prueba";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Label LBL_PRUEBA;
    }
}