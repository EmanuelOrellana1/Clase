namespace Clase.Vista
{
    partial class frmMenu
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cONTROLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSUARIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rOLESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vENTAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.venderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cONTROLToolStripMenuItem,
            this.vENTAToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cONTROLToolStripMenuItem
            // 
            this.cONTROLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uSUARIOToolStripMenuItem,
            this.rOLESToolStripMenuItem});
            this.cONTROLToolStripMenuItem.Name = "cONTROLToolStripMenuItem";
            this.cONTROLToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.cONTROLToolStripMenuItem.Text = "CONTROL";
            // 
            // uSUARIOToolStripMenuItem
            // 
            this.uSUARIOToolStripMenuItem.Name = "uSUARIOToolStripMenuItem";
            this.uSUARIOToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.uSUARIOToolStripMenuItem.Text = "USUARIO";
            this.uSUARIOToolStripMenuItem.Click += new System.EventHandler(this.uSUARIOToolStripMenuItem_Click);
            // 
            // rOLESToolStripMenuItem
            // 
            this.rOLESToolStripMenuItem.Name = "rOLESToolStripMenuItem";
            this.rOLESToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.rOLESToolStripMenuItem.Text = "ROLES";
            this.rOLESToolStripMenuItem.Click += new System.EventHandler(this.rOLESToolStripMenuItem_Click);
            // 
            // vENTAToolStripMenuItem
            // 
            this.vENTAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.venderToolStripMenuItem});
            this.vENTAToolStripMenuItem.Name = "vENTAToolStripMenuItem";
            this.vENTAToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.vENTAToolStripMenuItem.Text = "VENTA";
            // 
            // venderToolStripMenuItem
            // 
            this.venderToolStripMenuItem.Name = "venderToolStripMenuItem";
            this.venderToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.venderToolStripMenuItem.Text = "Vender";
            this.venderToolStripMenuItem.Click += new System.EventHandler(this.venderToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cONTROLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uSUARIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rOLESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vENTAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem venderToolStripMenuItem;
    }
}