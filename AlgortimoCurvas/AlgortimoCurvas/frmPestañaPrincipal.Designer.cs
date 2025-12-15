namespace AlgortimoCurvas
{
    partial class frmPestañaPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.curvasBézierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.curvaBSplineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.curvasBézierToolStripMenuItem,
            this.curvaBSplineToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // curvasBézierToolStripMenuItem
            // 
            this.curvasBézierToolStripMenuItem.Name = "curvasBézierToolStripMenuItem";
            this.curvasBézierToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.curvasBézierToolStripMenuItem.Text = "Curvas Bézier ";
            this.curvasBézierToolStripMenuItem.Click += new System.EventHandler(this.curvasBézierToolStripMenuItem_Click);
            // 
            // curvaBSplineToolStripMenuItem
            // 
            this.curvaBSplineToolStripMenuItem.Name = "curvaBSplineToolStripMenuItem";
            this.curvaBSplineToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.curvaBSplineToolStripMenuItem.Text = "Curva B-Spline";
            this.curvaBSplineToolStripMenuItem.Click += new System.EventHandler(this.curvaBSplineToolStripMenuItem_Click);
            // 
            // frmPestañaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPestañaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ALGORITMOS DE CURVAS";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem curvasBézierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem curvaBSplineToolStripMenuItem;
    }
}

