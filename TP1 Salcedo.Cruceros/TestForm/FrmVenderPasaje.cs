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
    public partial class FrmVenderPasaje : Form
    {
        // static Pasaje pasajeVendido;
        static Pasaje pasajeVendido;
        static Pasajero pasajeroCreado;
        Pasaporte pasaporteCreado;
        Viaje viajeSeleccionado;
        static List<Pasaje> pasajesVendidos;
        int idVenta = 4;

        public FrmVenderPasaje()
        {
            InitializeComponent();
            pasajesVendidos = new List<Pasaje>();
        }


        public static Pasaje PasajeVendido { get => pasajeVendido; set => pasajeVendido = value; }
        public Pasajero PasajeroCreado { get => pasajeroCreado; set => pasajeroCreado = value; }
        public Pasaporte PasaporteCreado { get => pasaporteCreado; set => pasaporteCreado = value; }
        public Viaje ViajeSeleccionado { get => viajeSeleccionado; set => viajeSeleccionado = value; }

        public static List<Pasaje> PasajesVendidos { get => pasajesVendidos; }

        private void FrmVenderPasaje_Load(object sender, EventArgs e)
        {

            // this.rtBoxViajesDisponibles.Text += Datos.viaje1.ToString();
            // this.rtBoxViajesDisponibles.Text += Datos.viaje2.ToString();
            //this.rtBoxViajesDisponibles.Text += Datos.viaje3.ToString();
            //  Datos.viajesDisponibles.Add(Datos.viaje1);
            //  Datos.viajesDisponibles.Add(Datos.viaje2);
            //  Datos.viajesDisponibles.Add(Datos.viaje3);

            //dgvViajesDisponibles.DataSource = Datos.viajesDisponibles;
            // this.dgvViajesDisponibles.Rows.Add(Datos.viaje1.CodigoViaje, Datos.viaje1.Destino, Datos.viaje1.CruceroEncargado.CantidadCamarotesPremium, Datos.viaje1.CruceroEncargado.CantidadCamarotesTurista, Datos.viaje1.CostoPremium, Datos.viaje1.CostoTurista, Datos.viaje1.Duracion);
            // this.dgvViajesDisponibles.Rows.Add(Datos.viaje2.CodigoViaje, Datos.viaje2.Destino, Datos.viaje2.CruceroEncargado.CantidadCamarotesPremium, Datos.viaje2.CruceroEncargado.CantidadCamarotesTurista, Datos.viaje2.CostoPremium, Datos.viaje2.CostoTurista, Datos.viaje2.Duracion);
            dgvViajesDisponibles.DataSource = Datos.viajesDisponibles;
          //  dgvViajesDisponibles.Columns["CostoTurista"].DataPropertyName = "CostoFijo";
            
        }

        private void btnGuardarDatosPasajero_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(this.txtBoxNumeroPasaporte.Text);
            string sexo = this.cmbSexo.Text;
            DateTime fechaNacimimiento = this.dtpFechaNacimiento.Value;
            DateTime fechaVencimiento = this.dtpFechaVencimiento.Value;
            string nacionalidad = this.txtBoxNacionalidad.Text;

            pasaporteCreado = new Pasaporte(numero, sexo, fechaNacimimiento, fechaVencimiento, nacionalidad);
            string nombre = this.txtBoxNombre.Text;
            string apellido = this.txtBoxApellido.Text;
            int cantidadValijas = int.Parse(this.txtBoxCantidadValijas.Text);
            int pesoEquipaje = int.Parse(this.txtBoxPesoEquipaje.Text);
            string esPremium = this.cmbPremium.Text;

            if (esPremium == "Si")
            {
                pasajeroCreado = new PasajeroPremium(nombre, apellido, pasaporteCreado, pesoEquipaje);
            }
            else
            {
                pasajeroCreado = new PasajeroTurista(nombre, apellido, pasaporteCreado, pesoEquipaje);
            }

            this.rtBoxDatosPasaje.Text += pasajeroCreado.ToString();
        }


        private void dgvViajesDisponibles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Viaje auxViaje;
            string codigoViaje = dgvViajesDisponibles.Rows[e.RowIndex].Cells[4].Value.ToString();
            auxViaje = Datos.BuscarViaje(codigoViaje);
            DialogResult resultado = MessageBox.Show(auxViaje.ToString(), "Viaje", MessageBoxButtons.YesNoCancel);
            if (resultado == DialogResult.Yes)
            {
                if (pasajeroCreado is PasajeroPremium && auxViaje.CruceroEncargado.CantidadCamarotesPremium < 1)
                {
                    MessageBox.Show("Sin camarotes premium");
                    
                }
                else if (pasajeroCreado is PasajeroTurista && auxViaje.CruceroEncargado.CantidadCamarotesTurista < 1)
                {
                    MessageBox.Show("Sin camarotes turista");
                    
                }
                else
                {
                    viajeSeleccionado = auxViaje;
                    this.rtBoxDatosPasaje.Text += viajeSeleccionado.ToString();
                }
            }
        }


        private void btnGenerarPasaje_Click(object sender, EventArgs e)
        {
            if (pasajeroCreado is PasajeroPremium)
            {
                viajeSeleccionado.CruceroEncargado.CantidadCamarotesPremium--;
            }
            else if (pasajeroCreado is PasajeroTurista)
            {
                viajeSeleccionado.CruceroEncargado.CantidadCamarotesTurista--;
            }


            // Datos.LlenarCrucero(viajeSeleccionado.CruceroEncargado);
            //viajeSeleccionado.CruceroEncargado.EnRuta = true;
            viajeSeleccionado.CruceroEncargado += pasajeroCreado;
            pasajeVendido = new Pasaje(viajeSeleccionado, pasajeroCreado, viajeSeleccionado.CruceroEncargado);
            pasajesVendidos.Add(pasajeVendido);
            Datos.ventas.Add(new Venta(Datos.id, Datos.usuario1, pasajeVendido));
            Datos.id++;
            MessageBox.Show($"****PASAJE CREADO****\n{pasajeVendido.MostrarPasajeShort()}");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public static Pasaje GetPasajes()
        {
            if (pasajeVendido is not null)
            {
                return pasajeVendido;
            }
            return null;
        }

        public static Pasajero GetPasajero()
        {
            if (pasajeroCreado is not null)
            {
                return pasajeroCreado;
            }
            return null;
        }




        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
