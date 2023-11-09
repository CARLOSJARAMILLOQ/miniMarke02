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
    public partial class FrmActualizar_Cliente2 : Form
    {
        public FrmActualizar_Cliente2()
        {
            InitializeComponent();
        }

        private void dgvConsultarCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvConsultarCliente.Columns[e.ColumnIndex].Name == "Actualizar")
            {
                textBoxTipoDocumento.Text = dgvConsultarCliente.CurrentRow.Cells[2].Value.ToString();
                textBoxNumeroDocumento.Text = dgvConsultarCliente.CurrentRow.Cells[3].Value.ToString();
                textBoxNombre.Text = dgvConsultarCliente.CurrentRow.Cells[4].Value.ToString();
                textBoxApellido.Text = dgvConsultarCliente.CurrentRow.Cells[5].Value.ToString();
                textBoxCorreo.Text = dgvConsultarCliente.CurrentRow.Cells[6].Value.ToString();
                textBoxTelefono.Text = dgvConsultarCliente.CurrentRow.Cells[7].Value.ToString();

            }
        }

        private void FrmActualizar_Cliente2_Load(object sender, EventArgs e)
        {
            DataTable tablaDatos = new DataTable();



            DataGridViewButtonColumn dgvEditarCliente = new DataGridViewButtonColumn();
            dgvEditarCliente.Name = "Actualizar";
            dgvEditarCliente.Text = "Actualizar";


            tablaDatos = CN_Cliente.ConsultarCliente();
            dgvConsultarCliente.DataSource = tablaDatos;
            dgvConsultarCliente.Columns[0].Visible = false;
            dgvConsultarCliente.Columns.Add(dgvEditarCliente);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Cliente objCliente = new Cliente();

            objCliente.TipoDeDocumento = textBoxTipoDocumento.Text.Trim();
            objCliente.Identificacion=textBoxNumeroDocumento.Text.Trim();
            objCliente.Nombres=textBoxNombre.Text.Trim();
            objCliente.Apellidos=textBoxApellido.Text.Trim();
            objCliente.Correo=textBoxCorreo.Text.Trim();
            objCliente.Telefono=textBoxTelefono.Text.Trim();

            if (CN_Cliente.ActualizarCliente(objCliente))
            {
                MessageBox.Show("Actualizacion Exitosa");
            }
            else {
                MessageBox.Show("Error en Actializacion");
            }

            MessageBox.Show("Actualizacion Correcta");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmRegistrarCliente2 frmActualizar_Cliente2 = new FrmRegistrarCliente2();
            frmActualizar_Cliente2.MdiParent = this.MdiParent;
            frmActualizar_Cliente2.Show();
        }
    }
}
