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
    public partial class FrmRegistrar_Categoria : Form
    {
        public FrmRegistrar_Categoria()
        {
            InitializeComponent();
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Categoria objCategoria = new Categoria();

            objCategoria.Nombre= textBoxNombre.Text.Trim();
            objCategoria.Descripcion= textBoxDescripcion.Text.Trim();

            if (string.IsNullOrEmpty(objCategoria.Nombre) || string.IsNullOrEmpty(objCategoria.Descripcion))
            {
                MessageBox.Show("faltan campos por llenar");
                return;
            }
            if (CN_Categoria.InsertarCategoria(objCategoria))
            {
                MessageBox.Show("Insercion Exitosa");
            }
            else {
                MessageBox.Show("Error en la insercion");
            }

        }

        private void FrmRegistrar_Categoria_Load(object sender, EventArgs e)
        {
            DataTable tablaDatos = new DataTable();
            tablaDatos=CN_Categoria.ConsultarCategoria();
        }
    }
}
