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
    public partial class FrmEditarPasajero : Form
    {
        //ATRIBUTO
        private Pasajero pasajero;
        public FrmEditarPasajero(Pasajero pasajero)
        {
            InitializeComponent();
            this.pasajero = pasajero;
        }


        //propiedad
        public Pasajero Pasajero { get => pasajero; }

        private void FrmEditarPasajero_Load(object sender, EventArgs e)
        {
            //this.dgvViajesDisponibles.Rows.Add(Datos.viaje2.CodigoViaje, Datos.viaje2.Destino, Datos.viaje2.CruceroEncargado.CantidadCamarotesPremium, Datos.viaje2.CruceroEncargado.CantidadCamarotesTurista, Datos.viaje2.CostoPremium, Datos.viaje2.CostoTurista, Datos.viaje2.Duracion);
            //dgvPasajeroEditar.DataSource = pasajero;
            dgvPasajeroEditar.Rows.Add(pasajero.Nombre, pasajero.Apellido, pasajero.NumeroPasaporte, pasajero.CantidadValijas, pasajero.PesoEquipaje);
            cbCamposEditar.Items.Add("Nombre");
            cbCamposEditar.Items.Add("Apellido");
            cbCamposEditar.Items.Add("NumeroPasaporte");
            cbCamposEditar.Items.Add("CantidadValijas");
            cbCamposEditar.Items.Add("PesoEquipaje");
        }

        private void cbCamposEditar_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtValorEditado.Visible = false;

            switch (cbCamposEditar.SelectedItem.ToString())
            {
                case "Nombre":
                    txtValorEditado.Visible = true;
                    txtValorEditado.PlaceholderText = "Ingrese nombre";
                    break;
                case "Apellido":
                    txtValorEditado.Visible = true;
                    txtValorEditado.PlaceholderText = "Ingrese apellido";
                    break;

                case "NumeroPasaporte":
                    txtValorEditado.Visible = true;
                    txtValorEditado.PlaceholderText = "Ingrese numero pasaporte";
                    break;

                case "CantidadValijas":
                    txtValorEditado.Visible = true;
                    txtValorEditado.PlaceholderText = "Ingrese cantidad de valijas";
                    break;

                case "PesoEquipaje":
                    txtValorEditado.Visible = true;
                    txtValorEditado.PlaceholderText = "Ingrese peso equipaje";
                    break;
            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            switch (cbCamposEditar.SelectedItem.ToString())
            {
                case "Nombre":
                    this.pasajero.Nombre = txtValorEditado.Text;
                    break;
                case "Apellido":
                    this.pasajero.Apellido = txtValorEditado.Text;
                    break;

                case "NumeroPasaporte":
                    this.pasajero.NumeroPasaporte = Convert.ToInt32(txtValorEditado.Text);
                    break;

                case "CantidadValijas":
                    this.pasajero.CantidadValijas = Convert.ToInt32(txtValorEditado.Text);
                    break;

                case "PesoEquipaje":
                    this.pasajero.PesoEquipaje = Convert.ToInt32(txtValorEditado.Text);
                    break;  
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

     
    }
}
