namespace Clase.Vista
{
    partial class frmVentas
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
            this.lblNumeroVenta = new System.Windows.Forms.Label();
            this.txtNumeroVenta = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.lblBuscarProducto = new System.Windows.Forms.Label();
            this.lblCodigoProducto = new System.Windows.Forms.Label();
            this.txtBuscarProd = new System.Windows.Forms.TextBox();
            this.txtCodigoProd = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblNombreProd = new System.Windows.Forms.Label();
            this.txtNombreProd = new System.Windows.Forms.TextBox();
            this.lblPrecioProd = new System.Windows.Forms.Label();
            this.txtPrecioProd = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dtvVenta = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtvVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumeroVenta
            // 
            this.lblNumeroVenta.AutoSize = true;
            this.lblNumeroVenta.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroVenta.Location = new System.Drawing.Point(3, 12);
            this.lblNumeroVenta.Name = "lblNumeroVenta";
            this.lblNumeroVenta.Size = new System.Drawing.Size(168, 22);
            this.lblNumeroVenta.TabIndex = 0;
            this.lblNumeroVenta.Text = "Numero de Venta";
            // 
            // txtNumeroVenta
            // 
            this.txtNumeroVenta.Enabled = false;
            this.txtNumeroVenta.Location = new System.Drawing.Point(198, 12);
            this.txtNumeroVenta.Name = "txtNumeroVenta";
            this.txtNumeroVenta.Size = new System.Drawing.Size(136, 22);
            this.txtNumeroVenta.TabIndex = 1;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(441, 15);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(74, 22);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "Cliente";
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDocumento.Location = new System.Drawing.Point(441, 72);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(192, 22);
            this.lblTipoDocumento.TabIndex = 3;
            this.lblTipoDocumento.Text = "Tipo de Documento";
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(637, 13);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(121, 24);
            this.cmbCliente.TabIndex = 4;
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Location = new System.Drawing.Point(637, 72);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(121, 24);
            this.cmbTipoDocumento.TabIndex = 5;
            // 
            // lblBuscarProducto
            // 
            this.lblBuscarProducto.AutoSize = true;
            this.lblBuscarProducto.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarProducto.Location = new System.Drawing.Point(3, 160);
            this.lblBuscarProducto.Name = "lblBuscarProducto";
            this.lblBuscarProducto.Size = new System.Drawing.Size(168, 22);
            this.lblBuscarProducto.TabIndex = 6;
            this.lblBuscarProducto.Text = "Buscar Producto";
            // 
            // lblCodigoProducto
            // 
            this.lblCodigoProducto.AutoSize = true;
            this.lblCodigoProducto.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoProducto.Location = new System.Drawing.Point(3, 225);
            this.lblCodigoProducto.Name = "lblCodigoProducto";
            this.lblCodigoProducto.Size = new System.Drawing.Size(168, 22);
            this.lblCodigoProducto.TabIndex = 7;
            this.lblCodigoProducto.Text = "Codigo Producto";
            // 
            // txtBuscarProd
            // 
            this.txtBuscarProd.Location = new System.Drawing.Point(209, 159);
            this.txtBuscarProd.Name = "txtBuscarProd";
            this.txtBuscarProd.Size = new System.Drawing.Size(216, 22);
            this.txtBuscarProd.TabIndex = 8;
            // 
            // txtCodigoProd
            // 
            this.txtCodigoProd.Location = new System.Drawing.Point(7, 267);
            this.txtCodigoProd.Name = "txtCodigoProd";
            this.txtCodigoProd.Size = new System.Drawing.Size(164, 22);
            this.txtCodigoProd.TabIndex = 9;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(458, 151);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(148, 35);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lblNombreProd
            // 
            this.lblNombreProd.AutoSize = true;
            this.lblNombreProd.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProd.Location = new System.Drawing.Point(236, 225);
            this.lblNombreProd.Name = "lblNombreProd";
            this.lblNombreProd.Size = new System.Drawing.Size(174, 22);
            this.lblNombreProd.TabIndex = 11;
            this.lblNombreProd.Text = "Nombre Producto";
            // 
            // txtNombreProd
            // 
            this.txtNombreProd.Location = new System.Drawing.Point(240, 267);
            this.txtNombreProd.Name = "txtNombreProd";
            this.txtNombreProd.Size = new System.Drawing.Size(164, 22);
            this.txtNombreProd.TabIndex = 12;
            // 
            // lblPrecioProd
            // 
            this.lblPrecioProd.AutoSize = true;
            this.lblPrecioProd.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioProd.Location = new System.Drawing.Point(474, 225);
            this.lblPrecioProd.Name = "lblPrecioProd";
            this.lblPrecioProd.Size = new System.Drawing.Size(161, 22);
            this.lblPrecioProd.TabIndex = 13;
            this.lblPrecioProd.Text = "Precio Producto";
            // 
            // txtPrecioProd
            // 
            this.txtPrecioProd.Location = new System.Drawing.Point(469, 267);
            this.txtPrecioProd.Name = "txtPrecioProd";
            this.txtPrecioProd.Size = new System.Drawing.Size(164, 22);
            this.txtPrecioProd.TabIndex = 14;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(673, 225);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(93, 22);
            this.lblCantidad.TabIndex = 15;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(677, 267);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(164, 22);
            this.txtCantidad.TabIndex = 16;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(878, 225);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(56, 22);
            this.lblTotal.TabIndex = 17;
            this.lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(882, 267);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(164, 22);
            this.txtTotal.TabIndex = 18;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(1113, 250);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(158, 39);
            this.btnAgregar.TabIndex = 19;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // dtvVenta
            // 
            this.dtvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvVenta.Location = new System.Drawing.Point(53, 320);
            this.dtvVenta.Name = "dtvVenta";
            this.dtvVenta.RowHeadersWidth = 51;
            this.dtvVenta.RowTemplate.Height = 24;
            this.dtvVenta.Size = new System.Drawing.Size(1039, 193);
            this.dtvVenta.TabIndex = 20;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 561);
            this.Controls.Add(this.dtvVenta);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtPrecioProd);
            this.Controls.Add(this.lblPrecioProd);
            this.Controls.Add(this.txtNombreProd);
            this.Controls.Add(this.lblNombreProd);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCodigoProd);
            this.Controls.Add(this.txtBuscarProd);
            this.Controls.Add(this.lblCodigoProducto);
            this.Controls.Add(this.lblBuscarProducto);
            this.Controls.Add(this.cmbTipoDocumento);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.lblTipoDocumento);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txtNumeroVenta);
            this.Controls.Add(this.lblNumeroVenta);
            this.Name = "frmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVentas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeroVenta;
        private System.Windows.Forms.TextBox txtNumeroVenta;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        private System.Windows.Forms.Label lblBuscarProducto;
        private System.Windows.Forms.Label lblCodigoProducto;
        private System.Windows.Forms.TextBox txtBuscarProd;
        private System.Windows.Forms.TextBox txtCodigoProd;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblNombreProd;
        private System.Windows.Forms.TextBox txtNombreProd;
        private System.Windows.Forms.Label lblPrecioProd;
        private System.Windows.Forms.TextBox txtPrecioProd;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dtvVenta;
    }
}