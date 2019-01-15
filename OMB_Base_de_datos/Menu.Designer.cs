namespace OMB_Base_de_datos
{
    partial class Menu
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation9 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            BunifuAnimatorNS.Animation animation10 = new BunifuAnimatorNS.Animation();
            this.Herramienta = new System.Windows.Forms.Panel();
            this.Title = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TitleIcon = new System.Windows.Forms.PictureBox();
            this.Minimizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.Maximizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.Cerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.Restaurar = new Bunifu.Framework.UI.BunifuImageButton();
            this.Slide = new System.Windows.Forms.Panel();
            this.Twitter = new Bunifu.Framework.UI.BunifuImageButton();
            this.MenuSlide = new Bunifu.Framework.UI.BunifuImageButton();
            this.Web = new Bunifu.Framework.UI.BunifuImageButton();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Insta = new Bunifu.Framework.UI.BunifuImageButton();
            this.Selection = new System.Windows.Forms.Panel();
            this.Face = new Bunifu.Framework.UI.BunifuImageButton();
            this.vigenciasoat = new Bunifu.Framework.UI.BunifuFlatButton();
            this.vigenciapol = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Vehiculos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Beneficiarios = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Tomadores = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Polizas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Contenido = new System.Windows.Forms.Panel();
            this.FormaApp = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PanelSlideAni = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.Main = new System.Windows.Forms.Panel();
            this.LogoHide = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.Herramienta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TitleIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).BeginInit();
            this.Slide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Twitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSlide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Web)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Insta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Face)).BeginInit();
            this.Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // Herramienta
            // 
            this.Herramienta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Herramienta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.Herramienta.Controls.Add(this.Title);
            this.Herramienta.Controls.Add(this.TitleIcon);
            this.Herramienta.Controls.Add(this.Minimizar);
            this.Herramienta.Controls.Add(this.Maximizar);
            this.Herramienta.Controls.Add(this.Cerrar);
            this.Herramienta.Controls.Add(this.Restaurar);
            this.LogoHide.SetDecoration(this.Herramienta, BunifuAnimatorNS.DecorationType.None);
            this.PanelSlideAni.SetDecoration(this.Herramienta, BunifuAnimatorNS.DecorationType.None);
            this.Herramienta.Location = new System.Drawing.Point(0, -1);
            this.Herramienta.Name = "Herramienta";
            this.Herramienta.Size = new System.Drawing.Size(1281, 54);
            this.Herramienta.TabIndex = 0;
            this.Herramienta.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Herramienta_MouseDown);
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Title.AutoSize = true;
            this.PanelSlideAni.SetDecoration(this.Title, BunifuAnimatorNS.DecorationType.None);
            this.LogoHide.SetDecoration(this.Title, BunifuAnimatorNS.DecorationType.None);
            this.Title.Font = new System.Drawing.Font("Roboto Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Title.Location = new System.Drawing.Point(311, 11);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(345, 35);
            this.Title.TabIndex = 5;
            this.Title.Text = "Aplicativo OMB SEGUROS";
            // 
            // TitleIcon
            // 
            this.PanelSlideAni.SetDecoration(this.TitleIcon, BunifuAnimatorNS.DecorationType.None);
            this.LogoHide.SetDecoration(this.TitleIcon, BunifuAnimatorNS.DecorationType.None);
            this.TitleIcon.Image = ((System.Drawing.Image)(resources.GetObject("TitleIcon.Image")));
            this.TitleIcon.Location = new System.Drawing.Point(280, 12);
            this.TitleIcon.Name = "TitleIcon";
            this.TitleIcon.Size = new System.Drawing.Size(31, 35);
            this.TitleIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TitleIcon.TabIndex = 4;
            this.TitleIcon.TabStop = false;
            // 
            // Minimizar
            // 
            this.Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoHide.SetDecoration(this.Minimizar, BunifuAnimatorNS.DecorationType.None);
            this.PanelSlideAni.SetDecoration(this.Minimizar, BunifuAnimatorNS.DecorationType.None);
            this.Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Minimizar.Image")));
            this.Minimizar.ImageActive = null;
            this.Minimizar.Location = new System.Drawing.Point(1142, 9);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(38, 38);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimizar.TabIndex = 2;
            this.Minimizar.TabStop = false;
            this.Minimizar.Zoom = 10;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Maximizar
            // 
            this.Maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maximizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.Maximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoHide.SetDecoration(this.Maximizar, BunifuAnimatorNS.DecorationType.None);
            this.PanelSlideAni.SetDecoration(this.Maximizar, BunifuAnimatorNS.DecorationType.None);
            this.Maximizar.Image = ((System.Drawing.Image)(resources.GetObject("Maximizar.Image")));
            this.Maximizar.ImageActive = null;
            this.Maximizar.Location = new System.Drawing.Point(1186, 9);
            this.Maximizar.Name = "Maximizar";
            this.Maximizar.Size = new System.Drawing.Size(38, 38);
            this.Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Maximizar.TabIndex = 1;
            this.Maximizar.TabStop = false;
            this.Maximizar.Zoom = 10;
            this.Maximizar.Click += new System.EventHandler(this.Maximizar_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoHide.SetDecoration(this.Cerrar, BunifuAnimatorNS.DecorationType.None);
            this.PanelSlideAni.SetDecoration(this.Cerrar, BunifuAnimatorNS.DecorationType.None);
            this.Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Cerrar.Image")));
            this.Cerrar.ImageActive = null;
            this.Cerrar.Location = new System.Drawing.Point(1230, 9);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(38, 38);
            this.Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Cerrar.TabIndex = 0;
            this.Cerrar.TabStop = false;
            this.Cerrar.Zoom = 10;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // Restaurar
            // 
            this.Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Restaurar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.LogoHide.SetDecoration(this.Restaurar, BunifuAnimatorNS.DecorationType.None);
            this.PanelSlideAni.SetDecoration(this.Restaurar, BunifuAnimatorNS.DecorationType.None);
            this.Restaurar.Image = ((System.Drawing.Image)(resources.GetObject("Restaurar.Image")));
            this.Restaurar.ImageActive = null;
            this.Restaurar.Location = new System.Drawing.Point(1186, 9);
            this.Restaurar.Name = "Restaurar";
            this.Restaurar.Size = new System.Drawing.Size(38, 38);
            this.Restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Restaurar.TabIndex = 3;
            this.Restaurar.TabStop = false;
            this.Restaurar.Zoom = 10;
            this.Restaurar.Click += new System.EventHandler(this.Restaurar_Click);
            // 
            // Slide
            // 
            this.Slide.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Slide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.Slide.Controls.Add(this.Twitter);
            this.Slide.Controls.Add(this.MenuSlide);
            this.Slide.Controls.Add(this.Web);
            this.Slide.Controls.Add(this.Logo);
            this.Slide.Controls.Add(this.Insta);
            this.Slide.Controls.Add(this.Selection);
            this.Slide.Controls.Add(this.Face);
            this.Slide.Controls.Add(this.vigenciasoat);
            this.Slide.Controls.Add(this.vigenciapol);
            this.Slide.Controls.Add(this.Vehiculos);
            this.Slide.Controls.Add(this.Beneficiarios);
            this.Slide.Controls.Add(this.Tomadores);
            this.Slide.Controls.Add(this.Polizas);
            this.LogoHide.SetDecoration(this.Slide, BunifuAnimatorNS.DecorationType.None);
            this.PanelSlideAni.SetDecoration(this.Slide, BunifuAnimatorNS.DecorationType.None);
            this.Slide.Location = new System.Drawing.Point(0, 0);
            this.Slide.Name = "Slide";
            this.Slide.Size = new System.Drawing.Size(272, 667);
            this.Slide.TabIndex = 1;
            // 
            // Twitter
            // 
            this.Twitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Twitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.LogoHide.SetDecoration(this.Twitter, BunifuAnimatorNS.DecorationType.None);
            this.PanelSlideAni.SetDecoration(this.Twitter, BunifuAnimatorNS.DecorationType.None);
            this.Twitter.Image = ((System.Drawing.Image)(resources.GetObject("Twitter.Image")));
            this.Twitter.ImageActive = null;
            this.Twitter.Location = new System.Drawing.Point(197, 639);
            this.Twitter.Name = "Twitter";
            this.Twitter.Size = new System.Drawing.Size(43, 22);
            this.Twitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Twitter.TabIndex = 18;
            this.Twitter.TabStop = false;
            this.Twitter.Zoom = 10;
            // 
            // MenuSlide
            // 
            this.MenuSlide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MenuSlide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.MenuSlide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoHide.SetDecoration(this.MenuSlide, BunifuAnimatorNS.DecorationType.None);
            this.PanelSlideAni.SetDecoration(this.MenuSlide, BunifuAnimatorNS.DecorationType.None);
            this.MenuSlide.Image = ((System.Drawing.Image)(resources.GetObject("MenuSlide.Image")));
            this.MenuSlide.ImageActive = null;
            this.MenuSlide.Location = new System.Drawing.Point(230, 163);
            this.MenuSlide.Name = "MenuSlide";
            this.MenuSlide.Size = new System.Drawing.Size(31, 40);
            this.MenuSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MenuSlide.TabIndex = 7;
            this.MenuSlide.TabStop = false;
            this.MenuSlide.Zoom = 10;
            this.MenuSlide.Click += new System.EventHandler(this.MenuSlide_Click);
            // 
            // Web
            // 
            this.Web.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Web.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.LogoHide.SetDecoration(this.Web, BunifuAnimatorNS.DecorationType.None);
            this.PanelSlideAni.SetDecoration(this.Web, BunifuAnimatorNS.DecorationType.None);
            this.Web.Image = ((System.Drawing.Image)(resources.GetObject("Web.Image")));
            this.Web.ImageActive = null;
            this.Web.Location = new System.Drawing.Point(148, 639);
            this.Web.Name = "Web";
            this.Web.Size = new System.Drawing.Size(43, 22);
            this.Web.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Web.TabIndex = 15;
            this.Web.TabStop = false;
            this.Web.Zoom = 10;
            this.Web.Click += new System.EventHandler(this.Web_Click);
            // 
            // Logo
            // 
            this.Logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelSlideAni.SetDecoration(this.Logo, BunifuAnimatorNS.DecorationType.None);
            this.LogoHide.SetDecoration(this.Logo, BunifuAnimatorNS.DecorationType.None);
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(3, 29);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(260, 106);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 6;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // Insta
            // 
            this.Insta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Insta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.LogoHide.SetDecoration(this.Insta, BunifuAnimatorNS.DecorationType.None);
            this.PanelSlideAni.SetDecoration(this.Insta, BunifuAnimatorNS.DecorationType.None);
            this.Insta.Image = ((System.Drawing.Image)(resources.GetObject("Insta.Image")));
            this.Insta.ImageActive = null;
            this.Insta.Location = new System.Drawing.Point(50, 639);
            this.Insta.Name = "Insta";
            this.Insta.Size = new System.Drawing.Size(43, 22);
            this.Insta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Insta.TabIndex = 17;
            this.Insta.TabStop = false;
            this.Insta.Zoom = 10;
            // 
            // Selection
            // 
            this.Selection.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.LogoHide.SetDecoration(this.Selection, BunifuAnimatorNS.DecorationType.None);
            this.PanelSlideAni.SetDecoration(this.Selection, BunifuAnimatorNS.DecorationType.None);
            this.Selection.Location = new System.Drawing.Point(0, 218);
            this.Selection.Name = "Selection";
            this.Selection.Size = new System.Drawing.Size(10, 59);
            this.Selection.TabIndex = 0;
            // 
            // Face
            // 
            this.Face.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Face.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.LogoHide.SetDecoration(this.Face, BunifuAnimatorNS.DecorationType.None);
            this.PanelSlideAni.SetDecoration(this.Face, BunifuAnimatorNS.DecorationType.None);
            this.Face.Image = ((System.Drawing.Image)(resources.GetObject("Face.Image")));
            this.Face.ImageActive = null;
            this.Face.Location = new System.Drawing.Point(99, 639);
            this.Face.Name = "Face";
            this.Face.Size = new System.Drawing.Size(43, 22);
            this.Face.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Face.TabIndex = 16;
            this.Face.TabStop = false;
            this.Face.Zoom = 10;
            // 
            // vigenciasoat
            // 
            this.vigenciasoat.Activecolor = System.Drawing.SystemColors.Highlight;
            this.vigenciasoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.vigenciasoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.vigenciasoat.BorderRadius = 0;
            this.vigenciasoat.ButtonText = "Vigencia SOATS";
            this.vigenciasoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelSlideAni.SetDecoration(this.vigenciasoat, BunifuAnimatorNS.DecorationType.None);
            this.LogoHide.SetDecoration(this.vigenciasoat, BunifuAnimatorNS.DecorationType.None);
            this.vigenciasoat.DisabledColor = System.Drawing.Color.Gray;
            this.vigenciasoat.Iconcolor = System.Drawing.Color.Transparent;
            this.vigenciasoat.Iconimage = ((System.Drawing.Image)(resources.GetObject("vigenciasoat.Iconimage")));
            this.vigenciasoat.Iconimage_right = null;
            this.vigenciasoat.Iconimage_right_Selected = null;
            this.vigenciasoat.Iconimage_Selected = null;
            this.vigenciasoat.IconMarginLeft = 0;
            this.vigenciasoat.IconMarginRight = 0;
            this.vigenciasoat.IconRightVisible = true;
            this.vigenciasoat.IconRightZoom = 0D;
            this.vigenciasoat.IconVisible = true;
            this.vigenciasoat.IconZoom = 60D;
            this.vigenciasoat.IsTab = false;
            this.vigenciasoat.Location = new System.Drawing.Point(0, 565);
            this.vigenciasoat.Name = "vigenciasoat";
            this.vigenciasoat.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.vigenciasoat.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.vigenciasoat.OnHoverTextColor = System.Drawing.Color.White;
            this.vigenciasoat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.vigenciasoat.selected = false;
            this.vigenciasoat.Size = new System.Drawing.Size(279, 64);
            this.vigenciasoat.TabIndex = 5;
            this.vigenciasoat.Text = "Vigencia SOATS";
            this.vigenciasoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vigenciasoat.Textcolor = System.Drawing.Color.White;
            this.vigenciasoat.TextFont = new System.Drawing.Font("Roboto Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vigenciasoat.Click += new System.EventHandler(this.vigenciasoat_Click);
            // 
            // vigenciapol
            // 
            this.vigenciapol.Activecolor = System.Drawing.SystemColors.Highlight;
            this.vigenciapol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.vigenciapol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.vigenciapol.BorderRadius = 0;
            this.vigenciapol.ButtonText = "Vigencias polizas";
            this.vigenciapol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelSlideAni.SetDecoration(this.vigenciapol, BunifuAnimatorNS.DecorationType.None);
            this.LogoHide.SetDecoration(this.vigenciapol, BunifuAnimatorNS.DecorationType.None);
            this.vigenciapol.DisabledColor = System.Drawing.Color.Gray;
            this.vigenciapol.Iconcolor = System.Drawing.Color.Transparent;
            this.vigenciapol.Iconimage = ((System.Drawing.Image)(resources.GetObject("vigenciapol.Iconimage")));
            this.vigenciapol.Iconimage_right = null;
            this.vigenciapol.Iconimage_right_Selected = null;
            this.vigenciapol.Iconimage_Selected = null;
            this.vigenciapol.IconMarginLeft = 0;
            this.vigenciapol.IconMarginRight = 0;
            this.vigenciapol.IconRightVisible = true;
            this.vigenciapol.IconRightZoom = 0D;
            this.vigenciapol.IconVisible = true;
            this.vigenciapol.IconZoom = 60D;
            this.vigenciapol.IsTab = false;
            this.vigenciapol.Location = new System.Drawing.Point(0, 495);
            this.vigenciapol.Name = "vigenciapol";
            this.vigenciapol.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.vigenciapol.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.vigenciapol.OnHoverTextColor = System.Drawing.Color.White;
            this.vigenciapol.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.vigenciapol.selected = false;
            this.vigenciapol.Size = new System.Drawing.Size(279, 64);
            this.vigenciapol.TabIndex = 4;
            this.vigenciapol.Text = "Vigencias polizas";
            this.vigenciapol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vigenciapol.Textcolor = System.Drawing.Color.White;
            this.vigenciapol.TextFont = new System.Drawing.Font("Roboto Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vigenciapol.Click += new System.EventHandler(this.vigenciapol_Click);
            // 
            // Vehiculos
            // 
            this.Vehiculos.Activecolor = System.Drawing.SystemColors.Highlight;
            this.Vehiculos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.Vehiculos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Vehiculos.BorderRadius = 0;
            this.Vehiculos.ButtonText = "Vehiculos";
            this.Vehiculos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelSlideAni.SetDecoration(this.Vehiculos, BunifuAnimatorNS.DecorationType.None);
            this.LogoHide.SetDecoration(this.Vehiculos, BunifuAnimatorNS.DecorationType.None);
            this.Vehiculos.DisabledColor = System.Drawing.Color.Gray;
            this.Vehiculos.Iconcolor = System.Drawing.Color.Transparent;
            this.Vehiculos.Iconimage = ((System.Drawing.Image)(resources.GetObject("Vehiculos.Iconimage")));
            this.Vehiculos.Iconimage_right = null;
            this.Vehiculos.Iconimage_right_Selected = null;
            this.Vehiculos.Iconimage_Selected = null;
            this.Vehiculos.IconMarginLeft = 0;
            this.Vehiculos.IconMarginRight = 0;
            this.Vehiculos.IconRightVisible = true;
            this.Vehiculos.IconRightZoom = 0D;
            this.Vehiculos.IconVisible = true;
            this.Vehiculos.IconZoom = 60D;
            this.Vehiculos.IsTab = false;
            this.Vehiculos.Location = new System.Drawing.Point(0, 425);
            this.Vehiculos.Name = "Vehiculos";
            this.Vehiculos.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.Vehiculos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Vehiculos.OnHoverTextColor = System.Drawing.Color.White;
            this.Vehiculos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Vehiculos.selected = false;
            this.Vehiculos.Size = new System.Drawing.Size(279, 64);
            this.Vehiculos.TabIndex = 3;
            this.Vehiculos.Text = "Vehiculos";
            this.Vehiculos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Vehiculos.Textcolor = System.Drawing.Color.White;
            this.Vehiculos.TextFont = new System.Drawing.Font("Roboto Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vehiculos.Click += new System.EventHandler(this.Vehiculos_Click);
            // 
            // Beneficiarios
            // 
            this.Beneficiarios.Activecolor = System.Drawing.SystemColors.Highlight;
            this.Beneficiarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.Beneficiarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Beneficiarios.BorderRadius = 0;
            this.Beneficiarios.ButtonText = "Beneficiarios";
            this.Beneficiarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelSlideAni.SetDecoration(this.Beneficiarios, BunifuAnimatorNS.DecorationType.None);
            this.LogoHide.SetDecoration(this.Beneficiarios, BunifuAnimatorNS.DecorationType.None);
            this.Beneficiarios.DisabledColor = System.Drawing.Color.Gray;
            this.Beneficiarios.Iconcolor = System.Drawing.Color.Transparent;
            this.Beneficiarios.Iconimage = ((System.Drawing.Image)(resources.GetObject("Beneficiarios.Iconimage")));
            this.Beneficiarios.Iconimage_right = null;
            this.Beneficiarios.Iconimage_right_Selected = null;
            this.Beneficiarios.Iconimage_Selected = null;
            this.Beneficiarios.IconMarginLeft = 0;
            this.Beneficiarios.IconMarginRight = 0;
            this.Beneficiarios.IconRightVisible = true;
            this.Beneficiarios.IconRightZoom = 0D;
            this.Beneficiarios.IconVisible = true;
            this.Beneficiarios.IconZoom = 60D;
            this.Beneficiarios.IsTab = false;
            this.Beneficiarios.Location = new System.Drawing.Point(0, 355);
            this.Beneficiarios.Name = "Beneficiarios";
            this.Beneficiarios.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.Beneficiarios.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Beneficiarios.OnHoverTextColor = System.Drawing.Color.White;
            this.Beneficiarios.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Beneficiarios.selected = false;
            this.Beneficiarios.Size = new System.Drawing.Size(279, 64);
            this.Beneficiarios.TabIndex = 2;
            this.Beneficiarios.Text = "Beneficiarios";
            this.Beneficiarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Beneficiarios.Textcolor = System.Drawing.Color.White;
            this.Beneficiarios.TextFont = new System.Drawing.Font("Roboto Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Beneficiarios.Click += new System.EventHandler(this.Beneficiarios_Click);
            // 
            // Tomadores
            // 
            this.Tomadores.Activecolor = System.Drawing.SystemColors.Highlight;
            this.Tomadores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.Tomadores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Tomadores.BorderRadius = 0;
            this.Tomadores.ButtonText = "Tomadores";
            this.Tomadores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelSlideAni.SetDecoration(this.Tomadores, BunifuAnimatorNS.DecorationType.None);
            this.LogoHide.SetDecoration(this.Tomadores, BunifuAnimatorNS.DecorationType.None);
            this.Tomadores.DisabledColor = System.Drawing.Color.Gray;
            this.Tomadores.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tomadores.Iconcolor = System.Drawing.Color.Transparent;
            this.Tomadores.Iconimage = ((System.Drawing.Image)(resources.GetObject("Tomadores.Iconimage")));
            this.Tomadores.Iconimage_right = null;
            this.Tomadores.Iconimage_right_Selected = null;
            this.Tomadores.Iconimage_Selected = null;
            this.Tomadores.IconMarginLeft = 0;
            this.Tomadores.IconMarginRight = 0;
            this.Tomadores.IconRightVisible = true;
            this.Tomadores.IconRightZoom = 0D;
            this.Tomadores.IconVisible = true;
            this.Tomadores.IconZoom = 60D;
            this.Tomadores.IsTab = false;
            this.Tomadores.Location = new System.Drawing.Point(0, 285);
            this.Tomadores.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Tomadores.Name = "Tomadores";
            this.Tomadores.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.Tomadores.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Tomadores.OnHoverTextColor = System.Drawing.Color.White;
            this.Tomadores.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Tomadores.selected = false;
            this.Tomadores.Size = new System.Drawing.Size(279, 64);
            this.Tomadores.TabIndex = 1;
            this.Tomadores.Text = "Tomadores";
            this.Tomadores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tomadores.Textcolor = System.Drawing.Color.White;
            this.Tomadores.TextFont = new System.Drawing.Font("Roboto Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tomadores.Click += new System.EventHandler(this.Tomadores_Click);
            // 
            // Polizas
            // 
            this.Polizas.Activecolor = System.Drawing.SystemColors.Highlight;
            this.Polizas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.Polizas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Polizas.BorderRadius = 0;
            this.Polizas.ButtonText = "Listado de polizas";
            this.Polizas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelSlideAni.SetDecoration(this.Polizas, BunifuAnimatorNS.DecorationType.None);
            this.LogoHide.SetDecoration(this.Polizas, BunifuAnimatorNS.DecorationType.None);
            this.Polizas.DisabledColor = System.Drawing.Color.Gray;
            this.Polizas.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Polizas.Iconcolor = System.Drawing.Color.Transparent;
            this.Polizas.Iconimage = ((System.Drawing.Image)(resources.GetObject("Polizas.Iconimage")));
            this.Polizas.Iconimage_right = null;
            this.Polizas.Iconimage_right_Selected = null;
            this.Polizas.Iconimage_Selected = null;
            this.Polizas.IconMarginLeft = 0;
            this.Polizas.IconMarginRight = 0;
            this.Polizas.IconRightVisible = true;
            this.Polizas.IconRightZoom = 0D;
            this.Polizas.IconVisible = true;
            this.Polizas.IconZoom = 60D;
            this.Polizas.IsTab = false;
            this.Polizas.Location = new System.Drawing.Point(0, 215);
            this.Polizas.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Polizas.Name = "Polizas";
            this.Polizas.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.Polizas.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Polizas.OnHoverTextColor = System.Drawing.Color.White;
            this.Polizas.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Polizas.selected = false;
            this.Polizas.Size = new System.Drawing.Size(279, 64);
            this.Polizas.TabIndex = 0;
            this.Polizas.Text = "Listado de polizas";
            this.Polizas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Polizas.Textcolor = System.Drawing.Color.White;
            this.Polizas.TextFont = new System.Drawing.Font("Roboto Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Polizas.Click += new System.EventHandler(this.Polizas_Click);
            // 
            // Contenido
            // 
            this.Contenido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Contenido.BackColor = System.Drawing.Color.White;
            this.LogoHide.SetDecoration(this.Contenido, BunifuAnimatorNS.DecorationType.None);
            this.PanelSlideAni.SetDecoration(this.Contenido, BunifuAnimatorNS.DecorationType.None);
            this.Contenido.Location = new System.Drawing.Point(273, 3);
            this.Contenido.Name = "Contenido";
            this.Contenido.Size = new System.Drawing.Size(1008, 667);
            this.Contenido.TabIndex = 2;
            // 
            // FormaApp
            // 
            this.FormaApp.ElipseRadius = 5;
            this.FormaApp.TargetControl = this;
            // 
            // PanelSlideAni
            // 
            this.PanelSlideAni.AnimationType = BunifuAnimatorNS.AnimationType.HorizBlind;
            this.PanelSlideAni.Cursor = null;
            animation9.AnimateOnlyDifferences = true;
            animation9.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.BlindCoeff")));
            animation9.LeafCoeff = 0F;
            animation9.MaxTime = 1F;
            animation9.MinTime = 0F;
            animation9.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.MosaicCoeff")));
            animation9.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation9.MosaicShift")));
            animation9.MosaicSize = 0;
            animation9.Padding = new System.Windows.Forms.Padding(0);
            animation9.RotateCoeff = 0F;
            animation9.RotateLimit = 0F;
            animation9.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.ScaleCoeff")));
            animation9.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.SlideCoeff")));
            animation9.TimeCoeff = 0F;
            animation9.TransparencyCoeff = 0F;
            this.PanelSlideAni.DefaultAnimation = animation9;
            // 
            // Main
            // 
            this.Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Main.Controls.Add(this.Slide);
            this.Main.Controls.Add(this.Contenido);
            this.LogoHide.SetDecoration(this.Main, BunifuAnimatorNS.DecorationType.None);
            this.PanelSlideAni.SetDecoration(this.Main, BunifuAnimatorNS.DecorationType.None);
            this.Main.Location = new System.Drawing.Point(0, 53);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(1281, 670);
            this.Main.TabIndex = 3;
            // 
            // LogoHide
            // 
            this.LogoHide.AnimationType = BunifuAnimatorNS.AnimationType.VertBlind;
            this.LogoHide.Cursor = null;
            animation10.AnimateOnlyDifferences = true;
            animation10.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation10.BlindCoeff")));
            animation10.LeafCoeff = 0F;
            animation10.MaxTime = 1F;
            animation10.MinTime = 0F;
            animation10.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation10.MosaicCoeff")));
            animation10.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation10.MosaicShift")));
            animation10.MosaicSize = 0;
            animation10.Padding = new System.Windows.Forms.Padding(0);
            animation10.RotateCoeff = 0F;
            animation10.RotateLimit = 0F;
            animation10.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation10.ScaleCoeff")));
            animation10.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation10.SlideCoeff")));
            animation10.TimeCoeff = 0F;
            animation10.TransparencyCoeff = 0F;
            this.LogoHide.DefaultAnimation = animation10;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.Main);
            this.Controls.Add(this.Herramienta);
            this.LogoHide.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.PanelSlideAni.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Opacity = 0.98D;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.Herramienta.ResumeLayout(false);
            this.Herramienta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TitleIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).EndInit();
            this.Slide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Twitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSlide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Web)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Insta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Face)).EndInit();
            this.Main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Herramienta;
        private System.Windows.Forms.Panel Slide;
        private Bunifu.Framework.UI.BunifuImageButton Cerrar;
        private Bunifu.Framework.UI.BunifuImageButton Maximizar;
        private Bunifu.Framework.UI.BunifuImageButton Minimizar;
        private Bunifu.Framework.UI.BunifuImageButton Restaurar;
        private Bunifu.Framework.UI.BunifuFlatButton Polizas;
        private Bunifu.Framework.UI.BunifuFlatButton Tomadores;
        private Bunifu.Framework.UI.BunifuFlatButton Beneficiarios;
        private Bunifu.Framework.UI.BunifuFlatButton vigenciasoat;
        private Bunifu.Framework.UI.BunifuFlatButton vigenciapol;
        private Bunifu.Framework.UI.BunifuFlatButton Vehiculos;
        private System.Windows.Forms.Panel Selection;
        private System.Windows.Forms.PictureBox Logo;
        private Bunifu.Framework.UI.BunifuImageButton MenuSlide;
        private Bunifu.Framework.UI.BunifuElipse FormaApp;
        private BunifuAnimatorNS.BunifuTransition LogoHide;
        private BunifuAnimatorNS.BunifuTransition PanelSlideAni;
        private System.Windows.Forms.PictureBox TitleIcon;
        private Bunifu.Framework.UI.BunifuCustomLabel Title;
        public System.Windows.Forms.Panel Contenido;
        private System.Windows.Forms.Panel Main;
        private Bunifu.Framework.UI.BunifuImageButton Twitter;
        private Bunifu.Framework.UI.BunifuImageButton Insta;
        private Bunifu.Framework.UI.BunifuImageButton Face;
        private Bunifu.Framework.UI.BunifuImageButton Web;
    }
}

