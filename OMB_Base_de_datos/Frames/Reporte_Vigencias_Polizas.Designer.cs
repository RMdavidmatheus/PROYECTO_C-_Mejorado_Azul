namespace OMB_Base_de_datos.Frames
{
    partial class Reporte_Vigencias_Polizas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reporte_Vigencias_Polizas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.FormaApp = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Cabeza = new System.Windows.Forms.Panel();
            this.BuscarMes = new System.Windows.Forms.Button();
            this.Mes = new System.Windows.Forms.ComboBox();
            this.PdfVeh = new System.Windows.Forms.Button();
            this.IconoBuscar = new System.Windows.Forms.PictureBox();
            this.Buscar = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ListadoPolizas = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Cabeza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconoBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoPolizas)).BeginInit();
            this.SuspendLayout();
            // 
            // FormaApp
            // 
            this.FormaApp.ElipseRadius = 6;
            this.FormaApp.TargetControl = this;
            // 
            // Cabeza
            // 
            this.Cabeza.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cabeza.Controls.Add(this.BuscarMes);
            this.Cabeza.Controls.Add(this.Mes);
            this.Cabeza.Controls.Add(this.PdfVeh);
            this.Cabeza.Controls.Add(this.IconoBuscar);
            this.Cabeza.Controls.Add(this.Buscar);
            this.Cabeza.Location = new System.Drawing.Point(-1, -3);
            this.Cabeza.Name = "Cabeza";
            this.Cabeza.Size = new System.Drawing.Size(1283, 149);
            this.Cabeza.TabIndex = 8;
            // 
            // BuscarMes
            // 
            this.BuscarMes.FlatAppearance.BorderSize = 0;
            this.BuscarMes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.BuscarMes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BuscarMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuscarMes.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarMes.Image = ((System.Drawing.Image)(resources.GetObject("BuscarMes.Image")));
            this.BuscarMes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarMes.Location = new System.Drawing.Point(594, 102);
            this.BuscarMes.Name = "BuscarMes";
            this.BuscarMes.Size = new System.Drawing.Size(152, 44);
            this.BuscarMes.TabIndex = 5;
            this.BuscarMes.Text = "Buscar";
            this.BuscarMes.UseVisualStyleBackColor = true;
            this.BuscarMes.Click += new System.EventHandler(this.BuscarMes_Click);
            // 
            // Mes
            // 
            this.Mes.BackColor = System.Drawing.Color.Gainsboro;
            this.Mes.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mes.FormattingEnabled = true;
            this.Mes.Items.AddRange(new object[] {
            "ENERO",
            "FEBRERO",
            "MARZO",
            "ABRIL",
            "MAYO",
            "JUNIO",
            "JULIO",
            "AGOSTO",
            "SEPTIEMBRE",
            "OCTUBRE",
            "NOVIEMBRE",
            "DICIEMBRE"});
            this.Mes.Location = new System.Drawing.Point(290, 107);
            this.Mes.Name = "Mes";
            this.Mes.Size = new System.Drawing.Size(298, 36);
            this.Mes.TabIndex = 4;
            this.Mes.Text = "-- SELECCIONE UN MES --";
            // 
            // PdfVeh
            // 
            this.PdfVeh.FlatAppearance.BorderSize = 0;
            this.PdfVeh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.PdfVeh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.PdfVeh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PdfVeh.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PdfVeh.Image = ((System.Drawing.Image)(resources.GetObject("PdfVeh.Image")));
            this.PdfVeh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PdfVeh.Location = new System.Drawing.Point(7, 102);
            this.PdfVeh.Name = "PdfVeh";
            this.PdfVeh.Size = new System.Drawing.Size(277, 44);
            this.PdfVeh.TabIndex = 3;
            this.PdfVeh.Text = "Generar archivo PDF";
            this.PdfVeh.UseVisualStyleBackColor = true;
            this.PdfVeh.Click += new System.EventHandler(this.PdfVeh_Click);
            // 
            // IconoBuscar
            // 
            this.IconoBuscar.Image = ((System.Drawing.Image)(resources.GetObject("IconoBuscar.Image")));
            this.IconoBuscar.Location = new System.Drawing.Point(752, 102);
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
            this.Buscar.Location = new System.Drawing.Point(800, 102);
            this.Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(468, 44);
            this.Buscar.TabIndex = 0;
            this.Buscar.Text = "Buscar...";
            this.Buscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Buscar.Enter += new System.EventHandler(this.Buscar_Enter);
            this.Buscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Buscar_KeyUp);
            this.Buscar.Leave += new System.EventHandler(this.Buscar_Leave);
            // 
            // ListadoPolizas
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ListadoPolizas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ListadoPolizas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListadoPolizas.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.ListadoPolizas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListadoPolizas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListadoPolizas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ListadoPolizas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListadoPolizas.DefaultCellStyle = dataGridViewCellStyle3;
            this.ListadoPolizas.DoubleBuffered = true;
            this.ListadoPolizas.EnableHeadersVisualStyles = false;
            this.ListadoPolizas.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.ListadoPolizas.HeaderForeColor = System.Drawing.SystemColors.Control;
            this.ListadoPolizas.Location = new System.Drawing.Point(6, 152);
            this.ListadoPolizas.Name = "ListadoPolizas";
            this.ListadoPolizas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListadoPolizas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ListadoPolizas.Size = new System.Drawing.Size(1276, 571);
            this.ListadoPolizas.TabIndex = 9;
            this.ListadoPolizas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ListadoPolizas_CellFormatting);
            // 
            // Reporte_Vigencias_Polizas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.Cabeza);
            this.Controls.Add(this.ListadoPolizas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reporte_Vigencias_Polizas";
            this.Text = "Reporte_Vigencias_Polizas";
            this.Cabeza.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IconoBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoPolizas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse FormaApp;
        private System.Windows.Forms.Panel Cabeza;
        private System.Windows.Forms.Button BuscarMes;
        private System.Windows.Forms.ComboBox Mes;
        private System.Windows.Forms.Button PdfVeh;
        private System.Windows.Forms.PictureBox IconoBuscar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Buscar;
        private Bunifu.Framework.UI.BunifuCustomDataGrid ListadoPolizas;
    }
}