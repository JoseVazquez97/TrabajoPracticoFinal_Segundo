namespace TrabajoPracticoFinalSegundo
{
    partial class Ingreso
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Ingresar = new System.Windows.Forms.Button();
            this.btn_Host = new System.Windows.Forms.Button();
            this.btn_Unirse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.Location = new System.Drawing.Point(904, 708);
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.Size = new System.Drawing.Size(266, 56);
            this.btn_Ingresar.TabIndex = 0;
            this.btn_Ingresar.Text = "Ingresar";
            this.btn_Ingresar.UseVisualStyleBackColor = true;
            this.btn_Ingresar.Click += new System.EventHandler(this.btn_Ingresar_Click);
            // 
            // btn_Host
            // 
            this.btn_Host.Location = new System.Drawing.Point(873, 263);
            this.btn_Host.Name = "btn_Host";
            this.btn_Host.Size = new System.Drawing.Size(310, 111);
            this.btn_Host.TabIndex = 1;
            this.btn_Host.Text = "SER CAPITAN!";
            this.btn_Host.UseVisualStyleBackColor = true;
            this.btn_Host.Click += new System.EventHandler(this.btn_Host_Click);
            // 
            // btn_Unirse
            // 
            this.btn_Unirse.Location = new System.Drawing.Point(873, 425);
            this.btn_Unirse.Name = "btn_Unirse";
            this.btn_Unirse.Size = new System.Drawing.Size(308, 101);
            this.btn_Unirse.TabIndex = 2;
            this.btn_Unirse.Text = "UNIRME A UNA TRIPULACION";
            this.btn_Unirse.UseVisualStyleBackColor = true;
            this.btn_Unirse.Click += new System.EventHandler(this.btn_Unirse_Click);
            // 
            // Ingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            // this.BackgroundImage = global::TrabajoPracticoFinalSegundo.Properties.Resources.FONDO_Ingreso;
            this.ClientSize = new System.Drawing.Size(1454, 814);
            this.Controls.Add(this.btn_Unirse);
            this.Controls.Add(this.btn_Host);
            this.Controls.Add(this.btn_Ingresar);
            this.Name = "Ingreso";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_Ingresar;
        private Button btn_Host;
        private Button btn_Unirse;
    }
}