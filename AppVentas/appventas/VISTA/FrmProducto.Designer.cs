﻿
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnActu = new System.Windows.Forms.Button();
            this.btnBor = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
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
            this.txtIdpro.Size = new System.Drawing.Size(278, 20);
            this.txtIdpro.TabIndex = 0;
            // 
            // txtNomp
            // 
            this.txtNomp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomp.Location = new System.Drawing.Point(157, 70);
            this.txtNomp.Name = "txtNomp";
            this.txtNomp.Size = new System.Drawing.Size(278, 20);
            this.txtNomp.TabIndex = 1;
            // 
            // txtPrecP
            // 
            this.txtPrecP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecP.Location = new System.Drawing.Point(157, 102);
            this.txtPrecP.Name = "txtPrecP";
            this.txtPrecP.Size = new System.Drawing.Size(278, 20);
            this.txtPrecP.TabIndex = 2;
            // 
            // txtEdoP
            // 
            this.txtEdoP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEdoP.Location = new System.Drawing.Point(157, 133);
            this.txtEdoP.Name = "txtEdoP";
            this.txtEdoP.Size = new System.Drawing.Size(278, 20);
            this.txtEdoP.TabIndex = 3;
            // 
            // lblIdPr
            // 
            this.lblIdPr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIdPr.AutoSize = true;
            this.lblIdPr.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPr.Location = new System.Drawing.Point(21, 42);
            this.lblIdPr.Name = "lblIdPr";
            this.lblIdPr.Size = new System.Drawing.Size(81, 15);
            this.lblIdPr.TabIndex = 4;
            this.lblIdPr.Text = "Id Producto";
            // 
            // lblNomPro
            // 
            this.lblNomPro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNomPro.AutoSize = true;
            this.lblNomPro.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomPro.Location = new System.Drawing.Point(19, 73);
            this.lblNomPro.Name = "lblNomPro";
            this.lblNomPro.Size = new System.Drawing.Size(137, 15);
            this.lblNomPro.TabIndex = 5;
            this.lblNomPro.Text = "Nombre de producto";
            // 
            // lblPrec
            // 
            this.lblPrec.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrec.AutoSize = true;
            this.lblPrec.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrec.Location = new System.Drawing.Point(21, 105);
            this.lblPrec.Name = "lblPrec";
            this.lblPrec.Size = new System.Drawing.Size(126, 15);
            this.lblPrec.TabIndex = 6;
            this.lblPrec.Text = "Precio de Producto";
            // 
            // lblEdo
            // 
            this.lblEdo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEdo.AutoSize = true;
            this.lblEdo.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdo.Location = new System.Drawing.Point(21, 140);
            this.lblEdo.Name = "lblEdo";
            this.lblEdo.Size = new System.Drawing.Size(131, 15);
            this.lblEdo.TabIndex = 7;
            this.lblEdo.Text = "Estado de Producto";
            // 
            // dtgProduct
            // 
            this.dtgProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.nombreProducto,
            this.precioProducto,
            this.estadoProducto});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgProduct.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgProduct.Location = new System.Drawing.Point(22, 206);
            this.dtgProduct.Name = "dtgProduct";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgProduct.Size = new System.Drawing.Size(532, 168);
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
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnGuardar.FlatAppearance.BorderSize = 2;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(448, 16);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(112, 39);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Save";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnActu
            // 
            this.btnActu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnActu.FlatAppearance.BorderSize = 2;
            this.btnActu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActu.Location = new System.Drawing.Point(448, 70);
            this.btnActu.Name = "btnActu";
            this.btnActu.Size = new System.Drawing.Size(112, 39);
            this.btnActu.TabIndex = 10;
            this.btnActu.Text = "Update";
            this.btnActu.UseVisualStyleBackColor = false;
            this.btnActu.Click += new System.EventHandler(this.btnActu_Click);
            // 
            // btnBor
            // 
            this.btnBor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBor.FlatAppearance.BorderSize = 2;
            this.btnBor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBor.Location = new System.Drawing.Point(448, 123);
            this.btnBor.Name = "btnBor";
            this.btnBor.Size = new System.Drawing.Size(112, 39);
            this.btnBor.TabIndex = 11;
            this.btnBor.Text = "Delete";
            this.btnBor.UseVisualStyleBackColor = false;
            this.btnBor.Click += new System.EventHandler(this.btnBor_Click);
            // 
            // btnback
            // 
            this.btnback.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnback.FlatAppearance.BorderSize = 2;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(448, 418);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(112, 45);
            this.btnback.TabIndex = 12;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(566, 471);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnBor);
            this.Controls.Add(this.btnActu);
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
            this.Text = "Producto";
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
        private System.Windows.Forms.Button btnActu;
        private System.Windows.Forms.Button btnBor;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoProducto;
        private System.Windows.Forms.Button btnback;
    }
}