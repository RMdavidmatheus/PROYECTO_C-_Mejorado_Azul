namespace OMB_Base_de_datos.Frames
{
    partial class Recuperacion_pass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recuperacion_pass));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.Cerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Documento = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Recuperar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.Cerrar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-7, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 58);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // Cerrar
            // 
            this.Cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Cerrar.Image")));
            this.Cerrar.ImageActive = null;
            this.Cerrar.Location = new System.Drawing.Point(748, 11);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(37, 36);
            this.Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Cerrar.TabIndex = 2;
            this.Cerrar.TabStop = false;
            this.Cerrar.Zoom = 10;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(19, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Recuperando Contraseña";
            // 
            // Documento
            // 
            this.Documento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Documento.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Documento.ForeColor = System.Drawing.Color.Gray;
            this.Documento.HintForeColor = System.Drawing.Color.Empty;
            this.Documento.HintText = "";
            this.Documento.isPassword = false;
            this.Documento.LineFocusedColor = System.Drawing.SystemColors.Highlight;
            this.Documento.LineIdleColor = System.Drawing.Color.Gray;
            this.Documento.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.Documento.LineThickness = 4;
            this.Documento.Location = new System.Drawing.Point(25, 90);
            this.Documento.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Documento.Name = "Documento";
            this.Documento.Size = new System.Drawing.Size(426, 57);
            this.Documento.TabIndex = 2;
            this.Documento.Text = "INGRESE SU DOCUMENTO";
            this.Documento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Documento.Enter += new System.EventHandler(this.Documento_Enter);
            this.Documento.Leave += new System.EventHandler(this.Documento_Leave);
            // 
            // Recuperar
            // 
            this.Recuperar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Recuperar.BackColor = System.Drawing.Color.DarkGray;
            this.Recuperar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Recuperar.BorderRadius = 0;
            this.Recuperar.ButtonText = "Recuperar";
            this.Recuperar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Recuperar.DisabledColor = System.Drawing.Color.Gray;
            this.Recuperar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recuperar.Iconcolor = System.Drawing.Color.Transparent;
            this.Recuperar.Iconimage = null;
            this.Recuperar.Iconimage_right = null;
            this.Recuperar.Iconimage_right_Selected = null;
            this.Recuperar.Iconimage_Selected = null;
            this.Recuperar.IconMarginLeft = 0;
            this.Recuperar.IconMarginRight = 0;
            this.Recuperar.IconRightVisible = true;
            this.Recuperar.IconRightZoom = 0D;
            this.Recuperar.IconVisible = true;
            this.Recuperar.IconZoom = 90D;
            this.Recuperar.IsTab = false;
            this.Recuperar.Location = new System.Drawing.Point(510, 90);
            this.Recuperar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Recuperar.Name = "Recuperar";
            this.Recuperar.Normalcolor = System.Drawing.Color.DarkGray;
            this.Recuperar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Recuperar.OnHoverTextColor = System.Drawing.Color.White;
            this.Recuperar.selected = false;
            this.Recuperar.Size = new System.Drawing.Size(241, 57);
            this.Recuperar.TabIndex = 1;
            this.Recuperar.Text = "Recuperar";
            this.Recuperar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Recuperar.Textcolor = System.Drawing.Color.Black;
            this.Recuperar.TextFont = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recuperar.Click += new System.EventHandler(this.Recuperar_Click);
            // 
            // txtMensaje
            // 
            this.txtMensaje.BackColor = System.Drawing.Color.Gainsboro;
            this.txtMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMensaje.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensaje.ForeColor = System.Drawing.Color.Maroon;
            this.txtMensaje.Location = new System.Drawing.Point(25, 155);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.ReadOnly = true;
            this.txtMensaje.Size = new System.Drawing.Size(426, 253);
            this.txtMensaje.TabIndex = 3;
            // 
            // Recuperacion_pass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.Recuperar);
            this.Controls.Add(this.Documento);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Recuperacion_pass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recuperacion_pass";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton Cerrar;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Documento;
        private Bunifu.Framework.UI.BunifuFlatButton Recuperar;
        private System.Windows.Forms.TextBox txtMensaje;
    }
}