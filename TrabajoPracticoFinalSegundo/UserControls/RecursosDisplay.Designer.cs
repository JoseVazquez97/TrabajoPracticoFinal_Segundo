namespace TrabajoPracticoFinalSegundo.UserControls
{
    partial class RecursosDisplay
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Tesoro = new System.Windows.Forms.Label();
            this.lbl_Planos = new System.Windows.Forms.Label();
            this.lbl_Maderas = new System.Windows.Forms.Label();
            this.p_Tesoro = new System.Windows.Forms.PictureBox();
            this.p_Planos = new System.Windows.Forms.PictureBox();
            this.p_Madera = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.p_Tesoro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_Planos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_Madera)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Tesoro
            // 
            this.lbl_Tesoro.AutoSize = true;
            this.lbl_Tesoro.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Tesoro.Font = new System.Drawing.Font("BlackPearl", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Tesoro.Location = new System.Drawing.Point(35, 5);
            this.lbl_Tesoro.Margin = new System.Windows.Forms.Padding(35, 5, 35, 5);
            this.lbl_Tesoro.Name = "lbl_Tesoro";
            this.lbl_Tesoro.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lbl_Tesoro.Size = new System.Drawing.Size(38, 38);
            this.lbl_Tesoro.TabIndex = 1;
            this.lbl_Tesoro.Text = "0";
            // 
            // lbl_Planos
            // 
            this.lbl_Planos.AutoSize = true;
            this.lbl_Planos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Planos.Font = new System.Drawing.Font("BlackPearl", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Planos.Location = new System.Drawing.Point(143, 5);
            this.lbl_Planos.Margin = new System.Windows.Forms.Padding(35, 5, 20, 5);
            this.lbl_Planos.Name = "lbl_Planos";
            this.lbl_Planos.Size = new System.Drawing.Size(33, 38);
            this.lbl_Planos.TabIndex = 2;
            this.lbl_Planos.Text = "0";
            // 
            // lbl_Maderas
            // 
            this.lbl_Maderas.AutoSize = true;
            this.lbl_Maderas.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Maderas.Font = new System.Drawing.Font("BlackPearl", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Maderas.Location = new System.Drawing.Point(236, 5);
            this.lbl_Maderas.Margin = new System.Windows.Forms.Padding(40, 5, 0, 5);
            this.lbl_Maderas.Name = "lbl_Maderas";
            this.lbl_Maderas.Size = new System.Drawing.Size(33, 38);
            this.lbl_Maderas.TabIndex = 3;
            this.lbl_Maderas.Text = "0";
            // 
            // p_Tesoro
            // 
            this.p_Tesoro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.p_Tesoro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p_Tesoro.Location = new System.Drawing.Point(25, 3);
            this.p_Tesoro.Margin = new System.Windows.Forms.Padding(25, 3, 30, 3);
            this.p_Tesoro.Name = "p_Tesoro";
            this.p_Tesoro.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.p_Tesoro.Size = new System.Drawing.Size(55, 55);
            this.p_Tesoro.TabIndex = 4;
            this.p_Tesoro.TabStop = false;
            // 
            // p_Planos
            // 
            this.p_Planos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.p_Planos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p_Planos.Location = new System.Drawing.Point(130, 3);
            this.p_Planos.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.p_Planos.Name = "p_Planos";
            this.p_Planos.Size = new System.Drawing.Size(55, 55);
            this.p_Planos.TabIndex = 5;
            this.p_Planos.TabStop = false;
            // 
            // p_Madera
            // 
            this.p_Madera.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.p_Madera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p_Madera.Location = new System.Drawing.Point(225, 3);
            this.p_Madera.Margin = new System.Windows.Forms.Padding(20, 3, 0, 3);
            this.p_Madera.Name = "p_Madera";
            this.p_Madera.Size = new System.Drawing.Size(55, 55);
            this.p_Madera.TabIndex = 6;
            this.p_Madera.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(454, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(296, 106);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel3.Controls.Add(this.p_Tesoro);
            this.flowLayoutPanel3.Controls.Add(this.p_Planos);
            this.flowLayoutPanel3.Controls.Add(this.p_Madera);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(295, 59);
            this.flowLayoutPanel3.TabIndex = 9;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.Controls.Add(this.lbl_Tesoro);
            this.flowLayoutPanel2.Controls.Add(this.lbl_Planos);
            this.flowLayoutPanel2.Controls.Add(this.lbl_Maderas);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 59);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(295, 47);
            this.flowLayoutPanel2.TabIndex = 8;
            // 
            // RecursosDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "RecursosDisplay";
            this.Size = new System.Drawing.Size(1230, 138);
            ((System.ComponentModel.ISupportInitialize)(this.p_Tesoro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_Planos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_Madera)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Label lbl_Tesoro;
        private Label lbl_Planos;
        private Label lbl_Maderas;
        private PictureBox p_Tesoro;
        private PictureBox p_Planos;
        private PictureBox p_Madera;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel2;
    }
}
