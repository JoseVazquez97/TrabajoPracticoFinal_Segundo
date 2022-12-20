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
            this.flpInferior = new System.Windows.Forms.FlowLayoutPanel();
            this.urnaCapitan1 = new TrabajoPracticoFinalSegundo.UserControls.UrnaCapitan();
            this.urna1 = new TrabajoPracticoFinalSegundo.UserControls.Urna();
            this.dados1 = new TrabajoPracticoFinalSegundo.UserControls.Dados();
            this.turnero1 = new TrabajoPracticoFinalSegundo.UserControls.Turnero();
            this.flpLateralIzq = new System.Windows.Forms.FlowLayoutPanel();
            this.pantallaWeb1 = new TrabajoPracticoFinalSegundo.UserControls.PantallaWeb();
            this.pantallaWeb2 = new TrabajoPracticoFinalSegundo.UserControls.PantallaWeb();
            this.pantallaWeb3 = new TrabajoPracticoFinalSegundo.UserControls.PantallaWeb();
            this.pantallaWeb4 = new TrabajoPracticoFinalSegundo.UserControls.PantallaWeb();
            this.noti_Ar = new TrabajoPracticoFinalSegundo.UserControls.Notificador();
            this.noti_Cap = new TrabajoPracticoFinalSegundo.UserControls.Notificador();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.flpLateralDer = new System.Windows.Forms.FlowLayoutPanel();
            this.flpSuperior = new System.Windows.Forms.FlowLayoutPanel();
            this.escrutinio1 = new TrabajoPracticoFinalSegundo.UserControls.Escrutinio();
            this.recursosDisplay1 = new TrabajoPracticoFinalSegundo.UserControls.RecursosDisplay();
            this.Update500ms = new System.Windows.Forms.Timer(this.components);
            this.noti_Carp = new TrabajoPracticoFinalSegundo.UserControls.Notificador();
            this.noti_Mer = new TrabajoPracticoFinalSegundo.UserControls.Notificador();
            this.Barco_Page = new System.Windows.Forms.TabControl();
            this.Navio_Page = new System.Windows.Forms.TabPage();
            this.barco1 = new TrabajoPracticoFinalSegundo.UserControls.Barco();
            this.p_FondoBarcos = new System.Windows.Forms.PictureBox();
            this.Navegacion_Page = new System.Windows.Forms.TabPage();
            this.ucMapa1 = new GeneradorMapa.UCMapa();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.flpInferior.SuspendLayout();
            this.flpLateralIzq.SuspendLayout();
            this.flpLateralDer.SuspendLayout();
            this.flpSuperior.SuspendLayout();
            this.Barco_Page.SuspendLayout();
            this.Navio_Page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p_FondoBarcos)).BeginInit();
            this.Navegacion_Page.SuspendLayout();
            this.SuspendLayout();
            // 
            // dados1
            // 
            this.dados1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dados1.LISTO = false;
            this.dados1.Location = new System.Drawing.Point(1076, -13);
            this.dados1.Margin = new System.Windows.Forms.Padding(50, 3, 50, 3);
            this.dados1.Name = "dados1";
            this.dados1.Size = new System.Drawing.Size(334, 143);
            this.dados1.TabIndex = 3;
            this.dados1.Click += new System.EventHandler(this.dados_Click);
            // 
            // 
            // flpInferior
            // 
            this.flpInferior.BackColor = System.Drawing.Color.Transparent;
            this.flpInferior.Controls.Add(this.urnaCapitan1);
            this.flpInferior.Controls.Add(this.urna1);
            this.flpInferior.Controls.Add(this.dados1);
            this.flpInferior.Controls.Add(this.turnero1);
            this.flpInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpInferior.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flpInferior.Location = new System.Drawing.Point(0, 928);
            this.flpInferior.Margin = new System.Windows.Forms.Padding(0);
            this.flpInferior.Name = "flpInferior";
            this.flpInferior.Size = new System.Drawing.Size(1478, 133);
            this.flpInferior.TabIndex = 4;
            // 
            // urnaCapitan1
            // 
            this.urnaCapitan1.BackColor = System.Drawing.Color.Transparent;
            this.urnaCapitan1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.urnaCapitan1.Location = new System.Drawing.Point(3, 6);
            this.urnaCapitan1.Name = "urnaCapitan1";
            this.urnaCapitan1.Size = new System.Drawing.Size(510, 124);
            this.urnaCapitan1.TabIndex = 4;
            // 
            // urna1
            // 
            this.urna1.BackColor = System.Drawing.Color.Transparent;
            this.urna1.Location = new System.Drawing.Point(516, 6);
            this.urna1.Margin = new System.Windows.Forms.Padding(0);
            this.urna1.Name = "urna1";
            this.urna1.Size = new System.Drawing.Size(510, 127);
            this.urna1.TabIndex = 2;
            // 
            // turnero1
            // 
            this.turnero1.BackColor = System.Drawing.Color.Transparent;
            this.turnero1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.turnero1.Location = new System.Drawing.Point(1026, 6);
            this.turnero1.Margin = new System.Windows.Forms.Padding(0);
            this.turnero1.Name = "turnero1";
            this.turnero1.Size = new System.Drawing.Size(550, 127);
            this.turnero1.TabIndex = 3;
            // 
            // flpLateralIzq
            // 
            this.flpLateralIzq.BackColor = System.Drawing.Color.Transparent;
            this.flpLateralIzq.Controls.Add(this.pantallaWeb1);
            this.flpLateralIzq.Controls.Add(this.pantallaWeb2);
            this.flpLateralIzq.Controls.Add(this.pantallaWeb3);
            this.flpLateralIzq.Controls.Add(this.pantallaWeb4);
            this.flpLateralIzq.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpLateralIzq.Location = new System.Drawing.Point(0, 0);
            this.flpLateralIzq.Margin = new System.Windows.Forms.Padding(0);
            this.flpLateralIzq.Name = "flpLateralIzq";
            this.flpLateralIzq.Size = new System.Drawing.Size(325, 928);
            this.flpLateralIzq.TabIndex = 5;
            // 
            // pantallaWeb1
            // 
            this.pantallaWeb1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pantallaWeb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pantallaWeb1.Location = new System.Drawing.Point(25, 25);
            this.pantallaWeb1.Margin = new System.Windows.Forms.Padding(25, 25, 25, 5);
            this.pantallaWeb1.Name = "pantallaWeb1";
            this.pantallaWeb1.Padding = new System.Windows.Forms.Padding(20);
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
            this.pantallaWeb2.Padding = new System.Windows.Forms.Padding(20);
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
            this.pantallaWeb3.Padding = new System.Windows.Forms.Padding(20);
            this.pantallaWeb3.Size = new System.Drawing.Size(249, 200);
            this.pantallaWeb3.TabIndex = 2;
            // 
            // pantallaWeb4
            // 
            this.pantallaWeb4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pantallaWeb4.Location = new System.Drawing.Point(25, 670);
            this.pantallaWeb4.Margin = new System.Windows.Forms.Padding(25, 10, 25, 5);
            this.pantallaWeb4.Name = "pantallaWeb4";
            this.pantallaWeb4.Padding = new System.Windows.Forms.Padding(20);
            this.pantallaWeb4.Size = new System.Drawing.Size(249, 200);
            this.pantallaWeb4.TabIndex = 3;
            // 
            // noti_Ar
            // 
            this.noti_Ar.BackColor = System.Drawing.Color.Transparent;
            this.noti_Ar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.noti_Ar.Location = new System.Drawing.Point(197, 733);
            this.noti_Ar.Name = "noti_Ar";
            this.noti_Ar.Size = new System.Drawing.Size(220, 83);
            this.noti_Ar.TabIndex = 15;
            // 
            // noti_Cap
            // 
            this.noti_Cap.BackColor = System.Drawing.Color.Transparent;
            this.noti_Cap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            // flpLateralDer
            // 
            this.flpLateralDer.BackColor = System.Drawing.Color.Transparent;
            this.flpLateralDer.Controls.Add(this.btn_Exit);
            this.flpLateralDer.Dock = System.Windows.Forms.DockStyle.Right;
            this.flpLateralDer.Location = new System.Drawing.Point(1408, 0);
            this.flpLateralDer.Margin = new System.Windows.Forms.Padding(0);
            this.flpLateralDer.MaximumSize = new System.Drawing.Size(70, 0);
            this.flpLateralDer.Name = "flpLateralDer";
            this.flpLateralDer.Size = new System.Drawing.Size(70, 928);
            this.flpLateralDer.TabIndex = 7;
            // 
            // flpSuperior
            // 
            this.flpSuperior.BackColor = System.Drawing.Color.Transparent;
            this.flpSuperior.Controls.Add(this.escrutinio1);
            this.flpSuperior.Controls.Add(this.recursosDisplay1);
            this.flpSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpSuperior.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpSuperior.Location = new System.Drawing.Point(325, 0);
            this.flpSuperior.Margin = new System.Windows.Forms.Padding(0);
            this.flpSuperior.Name = "flpSuperior";
            this.flpSuperior.Size = new System.Drawing.Size(1083, 107);
            this.flpSuperior.TabIndex = 8;
            // 
            // escrutinio1
            // 
            this.escrutinio1.BackColor = System.Drawing.Color.Transparent;
            this.escrutinio1.Location = new System.Drawing.Point(3, 3);
            this.escrutinio1.Name = "escrutinio1";
            this.escrutinio1.Size = new System.Drawing.Size(383, 101);
            this.escrutinio1.TabIndex = 3;
            // 
            // recursosDisplay1
            // 
            this.recursosDisplay1.BackColor = System.Drawing.Color.Transparent;
            this.recursosDisplay1.Location = new System.Drawing.Point(389, 0);
            this.recursosDisplay1.Margin = new System.Windows.Forms.Padding(0);
            this.recursosDisplay1.Name = "recursosDisplay1";
            this.recursosDisplay1.Size = new System.Drawing.Size(384, 104);
            this.recursosDisplay1.TabIndex = 0;
            // 
            // Update500ms
            // 
            this.Update500ms.Enabled = true;
            this.Update500ms.Tick += new System.EventHandler(this.Update500ms_Tick);
            // 
            // noti_Carp
            // 
            this.noti_Carp.BackColor = System.Drawing.Color.Transparent;
            this.noti_Carp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.noti_Carp.Location = new System.Drawing.Point(197, 286);
            this.noti_Carp.Name = "noti_Carp";
            this.noti_Carp.Size = new System.Drawing.Size(220, 83);
            this.noti_Carp.TabIndex = 13;
            // 
            // noti_Mer
            // 
            this.noti_Mer.BackColor = System.Drawing.Color.Transparent;
            this.noti_Mer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.noti_Mer.Location = new System.Drawing.Point(197, 504);
            this.noti_Mer.Name = "noti_Mer";
            this.noti_Mer.Size = new System.Drawing.Size(220, 83);
            this.noti_Mer.TabIndex = 14;
            // 
            // Barco_Page
            // 
            this.Barco_Page.AccessibleDescription = "";
            this.Barco_Page.Appearance = System.Windows.Forms.TabAppearance.Buttons;
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
            this.Navio_Page.Controls.Add(this.barco1);
            this.Navio_Page.Controls.Add(this.p_FondoBarcos);
            this.Navio_Page.Location = new System.Drawing.Point(4, 34);
            this.Navio_Page.Name = "Navio_Page";
            this.Navio_Page.Padding = new System.Windows.Forms.Padding(3);
            this.Navio_Page.Size = new System.Drawing.Size(1075, 783);
            this.Navio_Page.TabIndex = 0;
            this.Navio_Page.Text = "Navio";
            this.Navio_Page.UseVisualStyleBackColor = true;
            // 
            // barco1
            // 
            this.barco1.BackColor = System.Drawing.Color.Transparent;
            this.barco1.Location = new System.Drawing.Point(438, 274);
            this.barco1.Name = "barco1";
            this.barco1.Size = new System.Drawing.Size(634, 506);
            this.barco1.TabIndex = 1;
            // 
            // p_FondoBarcos
            // 
            this.p_FondoBarcos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_FondoBarcos.Location = new System.Drawing.Point(3, 3);
            this.p_FondoBarcos.Name = "p_FondoBarcos";
            this.p_FondoBarcos.Size = new System.Drawing.Size(1069, 777);
            this.p_FondoBarcos.TabIndex = 0;
            this.p_FondoBarcos.TabStop = false;
            // 
            // Navegacion_Page
            // 
            this.Navegacion_Page.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Navegacion_Page.Controls.Add(this.ucMapa1);
            this.Navegacion_Page.Location = new System.Drawing.Point(4, 34);
            this.Navegacion_Page.Name = "Navegacion_Page";
            this.Navegacion_Page.Padding = new System.Windows.Forms.Padding(3);
            this.Navegacion_Page.Size = new System.Drawing.Size(1075, 783);
            this.Navegacion_Page.TabIndex = 1;
            this.Navegacion_Page.Text = "Navegacion";
            this.Navegacion_Page.UseVisualStyleBackColor = true;
            // 
            // ucMapa1
            // 
            this.ucMapa1.BackColor = System.Drawing.Color.Navy;
            this.ucMapa1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucMapa1.Location = new System.Drawing.Point(3, 3);
            this.ucMapa1.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.ucMapa1.Name = "ucMapa1";
            this.ucMapa1.Size = new System.Drawing.Size(1069, 777);
            this.ucMapa1.TabIndex = 0;
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 1061);
            this.Controls.Add(this.noti_Ar);
            this.Controls.Add(this.noti_Mer);
            this.Controls.Add(this.noti_Carp);
            this.Controls.Add(this.noti_Cap);
            this.Controls.Add(this.Barco_Page);
            this.Controls.Add(this.flpSuperior);
            this.Controls.Add(this.flpLateralIzq);
            this.Controls.Add(this.flpLateralDer);
            this.Controls.Add(this.flpInferior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed);
            this.Load += new System.EventHandler(this.Home_Load);
            this.flpInferior.ResumeLayout(false);
            this.flpLateralIzq.ResumeLayout(false);
            this.flpLateralDer.ResumeLayout(false);
            this.flpSuperior.ResumeLayout(false);
            this.Barco_Page.ResumeLayout(false);
            this.Navio_Page.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.p_FondoBarcos)).EndInit();
            this.Navegacion_Page.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private FlowLayoutPanel flpInferior;
        private FlowLayoutPanel flpLateralIzq;
        private Button btn_Exit;
        private FlowLayoutPanel flpLateralDer;
        private UserControls.Urna urna1;
        private UserControls.Turnero turnero1;
        private UserControls.PantallaWeb pantallaWeb1;
        private UserControls.PantallaWeb pantallaWeb2;
        private FlowLayoutPanel flpSuperior;
        private UserControls.RecursosDisplay recursosDisplay1;
        private UserControls.PantallaWeb pantallaWeb3;
        private UserControls.Dados dados1;
        private UserControls.PantallaWeb pantallaWeb4;
        private System.Windows.Forms.Timer Update500ms;
        private UserControls.UrnaCapitan urnaCapitan1;
        private UserControls.Notificador noti_Mer;
        private UserControls.Notificador noti_Cap;
        private UserControls.Notificador noti_Carp;
        private UserControls.Notificador noti_Ar;
        private TabControl Barco_Page;
        private PageSetupDialog pageSetupDialog1;
        private UserControls.Escrutinio escrutinio1;
        private TabPage Navegacion_Page;
        private TabPage Navio_Page;
        private GeneradorMapa.UCMapa ucMapa1;
        private PictureBox p_FondoBarcos;
        private UserControls.Barco barco1;
    }
}