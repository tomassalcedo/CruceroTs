using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace TestForm
{
    public partial class FrmVentas : Form
    {


        public FrmVentas()
        {
            InitializeComponent();
            // this.pasajesVendidos = new List<Pasaje>();
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            //List<Pasaje> listaAux = FrmVenderPasaje.PasajesVendidos;

            //if (listaAux.Count > 0)
            //{
            //    dgvVentas.DataSource = listaAux;
            //}
            dgvVentas.DataSource = Datos.ventas;

            // this.rtBoxVentas.Text += FrmVenderPasaje.GetPasajes().ToString();


        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
