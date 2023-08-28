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
    public partial class FrmAgregarCrucero : Form
    {
        public FrmAgregarCrucero()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAgregarCrucero_Click(object sender, EventArgs e)
        {
            string matricula = txtBoxMatricula.Text;
            string nombre = txtBoxNombre.Text;
            int cantCamarotesPremium = Convert.ToInt32(txtBoxCantCamarotesPremium.Text);
            int cantCamarotesTurista = Convert.ToInt32(txtBoxCantCamarotesTurista.Text);
            int cantCasinos = Convert.ToInt32(txtBoxCantCasinos.Text);
            int capacidadBodega = Convert.ToInt32(txtBoxCapacidadBodega.Text);
            Crucero nuevoCrucero = new Crucero(matricula,nombre,cantCamarotesPremium,cantCamarotesTurista,cantCasinos,capacidadBodega);
            //Datos.flotaCruceros.Add(nuevoCrucero);
            FrmCruceros.cruceros.Add(nuevoCrucero);
            this.DialogResult = DialogResult.OK;
        }
    }
}
