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
            this.connectButton = new System.Windows.Forms.Button();
            this.sendButton = new System.Windows.Forms.Button();
            this.pruebauControl1 = new TrabajoPracticoFinalSegundo.UserControls.PruebaUControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_PRUEBA
            // 
            this.LBL_PRUEBA.AutoSize = true;
            this.LBL_PRUEBA.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBL_PRUEBA.Location = new System.Drawing.Point(421, 272);
            this.LBL_PRUEBA.Name = "LBL_PRUEBA";
            this.LBL_PRUEBA.Size = new System.Drawing.Size(294, 65);
            this.LBL_PRUEBA.TabIndex = 0;
            this.LBL_PRUEBA.Text = "LBL_PRUEBA";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(180, 377);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(245, 97);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "CONECTARSE";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(663, 380);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(259, 94);
            this.sendButton.TabIndex = 3;
            this.sendButton.Text = "REINCIAR";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // pruebauControl1
            // 
            this.pruebauControl1.Location = new System.Drawing.Point(94, 35);
            this.pruebauControl1.Name = "pruebauControl1";
            this.pruebauControl1.Size = new System.Drawing.Size(955, 181);
            this.pruebauControl1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1216, 552);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Prueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 551);
            this.Controls.Add(this.pruebauControl1);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.LBL_PRUEBA);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Prueba";
            this.Text = "Prueba";
            this.Load += new System.EventHandler(this.Prueba_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LBL_PRUEBA;
        private Button connectButton;
        private Button sendButton;
        private UserControls.PruebaUControl pruebauControl1;
        private PictureBox pictureBox1;
    }
}