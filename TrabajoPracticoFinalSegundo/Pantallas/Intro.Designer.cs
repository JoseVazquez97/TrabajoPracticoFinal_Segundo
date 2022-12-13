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
            this.p_box2 = new System.Windows.Forms.PictureBox();
            this.tblBottom = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.p_boxUno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_box2)).BeginInit();
            this.tblBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_boxUno
            // 
            this.p_boxUno.BackColor = System.Drawing.Color.Transparent;
            this.p_boxUno.Location = new System.Drawing.Point(621, 246);
            this.p_boxUno.Name = "p_boxUno";
            this.p_boxUno.Size = new System.Drawing.Size(575, 300);
            this.p_boxUno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p_boxUno.TabIndex = 0;
            this.p_boxUno.TabStop = false;
            this.p_boxUno.Click += new System.EventHandler(this.Intro_Click);
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // p_box2
            // 
            this.p_box2.Dock = System.Windows.Forms.DockStyle.Left;
            this.p_box2.Location = new System.Drawing.Point(50, 0);
            this.p_box2.Margin = new System.Windows.Forms.Padding(50, 0, 30, 50);
            this.p_box2.Name = "p_box2";
            this.p_box2.Size = new System.Drawing.Size(150, 150);
            this.p_box2.TabIndex = 2;
            this.p_box2.TabStop = false;
            // 
            // tblBottom
            // 
            this.tblBottom.ColumnCount = 1;
            this.tblBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblBottom.Controls.Add(this.p_box2, 0, 0);
            this.tblBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tblBottom.Location = new System.Drawing.Point(0, 468);
            this.tblBottom.Name = "tblBottom";
            this.tblBottom.RowCount = 1;
            this.tblBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblBottom.Size = new System.Drawing.Size(1447, 200);
            this.tblBottom.TabIndex = 3;
            // 
            // Intro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1447, 668);
            this.Controls.Add(this.tblBottom);
            this.Controls.Add(this.p_boxUno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Intro";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Intro_Load);
            this.Click += new System.EventHandler(this.Intro_Click);
            ((System.ComponentModel.ISupportInitialize)(this.p_boxUno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_box2)).EndInit();
            this.tblBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox p_boxUno;
        private System.Windows.Forms.Timer Timer;
        private PictureBox p_box2;
        private TableLayoutPanel tblBottom;
    }
}