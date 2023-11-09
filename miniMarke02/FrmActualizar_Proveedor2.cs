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
    public partial class FrmActualizar_Proveedor2 : Form
    {
        public FrmActualizar_Proveedor2()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Proveedor objProveedor = new Proveedor();

            //objProveedor.Nit = textBoxNit.Text.Trim();
            //objProveedor.RazonSocial = textBoxRazonSocial.Text.Trim();
            objProveedor.Telefono = textBoxTelefono.Text.Trim();
            objProveedor.Nomenclatura = textBoxNomenclatura.Text.Trim();
            objProveedor.Ciudad = textBoxCiudad.Text.Trim();
            objProveedor.Departamento = textBoxDepartamento.Text.Trim();
            objProveedor.Correo = textBoxCorreo.Text.Trim();
            textBoxNit.Enabled = false;
            textBoxRazonSocial.Enabled = false;

            if (CN_Proveedor.ActualizarProveedor(objProveedor))
            {

                MessageBox.Show("Actualizacion exitosa");
            }
            else
            {
                MessageBox.Show("fallo en la actualizacion");
            }




            MessageBox.Show("actualizacion correcta");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmRegistrar_Proveedor frmRegistrarProveedor = new FrmRegistrar_Proveedor();

            frmRegistrarProveedor.MdiParent = this.MdiParent; // Se asigna el mismo formulario de registro.
            frmRegistrarProveedor.Show();
        }

        private void dgvConsultarProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvConsultarProveedor.Columns[e.ColumnIndex].Name == "Actualizar")
            {
                textBoxNit.Text = dgvConsultarProveedor.CurrentRow.Cells[2].Value.ToString();
                textBoxRazonSocial.Text = dgvConsultarProveedor.CurrentRow.Cells[3].Value.ToString();
                textBoxTelefono.Text = dgvConsultarProveedor.CurrentRow.Cells[4].Value.ToString();
                textBoxNomenclatura.Text = dgvConsultarProveedor.CurrentRow.Cells[5].Value.ToString();
                textBoxCiudad.Text = dgvConsultarProveedor.CurrentRow.Cells[6].Value.ToString();
                textBoxDepartamento.Text = dgvConsultarProveedor.CurrentRow.Cells[7].Value.ToString();
                textBoxCorreo.Text = dgvConsultarProveedor.CurrentRow.Cells[8].Value.ToString();
            }
        }

        private void FrmActualizar_Proveedor2_Load(object sender, EventArgs e)
        {
            DataTable tablaDatos = new DataTable();



            DataGridViewButtonColumn dgvEditarProveedor = new DataGridViewButtonColumn();
            dgvEditarProveedor.Name = "Actualizar";
            dgvEditarProveedor.Text = "Actualizar";


            tablaDatos = CN_Proveedor.ConsutarProveedor();
            dgvConsultarProveedor.DataSource = tablaDatos;
            dgvConsultarProveedor.Columns[0].Visible = false;
            dgvConsultarProveedor.Columns.Add(dgvEditarProveedor);
        }
    }
}
