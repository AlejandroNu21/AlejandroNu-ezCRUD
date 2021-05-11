
namespace appventas.VISTA
{
    partial class FrmClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtIdCl = new System.Windows.Forms.TextBox();
            this.txtNomCl = new System.Windows.Forms.TextBox();
            this.txtDirecCl = new System.Windows.Forms.TextBox();
            this.txtDuiCl = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblDir = new System.Windows.Forms.Label();
            this.lblDui = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duiCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnC = new System.Windows.Forms.Button();
            this.btnU = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdCl
            // 
            this.txtIdCl.Enabled = false;
            this.txtIdCl.Location = new System.Drawing.Point(76, 39);
            this.txtIdCl.Name = "txtIdCl";
            this.txtIdCl.Size = new System.Drawing.Size(201, 18);
            this.txtIdCl.TabIndex = 0;
            // 
            // txtNomCl
            // 
            this.txtNomCl.Location = new System.Drawing.Point(76, 77);
            this.txtNomCl.Name = "txtNomCl";
            this.txtNomCl.Size = new System.Drawing.Size(201, 18);
            this.txtNomCl.TabIndex = 1;
            // 
            // txtDirecCl
            // 
            this.txtDirecCl.Location = new System.Drawing.Point(76, 116);
            this.txtDirecCl.Name = "txtDirecCl";
            this.txtDirecCl.Size = new System.Drawing.Size(201, 18);
            this.txtDirecCl.TabIndex = 2;
            // 
            // txtDuiCl
            // 
            this.txtDuiCl.Location = new System.Drawing.Point(76, 158);
            this.txtDuiCl.Name = "txtDuiCl";
            this.txtDuiCl.Size = new System.Drawing.Size(201, 18);
            this.txtDuiCl.TabIndex = 3;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(12, 39);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(20, 15);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "Id";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(12, 77);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(52, 15);
            this.lblNom.TabIndex = 5;
            this.lblNom.Text = "Nombre";
            // 
            // lblDir
            // 
            this.lblDir.AutoSize = true;
            this.lblDir.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDir.Location = new System.Drawing.Point(12, 116);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(59, 15);
            this.lblDir.TabIndex = 6;
            this.lblDir.Text = "Direccion";
            // 
            // lblDui
            // 
            this.lblDui.AutoSize = true;
            this.lblDui.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDui.Location = new System.Drawing.Point(12, 158);
            this.lblDui.Name = "lblDui";
            this.lblDui.Size = new System.Drawing.Size(26, 15);
            this.lblDui.TabIndex = 7;
            this.lblDui.Text = "Dui";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDCliente,
            this.nombreCliente,
            this.direccionCliente,
            this.duiCliente});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(304, 47);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Size = new System.Drawing.Size(511, 127);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDCliente
            // 
            this.iDCliente.HeaderText = "iDCliente";
            this.iDCliente.Name = "iDCliente";
            // 
            // nombreCliente
            // 
            this.nombreCliente.HeaderText = "nombreCliente";
            this.nombreCliente.Name = "nombreCliente";
            // 
            // direccionCliente
            // 
            this.direccionCliente.HeaderText = "direccionCliente";
            this.direccionCliente.Name = "direccionCliente";
            // 
            // duiCliente
            // 
            this.duiCliente.HeaderText = "duiCliente";
            this.duiCliente.Name = "duiCliente";
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnC.FlatAppearance.BorderSize = 2;
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(110, 222);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(113, 28);
            this.btnC.TabIndex = 9;
            this.btnC.Text = "Create";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnU
            // 
            this.btnU.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnU.FlatAppearance.BorderSize = 2;
            this.btnU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnU.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnU.Location = new System.Drawing.Point(287, 222);
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(113, 28);
            this.btnU.TabIndex = 10;
            this.btnU.Text = "Update";
            this.btnU.UseVisualStyleBackColor = false;
            this.btnU.Click += new System.EventHandler(this.btnU_Click);
            // 
            // btnD
            // 
            this.btnD.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnD.FlatAppearance.BorderSize = 2;
            this.btnD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnD.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnD.Location = new System.Drawing.Point(450, 222);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(113, 28);
            this.btnD.TabIndex = 11;
            this.btnD.Text = "Delete";
            this.btnD.UseVisualStyleBackColor = false;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Teal;
            this.btnback.FlatAppearance.BorderSize = 2;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(715, 192);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(85, 35);
            this.btnback.TabIndex = 12;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(822, 271);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnU);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblDui);
            this.Controls.Add(this.lblDir);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtDuiCl);
            this.Controls.Add(this.txtDirecCl);
            this.Controls.Add(this.txtNomCl);
            this.Controls.Add(this.txtIdCl);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdCl;
        private System.Windows.Forms.TextBox txtNomCl;
        private System.Windows.Forms.TextBox txtDirecCl;
        private System.Windows.Forms.TextBox txtDuiCl;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblDir;
        private System.Windows.Forms.Label lblDui;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn duiCliente;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnU;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnback;
    }
}