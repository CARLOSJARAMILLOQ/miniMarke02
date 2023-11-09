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
using Capa_Entidades;

namespace miniMarke02
{
    public partial class FrmRegistrar_Proveedor : Form
    {
        public FrmRegistrar_Proveedor()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmRegistrar_Proveedor_Load(object sender, EventArgs e)
        {
            
            DataTable  MitablaDatos= new DataTable();
            MitablaDatos = CN_Proveedor.ConsutarProveedor();

            
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Proveedor ObjProveedor = new Proveedor();

            ObjProveedor.Nit = txtBoxNit.Text.Trim();
            ObjProveedor.RazonSocial = txtBoxRazonSocial.Text.Trim();
            ObjProveedor.Telefono = txtBoxTelefono.Text.Trim();
            ObjProveedor.Nomenclatura = txtBoxNomenclatura.Text.Trim();
            ObjProveedor.Ciudad = txtBoxCiudad.Text.Trim();
            ObjProveedor.Departamento = txtBoxDepartamento.Text.Trim();
            ObjProveedor.Correo = txtBoxCorreo.Text.Trim();

            if (string.IsNullOrEmpty(ObjProveedor.Nit) || string.IsNullOrEmpty(ObjProveedor.RazonSocial) ||
                string.IsNullOrEmpty(ObjProveedor.Telefono) || string.IsNullOrEmpty(ObjProveedor.Correo))
            {
                MessageBox.Show("Faltan campos por llenar");
                return;
            }

            if (CN_Proveedor.InsetarProveedor(ObjProveedor))
            {
                MessageBox.Show("Registro exitoso");
            }
            else
                MessageBox.Show("Fallo en la inserción");
        }
    }
}
