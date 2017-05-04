namespace Preceptoria_Don_Bosco
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aaaaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTab1 = new System.Windows.Forms.Label();
            this.lblTab2 = new System.Windows.Forms.Label();
            this.tabInd = new ns1.BunifuSeparator();
            this.lblTab3 = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.PreceptoriaDataSet = new Preceptoria_Don_Bosco.PreceptoriaDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.informacionAlumno1 = new Preceptoria_Don_Bosco.informacionAlumno();
            this.alumnosUserControl1 = new Preceptoria_Don_Bosco.AlumnosUserControl();
            this.cursosUserControl1 = new Preceptoria_Don_Bosco.CursosUserControl();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreceptoriaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(551, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.queryToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // queryToolStripMenuItem
            // 
            this.queryToolStripMenuItem.Name = "queryToolStripMenuItem";
            this.queryToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.queryToolStripMenuItem.Text = "Query";
            this.queryToolStripMenuItem.Click += new System.EventHandler(this.queryToolStripMenuItem_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aaaaToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(99, 26);
            // 
            // aaaaToolStripMenuItem
            // 
            this.aaaaToolStripMenuItem.Name = "aaaaToolStripMenuItem";
            this.aaaaToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.aaaaToolStripMenuItem.Text = "aaaa";
            // 
            // lblTab1
            // 
            this.lblTab1.AutoSize = true;
            this.lblTab1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTab1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTab1.Location = new System.Drawing.Point(12, 35);
            this.lblTab1.Name = "lblTab1";
            this.lblTab1.Size = new System.Drawing.Size(61, 15);
            this.lblTab1.TabIndex = 2;
            this.lblTab1.Text = "ALUMNOS";
            this.lblTab1.Click += new System.EventHandler(this.lblTab1_Click);
            // 
            // lblTab2
            // 
            this.lblTab2.AutoSize = true;
            this.lblTab2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTab2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTab2.Location = new System.Drawing.Point(88, 35);
            this.lblTab2.Name = "lblTab2";
            this.lblTab2.Size = new System.Drawing.Size(50, 15);
            this.lblTab2.TabIndex = 3;
            this.lblTab2.Text = "CURSOS";
            this.lblTab2.Click += new System.EventHandler(this.lblTab2_Click);
            // 
            // tabInd
            // 
            this.tabInd.BackColor = System.Drawing.Color.Transparent;
            this.tabInd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.tabInd.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.tabInd.LineThickness = 3;
            this.tabInd.Location = new System.Drawing.Point(14, 49);
            this.tabInd.Name = "tabInd";
            this.tabInd.Size = new System.Drawing.Size(59, 10);
            this.tabInd.TabIndex = 4;
            this.tabInd.Transparency = 255;
            this.tabInd.Vertical = false;
            // 
            // lblTab3
            // 
            this.lblTab3.AutoSize = true;
            this.lblTab3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTab3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTab3.Location = new System.Drawing.Point(153, 35);
            this.lblTab3.Name = "lblTab3";
            this.lblTab3.Size = new System.Drawing.Size(97, 15);
            this.lblTab3.TabIndex = 5;
            this.lblTab3.Text = "NUEVO ALUMNO";
            this.lblTab3.Click += new System.EventHandler(this.lblTab3_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            // 
            // PreceptoriaDataSet
            // 
            this.PreceptoriaDataSet.DataSetName = "PreceptoriaDataSet";
            this.PreceptoriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // informacionAlumno1
            // 
            this.informacionAlumno1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.informacionAlumno1.AutoScroll = true;
            this.informacionAlumno1.Location = new System.Drawing.Point(0, 65);
            this.informacionAlumno1.Name = "informacionAlumno1";
            this.informacionAlumno1.Size = new System.Drawing.Size(551, 876);
            this.informacionAlumno1.TabIndex = 12;
            // 
            // alumnosUserControl1
            // 
            this.alumnosUserControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.alumnosUserControl1.AutoSize = true;
            this.alumnosUserControl1.Location = new System.Drawing.Point(1, 65);
            this.alumnosUserControl1.Name = "alumnosUserControl1";
            this.alumnosUserControl1.Size = new System.Drawing.Size(550, 347);
            this.alumnosUserControl1.TabIndex = 9;
            // 
            // cursosUserControl1
            // 
            this.cursosUserControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cursosUserControl1.Location = new System.Drawing.Point(0, 65);
            this.cursosUserControl1.Name = "cursosUserControl1";
            this.cursosUserControl1.Size = new System.Drawing.Size(550, 347);
            this.cursosUserControl1.TabIndex = 8;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 414);
            this.Controls.Add(this.informacionAlumno1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTab3);
            this.Controls.Add(this.tabInd);
            this.Controls.Add(this.lblTab2);
            this.Controls.Add(this.lblTab1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.alumnosUserControl1);
            this.Controls.Add(this.cursosUserControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preceptoria Don Bosco";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PreceptoriaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryToolStripMenuItem;
        private PreceptoriaDataSet PreceptoriaDataSet;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem aaaaToolStripMenuItem;
        private System.Windows.Forms.Label lblTab1;
        private System.Windows.Forms.Label lblTab2;
        private ns1.BunifuSeparator tabInd;
        private System.Windows.Forms.Label lblTab3;
        private CursosUserControl cursosUserControl1;
        private AlumnosUserControl alumnosUserControl1;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button button1;
        private informacionAlumno informacionAlumno1;
    }
}

