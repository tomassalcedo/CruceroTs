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
    public partial class FrmAgregarViaje : Form
    {
        public FrmAgregarViaje()
        {
            InitializeComponent();
        }

        private void FrmAgregarViaje_Load(object sender, EventArgs e)
        {
            cmbTipoViaje.Items.Add("Viaje regional");
            cmbTipoViaje.Items.Add("Viaje extraregional");
            btnVerDetalles.Visible = false;

            foreach (Crucero item in Datos.flotaCruceros)
            {
                if (item.EnRuta == false)
                {
                    cmbCruceros.Items.Add(item.Matricula);
                }
            }

        }

        private void btnAgregarViaje_Click(object sender, EventArgs e)
        {
            string matricula = cmbCruceros.SelectedItem.ToString();
            Crucero crucero = Datos.BuscarCrucero(matricula);
            string tipoViaje = cmbTipoViaje.SelectedItem.ToString();
            EDestinos destino = (EDestinos)cmbDestinos.SelectedItem;
            string codigoViaje = txtBoxCodigoViaje.Text;
            DateTime fechaInicio = dtpFechaInicio.Value;

            if (tipoViaje == "Viaje regional")
            {
                ViajeRegional viaje = new ViajeRegional(crucero, codigoViaje, fechaInicio, destino);
                this.DialogResult = DialogResult.OK;
                Datos.viajesDisponibles.Add(viaje);
                this.Close();
            }
            else if (tipoViaje == "Viaje extraregional")
            {
                ViajeExtraRegional viaje = new ViajeExtraRegional(crucero, codigoViaje, fechaInicio, destino);
                Datos.viajesDisponibles.Add(viaje);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbTipoViaje_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDestinos.Items.Clear();

            if (cmbTipoViaje.SelectedItem.ToString() == "Viaje regional")
            {
                cmbDestinos.Items.Add(EDestinos.PuertoMadryn);
                cmbDestinos.Items.Add(EDestinos.Ushuaia);
                cmbDestinos.Items.Add(EDestinos.Montevideo);
                cmbDestinos.Items.Add(EDestinos.Recife);
                cmbDestinos.Items.Add(EDestinos.Santiago);
                cmbDestinos.Items.Add(EDestinos.Lima);
                cmbDestinos.Items.Add(EDestinos.IscaDePascua);
                cmbDestinos.Items.Add(EDestinos.IslaGalapagos);
                cmbDestinos.Items.Add(EDestinos.RioDeJaneiro);
                cmbDestinos.Items.Add(EDestinos.Cartagena);
            }
            else
            {
                cmbDestinos.Items.Add(EDestinos.LaHabana);
                cmbDestinos.Items.Add(EDestinos.Venecia);
                cmbDestinos.Items.Add(EDestinos.Acapulco);
                cmbDestinos.Items.Add(EDestinos.Miami);
                cmbDestinos.Items.Add(EDestinos.NuevaYork);
                cmbDestinos.Items.Add(EDestinos.Bangkok);
                cmbDestinos.Items.Add(EDestinos.Taipei);
                cmbDestinos.Items.Add(EDestinos.Atenas);
            }
        }

        private void btnVerDetalles_Click(object sender, EventArgs e)
        {
            string matricula = cmbCruceros.SelectedItem.ToString();
            Crucero crucero = Datos.BuscarCrucero(matricula);
            MessageBox.Show(crucero.ToString());
        }

        private void cmbCruceros_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnVerDetalles.Visible = true;
        }
    }
}
