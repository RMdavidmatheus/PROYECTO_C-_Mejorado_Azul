namespace OMB_Base_de_datos.Frames
{
    partial class Listado_polizas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listado_polizas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Cabeza = new System.Windows.Forms.Panel();
            this.Eliminar = new System.Windows.Forms.Button();
            this.Editar = new System.Windows.Forms.Button();
            this.Anadir = new System.Windows.Forms.Button();
            this.IconoBuscar = new System.Windows.Forms.PictureBox();
            this.Buscar = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Listado = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.FormaApp = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PanelHora = new System.Windows.Forms.Panel();
            this.txtUsuario = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Imagen_usu = new System.Windows.Forms.PictureBox();
            this.Fecha = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.hora = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Cabeza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconoBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Listado)).BeginInit();
            this.PanelHora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen_usu)).BeginInit();
            this.SuspendLayout();
            // 
            // Cabeza
            // 
            this.Cabeza.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cabeza.Controls.Add(this.Eliminar);
            this.Cabeza.Controls.Add(this.Editar);
            this.Cabeza.Controls.Add(this.Anadir);
            this.Cabeza.Controls.Add(this.IconoBuscar);
            this.Cabeza.Controls.Add(this.Buscar);
            this.Cabeza.Location = new System.Drawing.Point(-4, 3);
            this.Cabeza.Name = "Cabeza";
            this.Cabeza.Size = new System.Drawing.Size(1283, 149);
            this.Cabeza.TabIndex = 0;
            // 
            // Eliminar
            // 
            this.Eliminar.FlatAppearance.BorderSize = 0;
            this.Eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.Eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eliminar.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminar.Location = new System.Drawing.Point(438, 101);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(205, 44);
            this.Eliminar.TabIndex = 4;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // Editar
            // 
            this.Editar.FlatAppearance.BorderSize = 0;
            this.Editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.Editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Editar.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Editar.Location = new System.Drawing.Point(227, 101);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(205, 44);
            this.Editar.TabIndex = 3;
            this.Editar.Text = "Editar Poliza";
            this.Editar.UseVisualStyleBackColor = true;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // Anadir
            // 
            this.Anadir.FlatAppearance.BorderSize = 0;
            this.Anadir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.Anadir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Anadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Anadir.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Anadir.Image = ((System.Drawing.Image)(resources.GetObject("Anadir.Image")));
            this.Anadir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Anadir.Location = new System.Drawing.Point(16, 101);
            this.Anadir.Name = "Anadir";
            this.Anadir.Size = new System.Drawing.Size(205, 44);
            this.Anadir.TabIndex = 2;
            this.Anadir.Text = "Añadir Poliza";
            this.Anadir.UseVisualStyleBackColor = true;
            this.Anadir.Click += new System.EventHandler(this.Añadir_Click);
            // 
            // IconoBuscar
            // 
            this.IconoBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconoBuscar.Image = ((System.Drawing.Image)(resources.GetObject("IconoBuscar.Image")));
            this.IconoBuscar.Location = new System.Drawing.Point(918, 101);
            this.IconoBuscar.Name = "IconoBuscar";
            this.IconoBuscar.Size = new System.Drawing.Size(41, 44);
            this.IconoBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconoBuscar.TabIndex = 1;
            this.IconoBuscar.TabStop = false;
            // 
            // Buscar
            // 
            this.Buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.Buscar.Location = new System.Drawing.Point(966, 101);
            this.Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(305, 44);
            this.Buscar.TabIndex = 0;
            this.Buscar.Text = "Buscar...";
            this.Buscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Buscar.Enter += new System.EventHandler(this.Buscar_Enter);
            this.Buscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Buscar_KeyUp);
            this.Buscar.Leave += new System.EventHandler(this.Buscar_Leave);
            // 
            // Listado
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Listado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Listado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Listado.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.Listado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Listado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Listado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.Listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Listado.DefaultCellStyle = dataGridViewCellStyle7;
            this.Listado.DoubleBuffered = true;
            this.Listado.EnableHeadersVisualStyles = false;
            this.Listado.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.Listado.HeaderForeColor = System.Drawing.SystemColors.Control;
            this.Listado.Location = new System.Drawing.Point(3, 158);
            this.Listado.Name = "Listado";
            this.Listado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Listado.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.Listado.Size = new System.Drawing.Size(1276, 462);
            this.Listado.TabIndex = 1;
            this.Listado.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.Listado_CellFormatting);
            // 
            // FormaApp
            // 
            this.FormaApp.ElipseRadius = 5;
            this.FormaApp.TargetControl = this;
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
            this.PanelHora.Location = new System.Drawing.Point(-4, 623);
            this.PanelHora.Name = "PanelHora";
            this.PanelHora.Size = new System.Drawing.Size(1294, 109);
            this.PanelHora.TabIndex = 7;
            // 
            // txtUsuario
            // 
            this.txtUsuario.AutoSize = true;
            this.txtUsuario.Font = new System.Drawing.Font("MV Boli", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtUsuario.Location = new System.Drawing.Point(137, 31);
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
            this.Fecha.Location = new System.Drawing.Point(901, 70);
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
            this.hora.Location = new System.Drawing.Point(893, 7);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(190, 63);
            this.hora.TabIndex = 0;
            this.hora.Text = "MM:SS";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Listado_polizas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1280, 728);
            this.Controls.Add(this.PanelHora);
            this.Controls.Add(this.Listado);
            this.Controls.Add(this.Cabeza);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Listado_polizas";
            this.Text = "Listado_polizas";
            this.Load += new System.EventHandler(this.Listado_polizas_Load);
            this.Cabeza.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IconoBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Listado)).EndInit();
            this.PanelHora.ResumeLayout(false);
            this.PanelHora.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen_usu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomDataGrid Listado;
        private System.Windows.Forms.Panel Cabeza;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Buscar;
        private System.Windows.Forms.PictureBox IconoBuscar;
        private System.Windows.Forms.Button Eliminar;
        private Bunifu.Framework.UI.BunifuElipse FormaApp;
        private System.Windows.Forms.Button Anadir;
        private System.Windows.Forms.Button Editar;
        private System.Windows.Forms.Panel PanelHora;
        private Bunifu.Framework.UI.BunifuCustomLabel txtUsuario;
        private System.Windows.Forms.PictureBox Imagen_usu;
        private Bunifu.Framework.UI.BunifuCustomLabel Fecha;
        private Bunifu.Framework.UI.BunifuCustomLabel hora;
        private System.Windows.Forms.Timer timer1;
    }
}