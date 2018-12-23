namespace LogIn
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.FormaApp = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Contenido = new System.Windows.Forms.Panel();
            this.ErrorUsu = new System.Windows.Forms.Label();
            this.ErrorPass = new System.Windows.Forms.Label();
            this.RecuperarPassword = new System.Windows.Forms.LinkLabel();
            this.Loguear = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Pass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Usuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Minimizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.Twitter = new Bunifu.Framework.UI.BunifuImageButton();
            this.Insta = new Bunifu.Framework.UI.BunifuImageButton();
            this.Cerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.Face = new Bunifu.Framework.UI.BunifuImageButton();
            this.Web = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.IniciarSesion = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Slider = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.Contenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Twitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Insta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Face)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Web)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FormaApp
            // 
            this.FormaApp.ElipseRadius = 6;
            this.FormaApp.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.bunifuSeparator1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Slider);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-4, -9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 648);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuSeparator1.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(161, 183);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(412, 19);
            this.bunifuSeparator1.TabIndex = 3;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(242, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bienvenido";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Contenido
            // 
            this.Contenido.Controls.Add(this.Minimizar);
            this.Contenido.Controls.Add(this.Twitter);
            this.Contenido.Controls.Add(this.Insta);
            this.Contenido.Controls.Add(this.Cerrar);
            this.Contenido.Controls.Add(this.ErrorUsu);
            this.Contenido.Controls.Add(this.Face);
            this.Contenido.Controls.Add(this.Web);
            this.Contenido.Controls.Add(this.ErrorPass);
            this.Contenido.Controls.Add(this.RecuperarPassword);
            this.Contenido.Controls.Add(this.pictureBox4);
            this.Contenido.Controls.Add(this.pictureBox3);
            this.Contenido.Controls.Add(this.Loguear);
            this.Contenido.Controls.Add(this.IniciarSesion);
            this.Contenido.Controls.Add(this.pictureBox2);
            this.Contenido.Controls.Add(this.Pass);
            this.Contenido.Controls.Add(this.Usuario);
            this.Contenido.Location = new System.Drawing.Point(687, -9);
            this.Contenido.Name = "Contenido";
            this.Contenido.Size = new System.Drawing.Size(583, 648);
            this.Contenido.TabIndex = 1;
            this.Contenido.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Contenido_MouseDown);
            // 
            // ErrorUsu
            // 
            this.ErrorUsu.AutoSize = true;
            this.ErrorUsu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorUsu.ForeColor = System.Drawing.Color.Maroon;
            this.ErrorUsu.Location = new System.Drawing.Point(75, 335);
            this.ErrorUsu.Name = "ErrorUsu";
            this.ErrorUsu.Size = new System.Drawing.Size(0, 17);
            this.ErrorUsu.TabIndex = 9;
            // 
            // ErrorPass
            // 
            this.ErrorPass.AutoSize = true;
            this.ErrorPass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorPass.ForeColor = System.Drawing.Color.Maroon;
            this.ErrorPass.Location = new System.Drawing.Point(75, 438);
            this.ErrorPass.Name = "ErrorPass";
            this.ErrorPass.Size = new System.Drawing.Size(0, 17);
            this.ErrorPass.TabIndex = 8;
            // 
            // RecuperarPassword
            // 
            this.RecuperarPassword.ActiveLinkColor = System.Drawing.SystemColors.Highlight;
            this.RecuperarPassword.AutoSize = true;
            this.RecuperarPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecuperarPassword.LinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RecuperarPassword.Location = new System.Drawing.Point(215, 542);
            this.RecuperarPassword.Name = "RecuperarPassword";
            this.RecuperarPassword.Size = new System.Drawing.Size(161, 17);
            this.RecuperarPassword.TabIndex = 7;
            this.RecuperarPassword.TabStop = true;
            this.RecuperarPassword.Text = "¿Olvido su contraseña?";
            this.RecuperarPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RecuperarPassword_LinkClicked);
            // 
            // Loguear
            // 
            this.Loguear.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Loguear.BackColor = System.Drawing.Color.DarkGray;
            this.Loguear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Loguear.BorderRadius = 0;
            this.Loguear.ButtonText = "Iniciar Sesion";
            this.Loguear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Loguear.DisabledColor = System.Drawing.Color.Gray;
            this.Loguear.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loguear.Iconcolor = System.Drawing.Color.Transparent;
            this.Loguear.Iconimage = null;
            this.Loguear.Iconimage_right = null;
            this.Loguear.Iconimage_right_Selected = null;
            this.Loguear.Iconimage_Selected = null;
            this.Loguear.IconMarginLeft = 0;
            this.Loguear.IconMarginRight = 0;
            this.Loguear.IconRightVisible = true;
            this.Loguear.IconRightZoom = 0D;
            this.Loguear.IconVisible = true;
            this.Loguear.IconZoom = 90D;
            this.Loguear.IsTab = false;
            this.Loguear.Location = new System.Drawing.Point(175, 470);
            this.Loguear.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Loguear.Name = "Loguear";
            this.Loguear.Normalcolor = System.Drawing.Color.DarkGray;
            this.Loguear.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Loguear.OnHoverTextColor = System.Drawing.Color.White;
            this.Loguear.selected = false;
            this.Loguear.Size = new System.Drawing.Size(247, 69);
            this.Loguear.TabIndex = 4;
            this.Loguear.Text = "Iniciar Sesion";
            this.Loguear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Loguear.Textcolor = System.Drawing.Color.Black;
            this.Loguear.TextFont = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loguear.Click += new System.EventHandler(this.Loguear_Click);
            // 
            // Pass
            // 
            this.Pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Pass.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass.ForeColor = System.Drawing.Color.Gray;
            this.Pass.HintForeColor = System.Drawing.Color.Empty;
            this.Pass.HintText = "";
            this.Pass.isPassword = false;
            this.Pass.LineFocusedColor = System.Drawing.SystemColors.Highlight;
            this.Pass.LineIdleColor = System.Drawing.Color.Gray;
            this.Pass.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.Pass.LineThickness = 4;
            this.Pass.Location = new System.Drawing.Point(78, 376);
            this.Pass.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(454, 57);
            this.Pass.TabIndex = 1;
            this.Pass.Text = "INGRESE SU CONTRASEÑA";
            this.Pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Pass.Enter += new System.EventHandler(this.Pass_Enter);
            this.Pass.Leave += new System.EventHandler(this.Pass_Leave);
            // 
            // Usuario
            // 
            this.Usuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Usuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario.ForeColor = System.Drawing.Color.Gray;
            this.Usuario.HintForeColor = System.Drawing.Color.Empty;
            this.Usuario.HintText = "";
            this.Usuario.isPassword = false;
            this.Usuario.LineFocusedColor = System.Drawing.SystemColors.Highlight;
            this.Usuario.LineIdleColor = System.Drawing.Color.Gray;
            this.Usuario.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.Usuario.LineThickness = 4;
            this.Usuario.Location = new System.Drawing.Point(78, 273);
            this.Usuario.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(454, 57);
            this.Usuario.TabIndex = 0;
            this.Usuario.Text = "INGRESE SU USUARIO";
            this.Usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Usuario.Enter += new System.EventHandler(this.Usuario_Enter);
            this.Usuario.Leave += new System.EventHandler(this.Usuario_Leave);
            // 
            // Minimizar
            // 
            this.Minimizar.BackColor = System.Drawing.Color.Gainsboro;
            this.Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Minimizar.Image")));
            this.Minimizar.ImageActive = null;
            this.Minimizar.Location = new System.Drawing.Point(439, 19);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(60, 32);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimizar.TabIndex = 15;
            this.Minimizar.TabStop = false;
            this.Minimizar.Zoom = 10;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Twitter
            // 
            this.Twitter.BackColor = System.Drawing.Color.Gainsboro;
            this.Twitter.Image = ((System.Drawing.Image)(resources.GetObject("Twitter.Image")));
            this.Twitter.ImageActive = null;
            this.Twitter.Location = new System.Drawing.Point(348, 575);
            this.Twitter.Name = "Twitter";
            this.Twitter.Size = new System.Drawing.Size(43, 22);
            this.Twitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Twitter.TabIndex = 14;
            this.Twitter.TabStop = false;
            this.Twitter.Zoom = 10;
            this.Twitter.Click += new System.EventHandler(this.Twitter_Click);
            // 
            // Insta
            // 
            this.Insta.BackColor = System.Drawing.Color.Gainsboro;
            this.Insta.Image = ((System.Drawing.Image)(resources.GetObject("Insta.Image")));
            this.Insta.ImageActive = null;
            this.Insta.Location = new System.Drawing.Point(201, 575);
            this.Insta.Name = "Insta";
            this.Insta.Size = new System.Drawing.Size(43, 22);
            this.Insta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Insta.TabIndex = 13;
            this.Insta.TabStop = false;
            this.Insta.Zoom = 10;
            this.Insta.Click += new System.EventHandler(this.Insta_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.BackColor = System.Drawing.Color.Gainsboro;
            this.Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Cerrar.Image")));
            this.Cerrar.ImageActive = null;
            this.Cerrar.Location = new System.Drawing.Point(501, 19);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(60, 32);
            this.Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Cerrar.TabIndex = 10;
            this.Cerrar.TabStop = false;
            this.Cerrar.Zoom = 10;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // Face
            // 
            this.Face.BackColor = System.Drawing.Color.Gainsboro;
            this.Face.Image = ((System.Drawing.Image)(resources.GetObject("Face.Image")));
            this.Face.ImageActive = null;
            this.Face.Location = new System.Drawing.Point(250, 575);
            this.Face.Name = "Face";
            this.Face.Size = new System.Drawing.Size(43, 22);
            this.Face.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Face.TabIndex = 12;
            this.Face.TabStop = false;
            this.Face.Zoom = 10;
            this.Face.Click += new System.EventHandler(this.Face_Click);
            // 
            // Web
            // 
            this.Web.BackColor = System.Drawing.Color.Gainsboro;
            this.Web.Image = ((System.Drawing.Image)(resources.GetObject("Web.Image")));
            this.Web.ImageActive = null;
            this.Web.Location = new System.Drawing.Point(299, 575);
            this.Web.Name = "Web";
            this.Web.Size = new System.Drawing.Size(43, 22);
            this.Web.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Web.TabIndex = 11;
            this.Web.TabStop = false;
            this.Web.Zoom = 10;
            this.Web.Click += new System.EventHandler(this.Web_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(49, 405);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(26, 28);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(50, 304);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // IniciarSesion
            // 
            this.IniciarSesion.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.IniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.IniciarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.IniciarSesion.BorderRadius = 0;
            this.IniciarSesion.ButtonText = "bunifuFlatButton1";
            this.IniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IniciarSesion.DisabledColor = System.Drawing.Color.Gray;
            this.IniciarSesion.Iconcolor = System.Drawing.Color.Transparent;
            this.IniciarSesion.Iconimage = ((System.Drawing.Image)(resources.GetObject("IniciarSesion.Iconimage")));
            this.IniciarSesion.Iconimage_right = null;
            this.IniciarSesion.Iconimage_right_Selected = null;
            this.IniciarSesion.Iconimage_Selected = null;
            this.IniciarSesion.IconMarginLeft = 0;
            this.IniciarSesion.IconMarginRight = 0;
            this.IniciarSesion.IconRightVisible = true;
            this.IniciarSesion.IconRightZoom = 0D;
            this.IniciarSesion.IconVisible = true;
            this.IniciarSesion.IconZoom = 90D;
            this.IniciarSesion.IsTab = false;
            this.IniciarSesion.Location = new System.Drawing.Point(296, 831);
            this.IniciarSesion.Margin = new System.Windows.Forms.Padding(6);
            this.IniciarSesion.Name = "IniciarSesion";
            this.IniciarSesion.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.IniciarSesion.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.IniciarSesion.OnHoverTextColor = System.Drawing.Color.White;
            this.IniciarSesion.selected = false;
            this.IniciarSesion.Size = new System.Drawing.Size(572, 127);
            this.IniciarSesion.TabIndex = 3;
            this.IniciarSesion.Text = "bunifuFlatButton1";
            this.IniciarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IniciarSesion.Textcolor = System.Drawing.Color.White;
            this.IniciarSesion.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 59);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(577, 163);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // Slider
            // 
            this.Slider.Image = ((System.Drawing.Image)(resources.GetObject("Slider.Image")));
            this.Slider.Location = new System.Drawing.Point(14, 215);
            this.Slider.Name = "Slider";
            this.Slider.Size = new System.Drawing.Size(660, 413);
            this.Slider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Slider.TabIndex = 1;
            this.Slider.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(161, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(412, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1268, 631);
            this.Controls.Add(this.Contenido);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogIn";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Contenido.ResumeLayout(false);
            this.Contenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Twitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Insta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Face)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Web)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse FormaApp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Slider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Panel Contenido;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Usuario;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Pass;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuFlatButton IniciarSesion;
        private Bunifu.Framework.UI.BunifuFlatButton Loguear;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.LinkLabel RecuperarPassword;
        private System.Windows.Forms.Label ErrorPass;
        private System.Windows.Forms.Label ErrorUsu;
        private Bunifu.Framework.UI.BunifuImageButton Cerrar;
        private Bunifu.Framework.UI.BunifuImageButton Web;
        private Bunifu.Framework.UI.BunifuImageButton Face;
        private Bunifu.Framework.UI.BunifuImageButton Insta;
        private Bunifu.Framework.UI.BunifuImageButton Twitter;
        private Bunifu.Framework.UI.BunifuImageButton Minimizar;
    }
}