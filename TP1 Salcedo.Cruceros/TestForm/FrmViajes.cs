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
    public partial class FrmViajes : Form
    {
        public FrmViajes()
        {
            InitializeComponent();
        }

        private void FrmViajes_Load(object sender, EventArgs e)
        {
            dgvViajes.DataSource = Datos.viajesDisponibles;
        }

        private void btnAgregarViaje_Click(object sender, EventArgs e)
        {
            //FrmAgregarCrucero frmAgregarCrucero = new FrmAgregarCrucero();
            //frmAgregarCrucero.ShowDialog();
            //if (frmAgregarCrucero.DialogResult == DialogResult.OK)
            //{
            //    dgvCruceros.DataSource = null;
            //    dgvCruceros.DataSource = cruceros;
            //}
            FrmAgregarViaje frmAgregarViaje = new FrmAgregarViaje();
            frmAgregarViaje.ShowDialog();
            if (frmAgregarViaje.DialogResult == DialogResult.OK)
            {
                dgvViajes.DataSource = null;
                dgvViajes.DataSource = Datos.viajesDisponibles;
            }

        }

        private void btnEliminarViaje_Click(object sender, EventArgs e)
        {
            if (dgvViajes.SelectedRows.Count > 0)
            {
                Viaje auxViaje;
                DataGridViewRow selectedRow = dgvViajes.SelectedRows[0];
                string codigoViaje = selectedRow.Cells["CodigoViaje"].Value.ToString();
                auxViaje = Datos.BuscarViaje(codigoViaje);
                Datos.viajesDisponibles.Remove(auxViaje);
                dgvViajes.DataSource = null;
                dgvViajes.DataSource = Datos.viajesDisponibles;
            }
            else
            {
                MessageBox.Show("Seleccione un viaje");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditarViaje_Click(object sender, EventArgs e)
        {
            if (dgvViajes.SelectedRows.Count > 0)
            {
                Viaje auxViaje;
                DataGridViewRow selectedRow = dgvViajes.SelectedRows[0];
                string codigoViaje = selectedRow.Cells["CodigoViaje"].Value.ToString();
                auxViaje = Datos.BuscarViaje(codigoViaje);
                FrmEditarViaje editarViaje = new FrmEditarViaje(auxViaje);
                editarViaje.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Seleccione un viaje");
            }
        }
    }
}
