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
            this.comunicador1 = new TrabajoPracticoFinalSegundo.UserControls.Comunicador();
            this.SuspendLayout();
            // 
            // LBL_PRUEBA
            // 
            this.LBL_PRUEBA.AutoSize = true;
            this.LBL_PRUEBA.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBL_PRUEBA.Location = new System.Drawing.Point(43, 139);
            this.LBL_PRUEBA.Name = "LBL_PRUEBA";
            this.LBL_PRUEBA.Size = new System.Drawing.Size(294, 65);
            this.LBL_PRUEBA.TabIndex = 0;
            this.LBL_PRUEBA.Text = "LBL_PRUEBA";
            // 
            // comunicador1
            // 
            this.comunicador1.Location = new System.Drawing.Point(365, 78);
            this.comunicador1.Name = "comunicador1";
            this.comunicador1.Size = new System.Drawing.Size(321, 179);
            this.comunicador1.TabIndex = 1;
            // 
            // Prueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comunicador1);
            this.Controls.Add(this.LBL_PRUEBA);
            this.Name = "Prueba";
            this.Text = "Prueba";
            this.Load += new System.EventHandler(this.Prueba_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LBL_PRUEBA;
        private UserControls.Comunicador comunicador1;
    }
}