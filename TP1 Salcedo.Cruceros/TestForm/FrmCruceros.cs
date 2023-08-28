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
    public partial class FrmCruceros : Form
    {
        public static List<Crucero> cruceros = Datos.flotaCruceros; //este metodo añade cruceros al atributo estatico cruceros de datos y me devuelve esa lista
        public FrmCruceros()
        {
            InitializeComponent();
        }

        private void FrmCruceros_Load(object sender, EventArgs e)
        {
            this.dgvCruceros.DataSource = cruceros;
            this.dgvCruceros.Refresh();
            this.dgvCruceros.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dgvCruceros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarCrucero_Click(object sender, EventArgs e)
        {
            FrmAgregarCrucero frmAgregarCrucero = new FrmAgregarCrucero();
            frmAgregarCrucero.ShowDialog();
            if (frmAgregarCrucero.DialogResult == DialogResult.OK)
            {
                dgvCruceros.DataSource = null;
                dgvCruceros.DataSource = cruceros;
            }
        }

        private void btnVerPasajeros_Click(object sender, EventArgs e)
        {
            if (dgvCruceros.SelectedRows.Count > 0)
            {
                //Obtengo la informacion
                Crucero auxCrucero;
                DataGridViewRow selectedRow = dgvCruceros.SelectedRows[0];
                string matricula = selectedRow.Cells["Matricula"].Value.ToString();
                auxCrucero = Datos.BuscarCrucero(matricula);
                FrmInfoCrucero frmInfoCrucero = new FrmInfoCrucero(auxCrucero);
                frmInfoCrucero.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione un crucero");
            }
        }

        
        private void btnEditarCrucero_Click(object sender, EventArgs e)
        {
            if (dgvCruceros.SelectedRows.Count > 0)
            {
                //Obtengo la informacion
                Crucero auxCrucero;
                DataGridViewRow selectedRow = dgvCruceros.SelectedRows[0];
                string matricula = selectedRow.Cells["Matricula"].Value.ToString();
                auxCrucero = Datos.BuscarCrucero(matricula);
                //  FrmInfoCrucero frmInfoCrucero = new FrmInfoCrucero(auxCrucero);
                FrmEditarCrucero frmEditarCrucero = new FrmEditarCrucero(auxCrucero);
                frmEditarCrucero.ShowDialog();
                if (frmEditarCrucero.DialogResult == DialogResult.OK)
                {
                    dgvCruceros.DataSource = null;
                    dgvCruceros.DataSource = cruceros;
                }
            }
            else
            {
                MessageBox.Show("Seleccione un crucero");
            }
        }

        private void btnEliminarCrucero_Click(object sender, EventArgs e)
        {
            if (dgvCruceros.SelectedRows.Count > 0)
            {
                Crucero auxCrucero;
                DataGridViewRow selectedRow = dgvCruceros.SelectedRows[0];
                string matricula = selectedRow.Cells["Matricula"].Value.ToString();
                auxCrucero = Datos.BuscarCrucero(matricula);
                cruceros.Remove(auxCrucero);
                dgvCruceros.DataSource = null;
                dgvCruceros.DataSource = cruceros;
            }
            else
            {
                MessageBox.Show("Seleccione un crucero");
            }
        }
    }
}
