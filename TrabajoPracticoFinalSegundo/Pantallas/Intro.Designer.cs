namespace TrabajoPracticoFinalSegundo.Pantallas
{
    partial class Intro
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
            this.p_boxUno = new System.Windows.Forms.PictureBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.p_boxUno)).BeginInit();
            this.SuspendLayout();
            // 
            // p_boxUno
            // 
            this.p_boxUno.BackColor = System.Drawing.Color.Transparent;
            this.p_boxUno.Location = new System.Drawing.Point(621, 371);
            this.p_boxUno.Name = "p_boxUno";
            this.p_boxUno.Size = new System.Drawing.Size(575, 239);
            this.p_boxUno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p_boxUno.TabIndex = 0;
            this.p_boxUno.TabStop = false;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Intro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1447, 668);
            this.Controls.Add(this.p_boxUno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Intro";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Intro_Load);
            this.Click += new System.EventHandler(this.Intro_Click);
            ((System.ComponentModel.ISupportInitialize)(this.p_boxUno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox p_boxUno;
        private System.Windows.Forms.Timer Timer;
    }
}