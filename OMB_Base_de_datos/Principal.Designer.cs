namespace OMB_Base_de_datos
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.FormaPrincipal = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelHora = new System.Windows.Forms.Panel();
            this.txtUsuario = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Imagen_usu = new System.Windows.Forms.PictureBox();
            this.Fecha = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.hora = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Contenedor = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelHora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen_usu)).BeginInit();
            this.Contenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormaPrincipal
            // 
            this.FormaPrincipal.ElipseRadius = 5;
            this.FormaPrincipal.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, -27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1286, 632);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PanelHora
            // 
            this.PanelHora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.PanelHora.Controls.Add(this.txtUsuario);
            this.PanelHora.Controls.Add(this.Imagen_usu);
            this.PanelHora.Controls.Add(this.Fecha);
            this.PanelHora.Controls.Add(this.hora);
            this.PanelHora.Location = new System.Drawing.Point(-7, 608);
            this.PanelHora.Name = "PanelHora";
            this.PanelHora.Size = new System.Drawing.Size(1295, 126);
            this.PanelHora.TabIndex = 1;
            // 
            // txtUsuario
            // 
            this.txtUsuario.AutoSize = true;
            this.txtUsuario.Font = new System.Drawing.Font("MV Boli", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtUsuario.Location = new System.Drawing.Point(137, 38);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(186, 49);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.Text = "USUARIO";
            // 
            // Imagen_usu
            // 
            this.Imagen_usu.Image = ((System.Drawing.Image)(resources.GetObject("Imagen_usu.Image")));
            this.Imagen_usu.Location = new System.Drawing.Point(31, 9);
            this.Imagen_usu.Name = "Imagen_usu";
            this.Imagen_usu.Size = new System.Drawing.Size(115, 101);
            this.Imagen_usu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Imagen_usu.TabIndex = 2;
            this.Imagen_usu.TabStop = false;
            // 
            // Fecha
            // 
            this.Fecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Fecha.AutoSize = true;
            this.Fecha.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Fecha.Location = new System.Drawing.Point(909, 77);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(79, 25);
            this.Fecha.TabIndex = 1;
            this.Fecha.Text = "MM:SS";
            // 
            // hora
            // 
            this.hora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.hora.AutoSize = true;
            this.hora.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hora.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.hora.Location = new System.Drawing.Point(901, 14);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(190, 63);
            this.hora.TabIndex = 0;
            this.hora.Text = "MM:SS";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Contenedor
            // 
            this.Contenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Contenedor.Controls.Add(this.pictureBox1);
            this.Contenedor.Location = new System.Drawing.Point(-7, -3);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(1292, 608);
            this.Contenedor.TabIndex = 2;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.PanelHora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelHora.ResumeLayout(false);
            this.PanelHora.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen_usu)).EndInit();
            this.Contenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse FormaPrincipal;
        private System.Windows.Forms.Panel PanelHora;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel hora;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuCustomLabel Fecha;
        private System.Windows.Forms.PictureBox Imagen_usu;
        private Bunifu.Framework.UI.BunifuCustomLabel txtUsuario;
        private System.Windows.Forms.Panel Contenedor;
    }
}