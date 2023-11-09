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
    public partial class FrmRegistrarCliente2 : Form
    {
        public FrmRegistrarCliente2()
        {
            InitializeComponent();
        }

        private void FrmRegistrarCliente2_Load(object sender, EventArgs e)
        {
            DataTable miTatabladatos = new DataTable();
            miTatabladatos = CN_Cliente.ConsultarCliente();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            Cliente objCliente = new Cliente();
            objCliente.TipoDeDocumento = comboBoxTipoDocumento.Text.Trim();
            objCliente.Identificacion = textBoxNumeroDocumento.Text.Trim();
            objCliente.Nombres = textBoxNombre.Text.Trim();
            objCliente.Apellidos = textBoxApellido.Text.Trim();
            objCliente.Correo = textBoxCorreo.Text.Trim();
            objCliente.Telefono = textBoxTelefono.Text.Trim();

            if (string.IsNullOrEmpty(objCliente.TipoDeDocumento) || string.IsNullOrEmpty(objCliente.Identificacion) ||
               string.IsNullOrEmpty(objCliente.Nombres) || string.IsNullOrEmpty(objCliente.Apellidos))
            {
                MessageBox.Show("Faltan campos por llenar");
                return;
            }

            if (CN_Cliente.InsertarCliente(objCliente))
            {
                MessageBox.Show("Registro exitoso");
            }
            else
                MessageBox.Show("Fallo en la inserción");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
