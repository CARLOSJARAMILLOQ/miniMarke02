using Capa_Entidades;
using Capa_Negocio;
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
    public partial class FrmActualizar_Categoria : Form
    {
        public FrmActualizar_Categoria()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Categoria objCategoria=new Categoria();

            objCategoria.Nombre=textBoxNombre.Text.Trim();
            objCategoria.Descripcion=textBoxDescripcion.Text.Trim();

            if (CN_Categoria.ActualizarCategoria(objCategoria))
            {

                MessageBox.Show("Actualizacion Exitosa");
            }
            else {
                MessageBox.Show("Error en la actualizacion");
            }

            MessageBox.Show("Actualizacion correcta");
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            FrmRegistrar_Categoria objFrmRegistrar_Categoria= new FrmRegistrar_Categoria();
            objFrmRegistrar_Categoria.MdiParent = this.MdiParent;
            objFrmRegistrar_Categoria.Show();
        }

        private void dgvConsultarCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvConsultarCategoria.Columns[e.ColumnIndex].Name=="Actualizar") {
                textBoxNombre.Text = dgvConsultarCategoria.CurrentRow.Cells[2].Value.ToString();
                textBoxDescripcion.Text = dgvConsultarCategoria.CurrentRow.Cells[3].Value.ToString();

            }
        }

        private void FrmActualizar_Categoria_Load(object sender, EventArgs e)
        {
            DataTable tablaDatos=new DataTable();

            DataGridViewButtonColumn djvEditarCategoria = new DataGridViewButtonColumn();
            djvEditarCategoria.Name = "Actualizar";
            djvEditarCategoria.Text = "Actualizar";

            tablaDatos = CN_Categoria.ConsultarCategoria();
            dgvConsultarCategoria.DataSource = tablaDatos;
            dgvConsultarCategoria.Columns[0].Visible = false;
            dgvConsultarCategoria.Columns.Add(djvEditarCategoria);
        }
    }
}
