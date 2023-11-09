using Capa_Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;

namespace miniMarke02
{
    public partial class FrmActualizar_MiniMarket : Form
    {
        public FrmActualizar_MiniMarket()
        {
            InitializeComponent();
        }

        public object JOptionPane { get; private set; }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
           MiniMarket objMiniMarket = new MiniMarket();
            objMiniMarket.Nit=textBoxNit.Text.Trim();
            objMiniMarket.RazonSocial=textBoxRazonSocial.Text.Trim();
            objMiniMarket.Telefono=textBoxTelefono.Text.Trim();
            objMiniMarket.Nomenclatura=textBoxNomenclatura.Text.Trim();
            objMiniMarket.Ciudad=textBoxCiudad.Text.Trim();
            objMiniMarket.Departamento=textBoxDepartamento.Text.Trim();
            objMiniMarket.Correo=textBoxCorreo.Text.Trim();
            objMiniMarket.SitioWeb=textBoxSitioWeb.Text.Trim();
            objMiniMarket.Facebook=textBoxFacebook.Text.Trim();
            objMiniMarket.Whastapp=textBoxWhatsapp.Text.Trim();

            if (CN_MiniMarket.ActualizarMiniMarket(objMiniMarket))
            {

                MessageBox.Show("Actualizacion exitoso");
            }
            else 
            {
                MessageBox.Show("fallo en la actualizacion");
            }

            


            MessageBox.Show("actualizacion correcta");


        }

        private void groupActualizarMiniMarket_Enter(object sender, EventArgs e)
        {

        }

        private void FrmActualizar_MiniMarket_Load(object sender, EventArgs e)
        {
            //this.BackColor = Color.LightSalmon;
            DataTable MiTablaDatos = new DataTable();

            MiTablaDatos = CN_MiniMarket.ConsutarMiniMarket();

            textBoxNit.Text = MiTablaDatos.Rows[0]["nit"].ToString();
            textBoxRazonSocial.Text = MiTablaDatos.Rows[0]["razonSocial"].ToString();
            textBoxTelefono.Text = MiTablaDatos.Rows[0]["telefono"].ToString();
            textBoxNomenclatura.Text = MiTablaDatos.Rows[0]["nomenclatura"].ToString();
            textBoxCiudad.Text = MiTablaDatos.Rows[0]["ciudad"].ToString();
            textBoxDepartamento.Text = MiTablaDatos.Rows[0]["departamento"].ToString();
            textBoxCorreo.Text = MiTablaDatos.Rows[0]["correo"].ToString();
            textBoxSitioWeb.Text = MiTablaDatos.Rows[0]["sitioWeb"].ToString();
            textBoxFacebook.Text = MiTablaDatos.Rows[0]["facebook"].ToString();
            textBoxWhatsapp.Text = MiTablaDatos.Rows[0]["whastapp"].ToString();

        }
    }
}
