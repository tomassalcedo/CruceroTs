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
    public partial class FrmEditarCrucero : Form
    {
        Crucero crucero;
        public FrmEditarCrucero(Crucero crucero)
        {
            InitializeComponent();
            this.crucero = crucero;
            
        }

        private void FrmEditarCrucero_Load(object sender, EventArgs e)
        {
            dgvCrucero.Rows.Add(crucero.Matricula,crucero.NombreCrucero,crucero.CantidadCamarotesPremium,crucero.CantidadCamarotesTurista,crucero.CantidadCasinos,crucero.CapacidadBodega,crucero.EnRuta);
            cmbCamposEditar.Items.Add("Matricula");
            cmbCamposEditar.Items.Add("Nombre");
            cmbCamposEditar.Items.Add("CantCamarotesPremium");
            cmbCamposEditar.Items.Add("CantCamarotesTurista");
            cmbCamposEditar.Items.Add("CantidadCasinos");
            cmbCamposEditar.Items.Add("CapacidadBodega");
            cmbCamposEditar.Items.Add("EnRuta");

            cmbEnViaje.Visible = false;
            lblEnViaje.Visible = false;
        }


        private void cmbCamposEditar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCamposEditar.SelectedItem.ToString() == "EnRuta")
            {
                cmbEnViaje.Items.Add("Si");
                cmbEnViaje.Items.Add("no");
                lblEnViaje.Visible = true;
                cmbEnViaje.Visible = true;
            }
            else
            {
                lblEnViaje.Visible = false;
                cmbEnViaje.Visible = false;
            }
        }



        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            switch (cmbCamposEditar.SelectedItem.ToString())
            {
                case "Matricula":
                    this.crucero.Matricula = txtBoxCampo.Text;
                    break;

                case "Nombre":
                    this.crucero.NombreCrucero = txtBoxCampo.Text;
                    break;

                case "CantCamarotesPremium":
                    this.crucero.CantidadCamarotesPremium = Convert.ToInt32(txtBoxCampo.Text);
                    break;

                case "CantCamarotesTurista":
                    this.crucero.CantidadCamarotesTurista = Convert.ToInt32(txtBoxCampo.Text);
                    break;

                case "CantidadCasinos":
                    this.crucero.CantidadCasinos = Convert.ToInt32(txtBoxCampo.Text);
                    break;

                case "CapacidadBodega":
                    this.crucero.CapacidadBodega = Convert.ToInt32(txtBoxCampo.Text);
                    break;

                case "EnRuta":
                    if (cmbEnViaje.SelectedItem.ToString() == "Si")
                    {
                        this.crucero.EnRuta = true;
                    }
                    else
                    {
                        this.crucero.EnRuta = false;
                    }
                    break;
              
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

      

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
