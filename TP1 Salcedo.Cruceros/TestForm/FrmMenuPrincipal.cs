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
    public partial class FrmMenuPrincipal : Form
    {
        Usuario usuarioLogueado;

        private List<Venta> ventasRealizadas;

        public FrmMenuPrincipal()
        {
            ventasRealizadas = new List<Venta>();
            InitializeComponent();
        }

        public FrmMenuPrincipal(Usuario user) : this()
        {
            this.usuarioLogueado = user;
        }




        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            //  pasajesVendidos.Add(FrmVenderPasaje.GetPasajes());
            Datos.LlenarCrucero(Datos.crucero1);
            Datos.LlenarCrucero(Datos.crucero2);
            Datos.LlenarCrucero(Datos.crucero3);
            Datos.LlenarCrucero(Datos.crucero4);
            Datos.LlenarCrucero(Datos.crucero5);
            Datos.LlenarCrucero(Datos.crucero6);
            Datos.LlenarCrucero(Datos.crucero7);
            Datos.HardcodearVentas();
            Datos.FlotaCruceros();
            Datos.LlenarListaViajes();
            this.lblUsuario.Text = $"Usuario: {this.usuarioLogueado.ToString()}";
            
        }


        private void btnMostrarVentas_Click(object sender, EventArgs e)
        {
            FrmVentas frmVentas = new FrmVentas();
            frmVentas.ShowDialog();

        }

        private void btnVenderPasaje_Click(object sender, EventArgs e)
        {
            FrmVenderPasaje frmVender = new FrmVenderPasaje();
            if (frmVender.ShowDialog() == DialogResult.OK)
            {

            }
            else
            {
                MessageBox.Show("Carga cancelada");
            }
        }

        private void timerFecha_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = $"Fecha: {DateTime.Now.ToShortDateString()}";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnMostrarCruceros_Click(object sender, EventArgs e)
        {
            FrmCruceros frmCruseros = new FrmCruceros();
            if (frmCruseros.ShowDialog() == DialogResult.OK)
            {

            }
            

            

        }

        private void btnMostrarViajes_Click(object sender, EventArgs e)
        {
            FrmViajes frmViajes = new FrmViajes();
            frmViajes.ShowDialog();
        }
    }
}
