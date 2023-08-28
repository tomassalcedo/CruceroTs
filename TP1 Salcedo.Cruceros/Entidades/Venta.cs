using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Venta
    {
        int codigoVenta;
        Usuario usuario;
        Pasaje pasaje;


        public Venta(int codigoVenta,Usuario usuario, Pasaje pasaje)
        {
            this.codigoVenta = codigoVenta;
            this.usuario = usuario;
            this.pasaje = pasaje;
        }

        public int Codigo { get => codigoVenta; }
        public string Vendedor { get => usuario.NombreUsuario; }

        public string NombrePasajero { get => pasaje.Pasajero.Nombre; }
        public int NumeroPasaporte { get => pasaje.Pasajero.NumeroPasaporte; }
        public string CodigoViaje { get => pasaje.Viaje.CodigoViaje; }
        

        private string MostrarVenta()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Venta realizada por: {this.usuario.ToString()}");
            sb.AppendLine(this.pasaje.ToString());
            
            return sb.ToString();
        }

        public override string ToString()
        {
            return MostrarVenta();
        }

    }
}
