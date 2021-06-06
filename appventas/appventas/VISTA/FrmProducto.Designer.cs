
namespace appventas.VISTA
{
    partial class FrmProducto
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
            this.txtIdpro = new System.Windows.Forms.TextBox();
            this.txtNomp = new System.Windows.Forms.TextBox();
            this.txtPrecP = new System.Windows.Forms.TextBox();
            this.txtEdoP = new System.Windows.Forms.TextBox();
            this.lblIdPr = new System.Windows.Forms.Label();
            this.lblNomPro = new System.Windows.Forms.Label();
            this.lblPrec = new System.Windows.Forms.Label();
            this.lblEdo = new System.Windows.Forms.Label();
            this.dtgProduct = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdpro
            // 
            this.txtIdpro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdpro.Enabled = false;
            this.txtIdpro.Location = new System.Drawing.Point(157, 35);
            this.txtIdpro.Name = "txtIdpro";
            this.txtIdpro.Size = new System.Drawing.Size(276, 20);
            this.txtIdpro.TabIndex = 0;
            // 
            // txtNomp
            // 
            this.txtNomp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomp.Location = new System.Drawing.Point(157, 70);
            this.txtNomp.Name = "txtNomp";
            this.txtNomp.Size = new System.Drawing.Size(276, 20);
            this.txtNomp.TabIndex = 1;
            // 
            // txtPrecP
            // 
            this.txtPrecP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecP.Location = new System.Drawing.Point(157, 102);
            this.txtPrecP.Name = "txtPrecP";
            this.txtPrecP.Size = new System.Drawing.Size(276, 20);
            this.txtPrecP.TabIndex = 2;
            // 
            // txtEdoP
            // 
            this.txtEdoP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEdoP.Location = new System.Drawing.Point(157, 133);
            this.txtEdoP.Name = "txtEdoP";
            this.txtEdoP.Size = new System.Drawing.Size(276, 20);
            this.txtEdoP.TabIndex = 3;
            // 
            // lblIdPr
            // 
            this.lblIdPr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIdPr.AutoSize = true;
            this.lblIdPr.Location = new System.Drawing.Point(21, 42);
            this.lblIdPr.Name = "lblIdPr";
            this.lblIdPr.Size = new System.Drawing.Size(73, 13);
            this.lblIdPr.TabIndex = 4;
            this.lblIdPr.Text = "Id Producto";
            // 
            // lblNomPro
            // 
            this.lblNomPro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNomPro.AutoSize = true;
            this.lblNomPro.Location = new System.Drawing.Point(19, 73);
            this.lblNomPro.Name = "lblNomPro";
            this.lblNomPro.Size = new System.Drawing.Size(122, 13);
            this.lblNomPro.TabIndex = 5;
            this.lblNomPro.Text = "Nombre de producto";
            // 
            // lblPrec
            // 
            this.lblPrec.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrec.AutoSize = true;
            this.lblPrec.Location = new System.Drawing.Point(21, 105);
            this.lblPrec.Name = "lblPrec";
            this.lblPrec.Size = new System.Drawing.Size(116, 13);
            this.lblPrec.TabIndex = 6;
            this.lblPrec.Text = "Precio de Producto";
            // 
            // lblEdo
            // 
            this.lblEdo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEdo.AutoSize = true;
            this.lblEdo.Location = new System.Drawing.Point(21, 140);
            this.lblEdo.Name = "lblEdo";
            this.lblEdo.Size = new System.Drawing.Size(119, 13);
            this.lblEdo.TabIndex = 7;
            this.lblEdo.Text = "Estado de Producto";
            // 
            // dtgProduct
            // 
            this.dtgProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgProduct.BackgroundColor = System.Drawing.Color.Gray;
            this.dtgProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.nombreProducto,
            this.precioProducto,
            this.estadoProducto});
            this.dtgProduct.Location = new System.Drawing.Point(40, 215);
            this.dtgProduct.Name = "dtgProduct";
            this.dtgProduct.Size = new System.Drawing.Size(496, 153);
            this.dtgProduct.TabIndex = 8;
            this.dtgProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProduct_CellContentClick);
            // 
            // idProducto
            // 
            this.idProducto.HeaderText = "Id";
            this.idProducto.Name = "idProducto";
            // 
            // nombreProducto
            // 
            this.nombreProducto.HeaderText = "Nombre Producto";
            this.nombreProducto.Name = "nombreProducto";
            // 
            // precioProducto
            // 
            this.precioProducto.HeaderText = "Precio de Producto";
            this.precioProducto.Name = "precioProducto";
            // 
            // estadoProducto
            // 
            this.estadoProducto.HeaderText = "Estado de Producto";
            this.estadoProducto.Name = "estadoProducto";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.LightSalmon;
            this.btnGuardar.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(448, 35);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(110, 34);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.BackColor = System.Drawing.Color.LightSalmon;
            this.btnActualizar.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(448, 82);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(110, 36);
            this.btnActualizar.TabIndex = 10;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActu_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrar.BackColor = System.Drawing.Color.LightSalmon;
            this.btnBorrar.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(448, 128);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(110, 29);
            this.btnBorrar.TabIndex = 11;
            this.btnBorrar.Text = "Borrrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBor_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegresar.BackColor = System.Drawing.Color.LightSalmon;
            this.btnRegresar.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(462, 416);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(90, 28);
            this.btnRegresar.TabIndex = 12;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnback_Click);
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(564, 456);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dtgProduct);
            this.Controls.Add(this.lblEdo);
            this.Controls.Add(this.lblPrec);
            this.Controls.Add(this.lblNomPro);
            this.Controls.Add(this.lblIdPr);
            this.Controls.Add(this.txtEdoP);
            this.Controls.Add(this.txtPrecP);
            this.Controls.Add(this.txtNomp);
            this.Controls.Add(this.txtIdpro);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProducto";
            this.Load += new System.EventHandler(this.FrmProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdpro;
        private System.Windows.Forms.TextBox txtNomp;
        private System.Windows.Forms.TextBox txtPrecP;
        private System.Windows.Forms.TextBox txtEdoP;
        private System.Windows.Forms.Label lblIdPr;
        private System.Windows.Forms.Label lblNomPro;
        private System.Windows.Forms.Label lblPrec;
        private System.Windows.Forms.Label lblEdo;
        private System.Windows.Forms.DataGridView dtgProduct;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoProducto;
        private System.Windows.Forms.Button btnRegresar;
    }
}