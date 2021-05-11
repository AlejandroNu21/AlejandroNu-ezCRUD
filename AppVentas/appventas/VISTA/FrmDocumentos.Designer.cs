
namespace appventas.VISTA
{
    partial class FrmDocumentos
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
            this.txtDocId = new System.Windows.Forms.TextBox();
            this.txtDocTipo = new System.Windows.Forms.TextBox();
            this.lblidDoc = new System.Windows.Forms.Label();
            this.lblDoc = new System.Windows.Forms.Label();
            this.dtgDoc = new System.Windows.Forms.DataGridView();
            this.iDDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpd = new System.Windows.Forms.Button();
            this.btnDelet = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDoc)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDocId
            // 
            this.txtDocId.Enabled = false;
            this.txtDocId.Location = new System.Drawing.Point(42, 37);
            this.txtDocId.Name = "txtDocId";
            this.txtDocId.Size = new System.Drawing.Size(119, 21);
            this.txtDocId.TabIndex = 0;
            this.txtDocId.TextChanged += new System.EventHandler(this.txtDocId_TextChanged);
            // 
            // txtDocTipo
            // 
            this.txtDocTipo.Location = new System.Drawing.Point(302, 37);
            this.txtDocTipo.Name = "txtDocTipo";
            this.txtDocTipo.Size = new System.Drawing.Size(119, 21);
            this.txtDocTipo.TabIndex = 1;
            // 
            // lblidDoc
            // 
            this.lblidDoc.AutoSize = true;
            this.lblidDoc.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidDoc.Location = new System.Drawing.Point(53, 9);
            this.lblidDoc.Name = "lblidDoc";
            this.lblidDoc.Size = new System.Drawing.Size(97, 16);
            this.lblidDoc.TabIndex = 2;
            this.lblidDoc.Text = "Id Documento";
            // 
            // lblDoc
            // 
            this.lblDoc.AutoSize = true;
            this.lblDoc.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoc.Location = new System.Drawing.Point(292, 9);
            this.lblDoc.Name = "lblDoc";
            this.lblDoc.Size = new System.Drawing.Size(129, 16);
            this.lblDoc.TabIndex = 3;
            this.lblDoc.Text = "Tipo de Documento";
            // 
            // dtgDoc
            // 
            this.dtgDoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDoc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgDoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDocumento,
            this.nombreDocumento});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgDoc.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgDoc.Location = new System.Drawing.Point(12, 78);
            this.dtgDoc.Name = "dtgDoc";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgDoc.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgDoc.Size = new System.Drawing.Size(496, 156);
            this.dtgDoc.TabIndex = 4;
            this.dtgDoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDoc_CellContentClick);
            // 
            // iDDocumento
            // 
            this.iDDocumento.HeaderText = "Id";
            this.iDDocumento.Name = "iDDocumento";
            // 
            // nombreDocumento
            // 
            this.nombreDocumento.HeaderText = "Tipo de Documento";
            this.nombreDocumento.Name = "nombreDocumento";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Teal;
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(42, 266);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 32);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpd
            // 
            this.btnUpd.BackColor = System.Drawing.Color.Teal;
            this.btnUpd.FlatAppearance.BorderSize = 2;
            this.btnUpd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpd.Location = new System.Drawing.Point(205, 266);
            this.btnUpd.Name = "btnUpd";
            this.btnUpd.Size = new System.Drawing.Size(120, 32);
            this.btnUpd.TabIndex = 6;
            this.btnUpd.Text = "Update";
            this.btnUpd.UseVisualStyleBackColor = false;
            this.btnUpd.Click += new System.EventHandler(this.btnUpd_Click);
            // 
            // btnDelet
            // 
            this.btnDelet.BackColor = System.Drawing.Color.Teal;
            this.btnDelet.FlatAppearance.BorderSize = 2;
            this.btnDelet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelet.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelet.Location = new System.Drawing.Point(368, 266);
            this.btnDelet.Name = "btnDelet";
            this.btnDelet.Size = new System.Drawing.Size(120, 32);
            this.btnDelet.TabIndex = 7;
            this.btnDelet.Text = "Delete";
            this.btnDelet.UseVisualStyleBackColor = false;
            this.btnDelet.Click += new System.EventHandler(this.btnDelet_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnback.FlatAppearance.BorderSize = 2;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(418, 350);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(90, 38);
            this.btnback.TabIndex = 8;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // FrmDocumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(520, 400);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnDelet);
            this.Controls.Add(this.btnUpd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtgDoc);
            this.Controls.Add(this.lblDoc);
            this.Controls.Add(this.lblidDoc);
            this.Controls.Add(this.txtDocTipo);
            this.Controls.Add(this.txtDocId);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmDocumentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Documentos";
            this.Load += new System.EventHandler(this.FrmDocumentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDocId;
        private System.Windows.Forms.TextBox txtDocTipo;
        private System.Windows.Forms.Label lblidDoc;
        private System.Windows.Forms.Label lblDoc;
        private System.Windows.Forms.DataGridView dtgDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDocumento;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpd;
        private System.Windows.Forms.Button btnDelet;
        private System.Windows.Forms.Button btnback;
    }
}