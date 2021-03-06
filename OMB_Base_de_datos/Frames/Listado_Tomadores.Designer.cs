﻿namespace OMB_Base_de_datos.Frames
{
    partial class Listado_Tomadores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listado_Tomadores));
            this.Forma_App = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ListadoTom = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.IconoBuscar = new System.Windows.Forms.PictureBox();
            this.Buscar = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Cabeza = new System.Windows.Forms.Panel();
            this.PdfTom = new System.Windows.Forms.Button();
            this.PanelHora = new System.Windows.Forms.Panel();
            this.txtUsuario = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Imagen_usu = new System.Windows.Forms.PictureBox();
            this.Fecha = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.hora = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ListadoTom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoBuscar)).BeginInit();
            this.Cabeza.SuspendLayout();
            this.PanelHora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen_usu)).BeginInit();
            this.SuspendLayout();
            // 
            // Forma_App
            // 
            this.Forma_App.ElipseRadius = 5;
            this.Forma_App.TargetControl = this;
            // 
            // ListadoTom
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ListadoTom.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ListadoTom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListadoTom.BackgroundColor = System.Drawing.Color.White;
            this.ListadoTom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListadoTom.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListadoTom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.ListadoTom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Roboto Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListadoTom.DefaultCellStyle = dataGridViewCellStyle7;
            this.ListadoTom.DoubleBuffered = true;
            this.ListadoTom.EnableHeadersVisualStyles = false;
            this.ListadoTom.GridColor = System.Drawing.Color.Gainsboro;
            this.ListadoTom.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.ListadoTom.HeaderForeColor = System.Drawing.SystemColors.Control;
            this.ListadoTom.Location = new System.Drawing.Point(6, 154);
            this.ListadoTom.Name = "ListadoTom";
            this.ListadoTom.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListadoTom.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.ListadoTom.Size = new System.Drawing.Size(1276, 456);
            this.ListadoTom.TabIndex = 3;
            // 
            // IconoBuscar
            // 
            this.IconoBuscar.Image = ((System.Drawing.Image)(resources.GetObject("IconoBuscar.Image")));
            this.IconoBuscar.Location = new System.Drawing.Point(406, 102);
            this.IconoBuscar.Name = "IconoBuscar";
            this.IconoBuscar.Size = new System.Drawing.Size(41, 44);
            this.IconoBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconoBuscar.TabIndex = 1;
            this.IconoBuscar.TabStop = false;
            // 
            // Buscar
            // 
            this.Buscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Buscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Buscar.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar.ForeColor = System.Drawing.Color.DimGray;
            this.Buscar.HintForeColor = System.Drawing.Color.Empty;
            this.Buscar.HintText = "";
            this.Buscar.isPassword = false;
            this.Buscar.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.Buscar.LineIdleColor = System.Drawing.Color.Gray;
            this.Buscar.LineMouseHoverColor = System.Drawing.Color.SteelBlue;
            this.Buscar.LineThickness = 5;
            this.Buscar.Location = new System.Drawing.Point(454, 102);
            this.Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(825, 44);
            this.Buscar.TabIndex = 0;
            this.Buscar.Text = "Buscar...";
            this.Buscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Buscar.Enter += new System.EventHandler(this.Buscar_Enter);
            this.Buscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Buscar_KeyUp);
            this.Buscar.Leave += new System.EventHandler(this.Buscar_Leave);
            // 
            // Cabeza
            // 
            this.Cabeza.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cabeza.BackColor = System.Drawing.Color.White;
            this.Cabeza.Controls.Add(this.PdfTom);
            this.Cabeza.Controls.Add(this.IconoBuscar);
            this.Cabeza.Controls.Add(this.Buscar);
            this.Cabeza.Location = new System.Drawing.Point(-1, -2);
            this.Cabeza.Name = "Cabeza";
            this.Cabeza.Size = new System.Drawing.Size(1283, 149);
            this.Cabeza.TabIndex = 2;
            // 
            // PdfTom
            // 
            this.PdfTom.FlatAppearance.BorderSize = 0;
            this.PdfTom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.PdfTom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.PdfTom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PdfTom.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PdfTom.Image = ((System.Drawing.Image)(resources.GetObject("PdfTom.Image")));
            this.PdfTom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PdfTom.Location = new System.Drawing.Point(7, 102);
            this.PdfTom.Name = "PdfTom";
            this.PdfTom.Size = new System.Drawing.Size(282, 44);
            this.PdfTom.TabIndex = 3;
            this.PdfTom.Text = "Generar archivo PDF";
            this.PdfTom.UseVisualStyleBackColor = true;
            this.PdfTom.Click += new System.EventHandler(this.PdfTom_Click);
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
            this.PanelHora.Location = new System.Drawing.Point(-1, 616);
            this.PanelHora.Name = "PanelHora";
            this.PanelHora.Size = new System.Drawing.Size(1295, 109);
            this.PanelHora.TabIndex = 7;
            // 
            // txtUsuario
            // 
            this.txtUsuario.AutoSize = true;
            this.txtUsuario.Font = new System.Drawing.Font("MV Boli", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtUsuario.Location = new System.Drawing.Point(136, 31);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(186, 49);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.Text = "USUARIO";
            // 
            // Imagen_usu
            // 
            this.Imagen_usu.Image = ((System.Drawing.Image)(resources.GetObject("Imagen_usu.Image")));
            this.Imagen_usu.Location = new System.Drawing.Point(31, 3);
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
            this.Fecha.Location = new System.Drawing.Point(900, 70);
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
            this.hora.Location = new System.Drawing.Point(892, 7);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(190, 63);
            this.hora.TabIndex = 0;
            this.hora.Text = "MM:SS";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Listado_Tomadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.PanelHora);
            this.Controls.Add(this.ListadoTom);
            this.Controls.Add(this.Cabeza);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Listado_Tomadores";
            this.Text = "Listado_Tomadores";
            this.Load += new System.EventHandler(this.Listado_Tomadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListadoTom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoBuscar)).EndInit();
            this.Cabeza.ResumeLayout(false);
            this.PanelHora.ResumeLayout(false);
            this.PanelHora.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen_usu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse Forma_App;
        private Bunifu.Framework.UI.BunifuCustomDataGrid ListadoTom;
        private System.Windows.Forms.Panel Cabeza;
        private System.Windows.Forms.PictureBox IconoBuscar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Buscar;
        private System.Windows.Forms.Button PdfTom;
        private System.Windows.Forms.Panel PanelHora;
        private Bunifu.Framework.UI.BunifuCustomLabel txtUsuario;
        private System.Windows.Forms.PictureBox Imagen_usu;
        private Bunifu.Framework.UI.BunifuCustomLabel Fecha;
        private Bunifu.Framework.UI.BunifuCustomLabel hora;
        private System.Windows.Forms.Timer timer1;
    }
}