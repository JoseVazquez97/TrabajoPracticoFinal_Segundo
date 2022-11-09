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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Encender = new System.Windows.Forms.Button();
            this.btn_Apagar = new System.Windows.Forms.Button();
            this.btn_JugarConFoto = new System.Windows.Forms.Button();
            this.BuscarFoto = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(231, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(576, 357);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Encender
            // 
            this.btn_Encender.Location = new System.Drawing.Point(196, 419);
            this.btn_Encender.Name = "btn_Encender";
            this.btn_Encender.Size = new System.Drawing.Size(173, 80);
            this.btn_Encender.TabIndex = 1;
            this.btn_Encender.Text = "ENCENDER";
            this.btn_Encender.UseVisualStyleBackColor = true;
            this.btn_Encender.Click += new System.EventHandler(this.btnEncender_Click);
            // 
            // btn_Apagar
            // 
            this.btn_Apagar.Location = new System.Drawing.Point(685, 419);
            this.btn_Apagar.Name = "btn_Apagar";
            this.btn_Apagar.Size = new System.Drawing.Size(173, 80);
            this.btn_Apagar.TabIndex = 2;
            this.btn_Apagar.Text = "APAGAR";
            this.btn_Apagar.UseVisualStyleBackColor = true;
            this.btn_Apagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btn_JugarConFoto
            // 
            this.btn_JugarConFoto.Location = new System.Drawing.Point(416, 422);
            this.btn_JugarConFoto.Name = "btn_JugarConFoto";
            this.btn_JugarConFoto.Size = new System.Drawing.Size(215, 77);
            this.btn_JugarConFoto.TabIndex = 3;
            this.btn_JugarConFoto.Text = "JUGAR CON FOTO";
            this.btn_JugarConFoto.UseVisualStyleBackColor = true;
            this.btn_JugarConFoto.Click += new System.EventHandler(this.btn_JugarConFoto_Click);
            // 
            // PantallaPhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 562);
            this.Controls.Add(this.btn_JugarConFoto);
            this.Controls.Add(this.btn_Apagar);
            this.Controls.Add(this.btn_Encender);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PantallaPhoto";
            this.Text = "PantallaPhoto";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PantallaPhoto_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
        private Button btn_Encender;
        private Button btn_Apagar;
        private Button btn_JugarConFoto;
        private OpenFileDialog BuscarFoto;
    }
}