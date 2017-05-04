namespace Preceptoria_Don_Bosco
{
    partial class Alumno
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
            this.notifyIconAlumno = new System.Windows.Forms.NotifyIcon(this.components);
            this.alumnoUserControl1 = new Preceptoria_Don_Bosco.AlumnoUserControl();
            this.SuspendLayout();
            // 
            // notifyIconAlumno
            // 
            this.notifyIconAlumno.Text = "notifyIcon1";
            this.notifyIconAlumno.Visible = true;
            // 
            // alumnoUserControl1
            // 
            this.alumnoUserControl1.Location = new System.Drawing.Point(-1, 4);
            this.alumnoUserControl1.Name = "alumnoUserControl1";
            this.alumnoUserControl1.Size = new System.Drawing.Size(547, 363);
            this.alumnoUserControl1.TabIndex = 0;
            // 
            // Alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(545, 371);
            this.Controls.Add(this.alumnoUserControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Alumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alumno";
            this.Load += new System.EventHandler(this.Alumno_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIconAlumno;
        private AlumnoUserControl alumnoUserControl1;
    }
}