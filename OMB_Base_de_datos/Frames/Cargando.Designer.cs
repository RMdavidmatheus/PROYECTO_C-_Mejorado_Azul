namespace OMB_Base_de_datos.Frames
{
    partial class Cargando
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cargando));
            this.FormaApp = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Carga = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TitilePanel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormaApp
            // 
            this.FormaApp.ElipseRadius = 5;
            this.FormaApp.TargetControl = this;
            // 
            // Carga
            // 
            this.Carga.animated = false;
            this.Carga.animationIterval = 5;
            this.Carga.animationSpeed = 300;
            this.Carga.BackColor = System.Drawing.Color.Gainsboro;
            this.Carga.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Carga.BackgroundImage")));
            this.Carga.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.Carga.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.Carga.LabelVisible = true;
            this.Carga.LineProgressThickness = 8;
            this.Carga.LineThickness = 5;
            this.Carga.Location = new System.Drawing.Point(21, 66);
            this.Carga.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Carga.MaxValue = 100;
            this.Carga.Name = "Carga";
            this.Carga.ProgressBackColor = System.Drawing.Color.Black;
            this.Carga.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.Carga.Size = new System.Drawing.Size(189, 189);
            this.Carga.TabIndex = 0;
            this.Carga.Value = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.TitilePanel);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 56);
            this.panel1.TabIndex = 1;
            // 
            // TitilePanel
            // 
            this.TitilePanel.AutoSize = true;
            this.TitilePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.TitilePanel.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitilePanel.ForeColor = System.Drawing.SystemColors.Control;
            this.TitilePanel.Location = new System.Drawing.Point(-3, 7);
            this.TitilePanel.Name = "TitilePanel";
            this.TitilePanel.Size = new System.Drawing.Size(239, 41);
            this.TitilePanel.TabIndex = 0;
            this.TitilePanel.Text = "Ingresando...";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Cargando
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(232, 270);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Carga);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cargando";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProgressBar";
            this.Load += new System.EventHandler(this.ProgressBar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse FormaApp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TitilePanel;
        public Bunifu.Framework.UI.BunifuCircleProgressbar Carga;
        public System.Windows.Forms.Timer timer1;
    }
}