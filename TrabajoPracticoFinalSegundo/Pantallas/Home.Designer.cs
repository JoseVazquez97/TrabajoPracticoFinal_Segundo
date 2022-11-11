namespace TrabajoPracticoFinalSegundo.Pantallas
{
    partial class Home
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
            this.barco1 = new TrabajoPracticoFinalSegundo.UserControls.Barco();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.urna1 = new TrabajoPracticoFinalSegundo.UserControls.Urna();
            this.dados1 = new TrabajoPracticoFinalSegundo.UserControls.Dados();
            this.turnero1 = new TrabajoPracticoFinalSegundo.UserControls.Turnero();
            this.Update = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pantallaWeb1 = new TrabajoPracticoFinalSegundo.UserControls.PantallaWeb();
            this.pantallaWeb2 = new TrabajoPracticoFinalSegundo.UserControls.PantallaWeb();
            this.pantallaWeb3 = new TrabajoPracticoFinalSegundo.UserControls.PantallaWeb();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.recursosDisplay1 = new TrabajoPracticoFinalSegundo.UserControls.RecursosDisplay();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pantallaWeb4 = new TrabajoPracticoFinalSegundo.UserControls.PantallaWeb();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // barco1
            // 
            this.barco1.BackColor = System.Drawing.Color.Transparent;
            this.barco1.Location = new System.Drawing.Point(442, 208);
            this.barco1.Margin = new System.Windows.Forms.Padding(442, 80, 0, 0);
            this.barco1.Name = "barco1";
            this.barco1.Size = new System.Drawing.Size(360, 754);
            this.barco1.TabIndex = 0;
            this.barco1.Load += new System.EventHandler(this.barco1_Load);
            // 
            // progress
            // 
            this.progress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progress.Location = new System.Drawing.Point(0, 916);
            this.progress.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(1534, 12);
            this.progress.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.urna1);
            this.flowLayoutPanel1.Controls.Add(this.dados1);
            this.flowLayoutPanel1.Controls.Add(this.turnero1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 928);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1534, 133);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // urna1
            // 
            this.urna1.BackColor = System.Drawing.Color.Navy;
            this.urna1.Location = new System.Drawing.Point(0, 6);
            this.urna1.Margin = new System.Windows.Forms.Padding(0);
            this.urna1.Name = "urna1";
            this.urna1.Size = new System.Drawing.Size(510, 127);
            this.urna1.TabIndex = 2;
            // 
            // dados1
            // 
            this.dados1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dados1.Location = new System.Drawing.Point(513, -13);
            this.dados1.Name = "dados1";
            this.dados1.Size = new System.Drawing.Size(321, 143);
            this.dados1.TabIndex = 3;
            // 
            // turnero1
            // 
            this.turnero1.BackColor = System.Drawing.Color.Green;
            this.turnero1.Location = new System.Drawing.Point(837, 6);
            this.turnero1.Margin = new System.Windows.Forms.Padding(0);
            this.turnero1.Name = "turnero1";
            this.turnero1.Size = new System.Drawing.Size(418, 127);
            this.turnero1.TabIndex = 3;
            // 
            // Update
            // 
            this.Update.Enabled = true;
            this.Update.Interval = 1000;
            this.Update.Tick += new System.EventHandler(this.Update_Tick);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.Controls.Add(this.pantallaWeb1);
            this.flowLayoutPanel2.Controls.Add(this.pantallaWeb2);
            this.flowLayoutPanel2.Controls.Add(this.pantallaWeb3);
            this.flowLayoutPanel2.Controls.Add(this.pantallaWeb4);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(325, 916);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // pantallaWeb1
            // 
            this.pantallaWeb1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pantallaWeb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pantallaWeb1.Location = new System.Drawing.Point(25, 25);
            this.pantallaWeb1.Margin = new System.Windows.Forms.Padding(25, 25, 25, 10);
            this.pantallaWeb1.Name = "pantallaWeb1";
            this.pantallaWeb1.Size = new System.Drawing.Size(270, 200);
            this.pantallaWeb1.TabIndex = 0;
            // 
            // pantallaWeb2
            // 
            this.pantallaWeb2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pantallaWeb2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pantallaWeb2.Location = new System.Drawing.Point(25, 260);
            this.pantallaWeb2.Margin = new System.Windows.Forms.Padding(25, 25, 25, 10);
            this.pantallaWeb2.Name = "pantallaWeb2";
            this.pantallaWeb2.Size = new System.Drawing.Size(270, 200);
            this.pantallaWeb2.TabIndex = 1;
            // 
            // pantallaWeb3
            // 
            this.pantallaWeb3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pantallaWeb3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pantallaWeb3.Location = new System.Drawing.Point(25, 495);
            this.pantallaWeb3.Margin = new System.Windows.Forms.Padding(25, 25, 25, 10);
            this.pantallaWeb3.Name = "pantallaWeb3";
            this.pantallaWeb3.Size = new System.Drawing.Size(270, 200);
            this.pantallaWeb3.TabIndex = 2;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(3, 3);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(60, 60);
            this.btn_Exit.TabIndex = 6;
            this.btn_Exit.Text = "X";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click_1);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel3.Controls.Add(this.btn_Exit);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(1469, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(65, 916);
            this.flowLayoutPanel3.TabIndex = 7;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel4.Controls.Add(this.recursosDisplay1);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(325, 0);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(1144, 107);
            this.flowLayoutPanel4.TabIndex = 8;
            // 
            // recursosDisplay1
            // 
            this.recursosDisplay1.BackColor = System.Drawing.Color.Transparent;
            this.recursosDisplay1.Location = new System.Drawing.Point(3, 0);
            this.recursosDisplay1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.recursosDisplay1.Name = "recursosDisplay1";
            this.recursosDisplay1.Size = new System.Drawing.Size(903, 105);
            this.recursosDisplay1.TabIndex = 0;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel5.Controls.Add(this.label1);
            this.flowLayoutPanel5.Controls.Add(this.barco1);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(325, 107);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(925, 809);
            this.flowLayoutPanel5.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 128);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // pantallaWeb4
            // 
            this.pantallaWeb4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pantallaWeb4.Location = new System.Drawing.Point(25, 730);
            this.pantallaWeb4.Margin = new System.Windows.Forms.Padding(25, 25, 25, 10);
            this.pantallaWeb4.Name = "pantallaWeb4";
            this.pantallaWeb4.Size = new System.Drawing.Size(270, 200);
            this.pantallaWeb4.TabIndex = 3;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1534, 1061);
            this.Controls.Add(this.flowLayoutPanel5);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MinimizeBox = false;
            this.Name = "Home";
            this.Text = "Home";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed);
            this.Load += new System.EventHandler(this.Home_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.Barco barco1;
        public ProgressBar progress;
        private FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Timer Update;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btn_Exit;
        private FlowLayoutPanel flowLayoutPanel3;
        private UserControls.Urna urna1;
        private UserControls.Turnero turnero1;
        private UserControls.PantallaWeb pantallaWeb1;
        private UserControls.PantallaWeb pantallaWeb2;
        private FlowLayoutPanel flowLayoutPanel4;
        private UserControls.RecursosDisplay recursosDisplay1;
        private FlowLayoutPanel flowLayoutPanel5;
        private UserControls.PantallaWeb pantallaWeb3;
        private UserControls.Dados dados1;
        private Label label1;
        private UserControls.PantallaWeb pantallaWeb4;
    }
}