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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listado_Tomadores));
            this.Forma_App = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ListadoTom = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.IconoBuscar = new System.Windows.Forms.PictureBox();
            this.Buscar = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Cabeza = new System.Windows.Forms.Panel();
            this.PdfTom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoTom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoBuscar)).BeginInit();
            this.Cabeza.SuspendLayout();
            this.SuspendLayout();
            // 
            // Forma_App
            // 
            this.Forma_App.ElipseRadius = 5;
            this.Forma_App.TargetControl = this;
            // 
            // ListadoTom
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ListadoTom.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ListadoTom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListadoTom.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.ListadoTom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListadoTom.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListadoTom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ListadoTom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListadoTom.DefaultCellStyle = dataGridViewCellStyle3;
            this.ListadoTom.DoubleBuffered = true;
            this.ListadoTom.EnableHeadersVisualStyles = false;
            this.ListadoTom.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.ListadoTom.HeaderForeColor = System.Drawing.SystemColors.Control;
            this.ListadoTom.Location = new System.Drawing.Point(6, 154);
            this.ListadoTom.Name = "ListadoTom";
            this.ListadoTom.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListadoTom.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ListadoTom.Size = new System.Drawing.Size(1276, 568);
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
            this.Buscar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar.ForeColor = System.Drawing.Color.DimGray;
            this.Buscar.HintForeColor = System.Drawing.Color.Empty;
            this.Buscar.HintText = "";
            this.Buscar.isPassword = false;
            this.Buscar.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.Buscar.LineIdleColor = System.Drawing.Color.Gray;
            this.Buscar.LineMouseHoverColor = System.Drawing.Color.SteelBlue;
            this.Buscar.LineThickness = 4;
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
            // Listado_Tomadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.ListadoTom);
            this.Controls.Add(this.Cabeza);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Listado_Tomadores";
            this.Text = "Listado_Tomadores";
            this.Load += new System.EventHandler(this.Listado_Tomadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListadoTom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoBuscar)).EndInit();
            this.Cabeza.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse Forma_App;
        private Bunifu.Framework.UI.BunifuCustomDataGrid ListadoTom;
        private System.Windows.Forms.Panel Cabeza;
        private System.Windows.Forms.PictureBox IconoBuscar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Buscar;
        private System.Windows.Forms.Button PdfTom;
    }
}