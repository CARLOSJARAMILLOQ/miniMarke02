using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniMarke02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            

        }

        private void actualizarMinimarketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmActualizar_MiniMarket objFrmMini = new FrmActualizar_MiniMarket();
            objFrmMini.MdiParent = this;

            objFrmMini.Show();
            objFrmMini.WindowState = FormWindowState.Maximized;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void registrarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void registrarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistrar_Proveedor objFrmProvedor = new FrmRegistrar_Proveedor();
            objFrmProvedor.MdiParent = this;

            objFrmProvedor.Show();
            objFrmProvedor.WindowState = FormWindowState.Maximized;
        }

        private void actualizarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmActualizar_Proveedor2 objFrmProve = new FrmActualizar_Proveedor2();
            objFrmProve.MdiParent = this;

            objFrmProve.Show();
            objFrmProve.WindowState = FormWindowState.Maximized;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void actualizarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistrarCliente2 objFrmRegistrar_Cliente2 =new FrmRegistrarCliente2();

            objFrmRegistrar_Cliente2.MdiParent = this;
            objFrmRegistrar_Cliente2.Show();
            objFrmRegistrar_Cliente2.WindowState = FormWindowState.Maximized;
        }

        private void registrarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistrar_Categoria objFrmRegistrar_Categoria =new FrmRegistrar_Categoria();

            objFrmRegistrar_Categoria.MdiParent = this;

            objFrmRegistrar_Categoria.Show();
            objFrmRegistrar_Categoria.WindowState = FormWindowState.Maximized;

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {

        }

        private void actualizarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmActualizar_Categoria objFrmActualizar_categori = new FrmActualizar_Categoria();
            objFrmActualizar_categori.MdiParent= this;
            objFrmActualizar_categori.Show();
            objFrmActualizar_categori.WindowState = FormWindowState.Maximized;
        }

        private void actualizarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmActualizar_Cliente2 objFrmActualizar_Client = new FrmActualizar_Cliente2();
            objFrmActualizar_Client.MdiParent=this;
            objFrmActualizar_Client.Show();
            objFrmActualizar_Client.WindowState = FormWindowState.Maximized;
        }
    }
}
