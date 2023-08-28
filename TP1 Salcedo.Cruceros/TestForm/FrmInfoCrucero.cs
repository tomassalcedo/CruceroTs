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
    public partial class FrmInfoCrucero : Form
    {
        Crucero auxCrucero;
        Pasaje auxPasaje = FrmVenderPasaje.GetPasajes();

        public FrmInfoCrucero(Crucero crucero)
        {
            auxCrucero = crucero;
            InitializeComponent();
        }

        private void FrmInfoCrucero_Load(object sender, EventArgs e)
        {

            //Pasajero auxPasajero = FrmVenderPasaje.GetPasajero();

            //if (auxPasaje is not null)
            //{
            //    lblCruceroInfo.Text += $" {auxPasaje.Crucero.NombreCrucero}| Fecha inicio: {auxPasaje.Viaje.FechaInicio.ToShortDateString()}|  Cantidad de pasajeros: {auxPasaje.Crucero.CantidadPasajeros}";
            //    dgvInfoPasajeros.DataSource = auxPasaje.Crucero.Pasajeros;
            //}
            lblCruceroInfo.Text += $"{auxCrucero.NombreCrucero} | Cantidad de pasajeros: {auxCrucero.Pasajeros.Count}";
            dgvInfoPasajeros.DataSource = auxCrucero.Pasajeros;
        }

        private void dgvInfoPasajeros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Verifico si hay una fila seleccioada en el data grid view
            if (dgvInfoPasajeros.SelectedRows.Count > 0)
            {
                //Obtengo la informacion
                Pasajero auxPasajero;
                DataGridViewRow selectedRow = dgvInfoPasajeros.SelectedRows[0];
                int numPasaporte = Convert.ToInt32(selectedRow.Cells["NumeroPasaporte"].Value);
                // auxPasajero = auxPasaje.Crucero.BuscarPasajeroPasaporte(numPasaporte);
                auxPasajero = auxCrucero.BuscarPasajeroPasaporte(numPasaporte);

                FrmEditarPasajero frmEditar = new FrmEditarPasajero(auxPasajero);
                frmEditar.ShowDialog();

                if (frmEditar.DialogResult == DialogResult.OK)
                {
                    Pasajero pasajero = frmEditar.Pasajero;
                    auxPasajero = pasajero;
                }

                dgvInfoPasajeros.DataSource = null;
                dgvInfoPasajeros.DataSource = auxCrucero.Pasajeros;
                

            }
            else
            {
                MessageBox.Show("Seleccione un pasajero");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminarPasajero_Click(object sender, EventArgs e)
        {
            //Verifico si hay una fila seleccioada en el data grid view
            if (dgvInfoPasajeros.SelectedRows.Count > 0)
            {
                //Obtengo la informacion
                Pasajero auxPasajero;
                DataGridViewRow selectedRow = dgvInfoPasajeros.SelectedRows[0];
                int numPasaporte = Convert.ToInt32(selectedRow.Cells["NumeroPasaporte"].Value);
                auxPasajero = auxCrucero.BuscarPasajeroPasaporte(numPasaporte);

                auxCrucero.Pasajeros.Remove(auxPasajero);

                dgvInfoPasajeros.DataSource = null;
                dgvInfoPasajeros.DataSource = auxCrucero.Pasajeros;
            }
            else
            {
                MessageBox.Show("Seleccione un pasajero");
            }
        }
    }
}
