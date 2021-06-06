using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appventas.VISTA
{
    public partial class FrmMdi : Form
    {
        public FrmMdi()
        {
            InitializeComponent();
        }

       

        private void btnReg_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();

        }

      

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BIENVENIDO");
            FrmClientes frm = new FrmClientes();
            frm.Show();
            this.Hide();
        }

        private void abrirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmDocumentos frm = new FrmDocumentos();
            frm.Show();
            this.Hide();
        }

        private void abrirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmProducto frm = new FrmProducto();
            frm.Show();
            this.Hide();
        }

        private void abrirToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmUsuarios frm = new FrmUsuarios();
            frm.Show();
            this.Hide();
        }

        private void FrmMdi_Load(object sender, EventArgs e)
        {

        }
    }
}
