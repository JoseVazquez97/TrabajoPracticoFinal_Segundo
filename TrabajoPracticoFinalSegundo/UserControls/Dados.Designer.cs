namespace TrabajoPracticoFinalSegundo.UserControls
{
    partial class Dados
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
            this.components = new System.ComponentModel.Container();
            this.TirandoDados = new System.Windows.Forms.Timer(this.components);
            this.dado1 = new System.Windows.Forms.PictureBox();
            this.dado2 = new System.Windows.Forms.PictureBox();
            this.anim1 = new System.Windows.Forms.PictureBox();
            this.anim2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dado1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dado2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anim1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anim2)).BeginInit();
            this.SuspendLayout();
            // 
            // TirandoDados
            // 
            this.TirandoDados.Tick += new System.EventHandler(this.TirandoDados_Tick);
            // 
            // dado1
            // 
            this.dado1.Location = new System.Drawing.Point(180, 38);
            this.dado1.Name = "dado1";
            this.dado1.Size = new System.Drawing.Size(60, 60);
            this.dado1.TabIndex = 0;
            this.dado1.TabStop = false;
            this.dado1.Click += new System.EventHandler(this.Dados_Click);
            // 
            // dado2
            // 
            this.dado2.Location = new System.Drawing.Point(78, 38);
            this.dado2.Name = "dado2";
            this.dado2.Size = new System.Drawing.Size(60, 60);
            this.dado2.TabIndex = 1;
            this.dado2.TabStop = false;
            this.dado2.Click += new System.EventHandler(this.Dados_Click);
            // 
            // anim1
            // 
            this.anim1.Location = new System.Drawing.Point(175, 32);
            this.anim1.Name = "anim1";
            this.anim1.Size = new System.Drawing.Size(70, 70);
            this.anim1.TabIndex = 2;
            this.anim1.TabStop = false;
            this.anim1.Click += new System.EventHandler(this.Dados_Click);
            // 
            // anim2
            // 
            this.anim2.Location = new System.Drawing.Point(73, 32);
            this.anim2.Name = "anim2";
            this.anim2.Size = new System.Drawing.Size(70, 70);
            this.anim2.TabIndex = 3;
            this.anim2.TabStop = false;
            this.anim2.Click += new System.EventHandler(this.Dados_Click);
            // 
            // Dados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dado2);
            this.Controls.Add(this.anim2);
            this.Controls.Add(this.dado1);
            this.Controls.Add(this.anim1);
            this.Name = "Dados";
            this.Size = new System.Drawing.Size(321, 143);
            this.Click += new System.EventHandler(this.Dados_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dado1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dado2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anim1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anim2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer TirandoDados;
        private PictureBox dado1;
        private PictureBox dado2;
        private PictureBox anim1;
        private PictureBox anim2;
    }
}
