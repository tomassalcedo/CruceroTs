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
    public partial class FrmEditarViaje : Form
    {
        private Viaje viaje;
        public FrmEditarViaje(Viaje viaje)
        {
            InitializeComponent();
            this.viaje = viaje;
        }


        private void FrmEditarViaje_Load(object sender, EventArgs e)
        {
            dtpFechaInicio.Visible = false;
            txtBoxTextos.Visible = false;
            cbCruceros.Visible = false;
            dgvViaje.Rows.Add(viaje.FechaInicio.ToShortDateString(), viaje.Duracion, viaje.CostoTurista, viaje.CostoPremium, viaje.CodigoViaje, viaje.CruceroEncargado.NombreCrucero);
            cbAtributos.Items.Add("FechaInicio");
            cbAtributos.Items.Add("CostoTurista");
            cbAtributos.Items.Add("CostoPremium");
            cbAtributos.Items.Add("CodigoViaje");
            cbAtributos.Items.Add("CruceroEncargado");
        }


        private void cbAtributos_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbAtributos.SelectedItem.ToString())
            {
                case "FechaInicio":
                    dtpFechaInicio.Visible = true;
                    txtBoxTextos.Visible = false;
                    cbCruceros.Visible = false;
                    break;

                case "CostoTurista":
                case "CostoPremium":
                case "CodigoViaje":
                    txtBoxTextos.Visible = true;
                    cbCruceros.Visible = false;
                    dtpFechaInicio.Visible = false;
                    break;

                case "CruceroEncargado":
                    cbCruceros.Visible = true;
                    dtpFechaInicio.Visible = false;
                    txtBoxTextos.Visible = false;

                    break;

            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
