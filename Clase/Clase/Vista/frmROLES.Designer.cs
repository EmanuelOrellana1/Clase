namespace Clase.Vista
{
    partial class frmROLES
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
            this.dtVistaRoles = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtVistaRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // dtVistaRoles
            // 
            this.dtVistaRoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtVistaRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtVistaRoles.Location = new System.Drawing.Point(83, 102);
            this.dtVistaRoles.Name = "dtVistaRoles";
            this.dtVistaRoles.RowHeadersWidth = 51;
            this.dtVistaRoles.RowTemplate.Height = 24;
            this.dtVistaRoles.Size = new System.Drawing.Size(595, 273);
            this.dtVistaRoles.TabIndex = 0;
            this.dtVistaRoles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtVistaRoles_CellContentClick);
            // 
            // frmROLES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 459);
            this.Controls.Add(this.dtVistaRoles);
            this.Name = "frmROLES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmROLES";
            this.Load += new System.EventHandler(this.frmROLES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtVistaRoles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtVistaRoles;
    }
}