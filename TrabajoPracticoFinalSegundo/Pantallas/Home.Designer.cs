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
            this.progress = new System.Windows.Forms.ProgressBar();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.urnaCapitan1 = new TrabajoPracticoFinalSegundo.UserControls.UrnaCapitan();
            this.urna1 = new TrabajoPracticoFinalSegundo.UserControls.Urna();
            this.dados1 = new TrabajoPracticoFinalSegundo.UserControls.Dados();
            this.turnero1 = new TrabajoPracticoFinalSegundo.UserControls.Turnero();
            this.Update = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pantallaWeb1 = new TrabajoPracticoFinalSegundo.UserControls.PantallaWeb();
            this.pantallaWeb2 = new TrabajoPracticoFinalSegundo.UserControls.PantallaWeb();
            this.pantallaWeb3 = new TrabajoPracticoFinalSegundo.UserControls.PantallaWeb();
            this.pantallaWeb4 = new TrabajoPracticoFinalSegundo.UserControls.PantallaWeb();
            this.noti_Ar = new TrabajoPracticoFinalSegundo.UserControls.Notificador();
            this.noti_Cap = new TrabajoPracticoFinalSegundo.UserControls.Notificador();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.recursosDisplay1 = new TrabajoPracticoFinalSegundo.UserControls.RecursosDisplay();
            this.button2 = new System.Windows.Forms.Button();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.escrutinio1 = new TrabajoPracticoFinalSegundo.UserControls.Escrutinio();
            this.Update500ms = new System.Windows.Forms.Timer(this.components);
            this.noti_Carp = new TrabajoPracticoFinalSegundo.UserControls.Notificador();
            this.noti_Mer = new TrabajoPracticoFinalSegundo.UserControls.Notificador();
            this.Barco_Page = new System.Windows.Forms.TabControl();
            this.Navio_Page = new System.Windows.Forms.TabPage();
            this.barco2 = new TrabajoPracticoFinalSegundo.UserControls.Barco();
            this.barco1 = new TrabajoPracticoFinalSegundo.UserControls.Barco();
            this.Navegacion_Page = new System.Windows.Forms.TabPage();
            this.tablero_Mapa = new System.Windows.Forms.TableLayoutPanel();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.Barco_Page.SuspendLayout();
            this.Navio_Page.SuspendLayout();
            this.Navegacion_Page.SuspendLayout();
            this.SuspendLayout();
            // 
            // progress
            // 
            this.progress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progress.Location = new System.Drawing.Point(325, 916);
            this.progress.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(1083, 12);
            this.progress.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.urnaCapitan1);
            this.flowLayoutPanel1.Controls.Add(this.urna1);
            this.flowLayoutPanel1.Controls.Add(this.dados1);
            this.flowLayoutPanel1.Controls.Add(this.turnero1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 928);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1478, 133);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // urnaCapitan1
            // 
            this.urnaCapitan1.Location = new System.Drawing.Point(3, 6);
            this.urnaCapitan1.Name = "urnaCapitan1";
            this.urnaCapitan1.Size = new System.Drawing.Size(510, 124);
            this.urnaCapitan1.TabIndex = 4;
            // 
            // urna1
            // 
            this.urna1.BackColor = System.Drawing.Color.Navy;
            this.urna1.Location = new System.Drawing.Point(516, 6);
            this.urna1.Margin = new System.Windows.Forms.Padding(0);
            this.urna1.Name = "urna1";
            this.urna1.Size = new System.Drawing.Size(510, 127);
            this.urna1.TabIndex = 2;
            // 
            // dados1
            // 
            this.dados1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dados1.Location = new System.Drawing.Point(1076, -13);
            this.dados1.Margin = new System.Windows.Forms.Padding(50, 3, 50, 3);
            this.dados1.Name = "dados1";
            this.dados1.Size = new System.Drawing.Size(334, 143);
            this.dados1.TabIndex = 3;
            this.dados1.Load += new System.EventHandler(this.dados1_Load);
            this.dados1.Click += new System.EventHandler(this.dados_Click);
            // 
            // turnero1
            // 
            this.turnero1.BackColor = System.Drawing.Color.Green;
            this.turnero1.Location = new System.Drawing.Point(1460, 6);
            this.turnero1.Margin = new System.Windows.Forms.Padding(0);
            this.turnero1.Name = "turnero1";
            this.turnero1.Size = new System.Drawing.Size(550, 127);
            this.turnero1.TabIndex = 3;
            // 
            // Update
            // 
            this.Update.Enabled = true;
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
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(325, 928);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // pantallaWeb1
            // 
            this.pantallaWeb1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pantallaWeb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pantallaWeb1.Location = new System.Drawing.Point(25, 25);
            this.pantallaWeb1.Margin = new System.Windows.Forms.Padding(25, 25, 25, 5);
            this.pantallaWeb1.Name = "pantallaWeb1";
            this.pantallaWeb1.Size = new System.Drawing.Size(249, 200);
            this.pantallaWeb1.TabIndex = 0;
            // 
            // pantallaWeb2
            // 
            this.pantallaWeb2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pantallaWeb2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pantallaWeb2.Location = new System.Drawing.Point(25, 240);
            this.pantallaWeb2.Margin = new System.Windows.Forms.Padding(25, 10, 25, 5);
            this.pantallaWeb2.Name = "pantallaWeb2";
            this.pantallaWeb2.Size = new System.Drawing.Size(249, 200);
            this.pantallaWeb2.TabIndex = 1;
            // 
            // pantallaWeb3
            // 
            this.pantallaWeb3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pantallaWeb3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pantallaWeb3.Location = new System.Drawing.Point(25, 455);
            this.pantallaWeb3.Margin = new System.Windows.Forms.Padding(25, 10, 25, 5);
            this.pantallaWeb3.Name = "pantallaWeb3";
            this.pantallaWeb3.Size = new System.Drawing.Size(249, 200);
            this.pantallaWeb3.TabIndex = 2;
            // 
            // pantallaWeb4
            // 
            this.pantallaWeb4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pantallaWeb4.Location = new System.Drawing.Point(25, 670);
            this.pantallaWeb4.Margin = new System.Windows.Forms.Padding(25, 10, 25, 5);
            this.pantallaWeb4.Name = "pantallaWeb4";
            this.pantallaWeb4.Size = new System.Drawing.Size(249, 200);
            this.pantallaWeb4.TabIndex = 3;
            // 
            // noti_Ar
            // 
            this.noti_Ar.BackColor = System.Drawing.Color.Transparent;
            this.noti_Ar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.noti_Ar.Location = new System.Drawing.Point(197, 733);
            this.noti_Ar.Name = "noti_Ar";
            this.noti_Ar.Size = new System.Drawing.Size(220, 83);
            this.noti_Ar.TabIndex = 15;
            // 
            // noti_Cap
            // 
            this.noti_Cap.BackColor = System.Drawing.Color.Transparent;
            this.noti_Cap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.noti_Cap.Location = new System.Drawing.Point(197, 110);
            this.noti_Cap.Name = "noti_Cap";
            this.noti_Cap.Size = new System.Drawing.Size(220, 83);
            this.noti_Cap.TabIndex = 12;
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
            this.flowLayoutPanel3.Location = new System.Drawing.Point(1408, 0);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel3.MaximumSize = new System.Drawing.Size(70, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(70, 928);
            this.flowLayoutPanel3.TabIndex = 7;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel4.Controls.Add(this.button1);
            this.flowLayoutPanel4.Controls.Add(this.recursosDisplay1);
            this.flowLayoutPanel4.Controls.Add(this.button2);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(325, 0);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(1083, 107);
            this.flowLayoutPanel4.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("BlackPearl", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(302, 101);
            this.button1.TabIndex = 1;
            this.button1.Text = "NAVIO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // recursosDisplay1
            // 
            this.recursosDisplay1.BackColor = System.Drawing.Color.Transparent;
            this.recursosDisplay1.Location = new System.Drawing.Point(308, 0);
            this.recursosDisplay1.Margin = new System.Windows.Forms.Padding(0);
            this.recursosDisplay1.Name = "recursosDisplay1";
            this.recursosDisplay1.Size = new System.Drawing.Size(427, 109);
            this.recursosDisplay1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("BlackPearl", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(738, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(271, 101);
            this.button2.TabIndex = 2;
            this.button2.Text = "MAPA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel5.Controls.Add(this.escrutinio1);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(325, 107);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(1083, 0);
            this.flowLayoutPanel5.TabIndex = 9;
            this.flowLayoutPanel5.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel5_Paint);
            // 
            // escrutinio1
            // 
            this.escrutinio1.BackColor = System.Drawing.Color.Transparent;
            this.escrutinio1.Location = new System.Drawing.Point(3, 3);
            this.escrutinio1.Name = "escrutinio1";
            this.escrutinio1.Size = new System.Drawing.Size(1080, 87);
            this.escrutinio1.TabIndex = 2;
            // 
            // Update500ms
            // 
            this.Update500ms.Enabled = true;
            this.Update500ms.Interval = 300;
            this.Update500ms.Tick += new System.EventHandler(this.Update500ms_Tick);
            // 
            // noti_Carp
            // 
            this.noti_Carp.BackColor = System.Drawing.Color.Transparent;
            this.noti_Carp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.noti_Carp.Location = new System.Drawing.Point(197, 286);
            this.noti_Carp.Name = "noti_Carp";
            this.noti_Carp.Size = new System.Drawing.Size(220, 83);
            this.noti_Carp.TabIndex = 13;
            // 
            // noti_Mer
            // 
            this.noti_Mer.BackColor = System.Drawing.Color.Transparent;
            this.noti_Mer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.noti_Mer.Location = new System.Drawing.Point(197, 504);
            this.noti_Mer.Name = "noti_Mer";
            this.noti_Mer.Size = new System.Drawing.Size(220, 83);
            this.noti_Mer.TabIndex = 14;
            // 
            // Barco_Page
            // 
            this.Barco_Page.AccessibleDescription = "";
            this.Barco_Page.Controls.Add(this.Navio_Page);
            this.Barco_Page.Controls.Add(this.Navegacion_Page);
            this.Barco_Page.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Barco_Page.Font = new System.Drawing.Font("BlackPearl", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Barco_Page.Location = new System.Drawing.Point(325, 107);
            this.Barco_Page.Name = "Barco_Page";
            this.Barco_Page.SelectedIndex = 0;
            this.Barco_Page.Size = new System.Drawing.Size(1083, 821);
            this.Barco_Page.TabIndex = 18;
            this.Barco_Page.TabStop = false;
            // 
            // Navio_Page
            // 
            this.Navio_Page.Controls.Add(this.barco2);
            this.Navio_Page.Controls.Add(this.barco1);
            this.Navio_Page.Location = new System.Drawing.Point(4, 31);
            this.Navio_Page.Name = "Navio_Page";
            this.Navio_Page.Padding = new System.Windows.Forms.Padding(3);
            this.Navio_Page.Size = new System.Drawing.Size(1075, 786);
            this.Navio_Page.TabIndex = 0;
            this.Navio_Page.Text = "Navio";
            this.Navio_Page.UseVisualStyleBackColor = true;
            // 
            // barco2
            // 
            this.barco2.BackColor = System.Drawing.Color.Transparent;
            this.barco2.Location = new System.Drawing.Point(679, 3);
            this.barco2.Margin = new System.Windows.Forms.Padding(0);
            this.barco2.Name = "barco2";
            this.barco2.Size = new System.Drawing.Size(366, 607);
            this.barco2.TabIndex = 3;
            // 
            // barco1
            // 
            this.barco1.BackColor = System.Drawing.Color.Transparent;
            this.barco1.Location = new System.Drawing.Point(261, 102);
            this.barco1.Margin = new System.Windows.Forms.Padding(0);
            this.barco1.Name = "barco1";
            this.barco1.Size = new System.Drawing.Size(366, 607);
            this.barco1.TabIndex = 2;
            // 
            // Navegacion_Page
            // 
            this.Navegacion_Page.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Navegacion_Page.Controls.Add(this.tablero_Mapa);
            this.Navegacion_Page.Location = new System.Drawing.Point(4, 31);
            this.Navegacion_Page.Name = "Navegacion_Page";
            this.Navegacion_Page.Padding = new System.Windows.Forms.Padding(3);
            this.Navegacion_Page.Size = new System.Drawing.Size(1075, 786);
            this.Navegacion_Page.TabIndex = 1;
            this.Navegacion_Page.Text = "Navegacion";
            this.Navegacion_Page.UseVisualStyleBackColor = true;
            // 
            // tablero_Mapa
            // 
            this.tablero_Mapa.ColumnCount = 10;
            this.tablero_Mapa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tablero_Mapa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tablero_Mapa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tablero_Mapa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tablero_Mapa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tablero_Mapa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tablero_Mapa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tablero_Mapa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tablero_Mapa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tablero_Mapa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tablero_Mapa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablero_Mapa.Location = new System.Drawing.Point(3, 3);
            this.tablero_Mapa.Name = "tablero_Mapa";
            this.tablero_Mapa.RowCount = 10;
            this.tablero_Mapa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tablero_Mapa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tablero_Mapa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tablero_Mapa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tablero_Mapa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tablero_Mapa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tablero_Mapa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tablero_Mapa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tablero_Mapa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tablero_Mapa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tablero_Mapa.Size = new System.Drawing.Size(1069, 780);
            this.tablero_Mapa.TabIndex = 0;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 1061);
            this.Controls.Add(this.noti_Ar);
            this.Controls.Add(this.noti_Mer);
            this.Controls.Add(this.noti_Carp);
            this.Controls.Add(this.noti_Cap);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.Barco_Page);
            this.Controls.Add(this.flowLayoutPanel5);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel1);
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
            this.Barco_Page.ResumeLayout(false);
            this.Navio_Page.ResumeLayout(false);
            this.Navegacion_Page.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
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
        private UserControls.PantallaWeb pantallaWeb4;
        private System.Windows.Forms.Timer Update500ms;
        private UserControls.UrnaCapitan urnaCapitan1;
        private UserControls.Notificador noti_Mer;
        private UserControls.Notificador notificador2;
        private UserControls.Notificador notificador3;
        private UserControls.Notificador notificador4;
        private UserControls.Escrutinio escrutinio1;
        private UserControls.Notificador noti_Cap;
        private UserControls.Notificador noti_Carp;
        private UserControls.Notificador noti_Ar;
        private Button button1;
        private Button button2;
        private TabControl Barco_Page;
        private TabPage Navegacion_Page;
        private TabPage Navio_Page;
        private UserControls.Barco barco2;
        private UserControls.Barco barco1;
        private PageSetupDialog pageSetupDialog1;
        private TableLayoutPanel tablero_Mapa;
    }
}