using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pasaje
    {

       
        protected Viaje viaje;
        protected Pasajero pasajero;
        protected Crucero crucero;

        public Pasaje(Viaje viaje, Pasajero pasajero, Crucero crucero)
        {
            this.viaje = viaje;
            this.pasajero = pasajero;
            this.crucero = crucero;
        }

        public Pasaje(ViajeRegional viaje, Pasajero pasajero, Crucero crucero)
        {

            
            this.viaje = viaje;
            this.pasajero = pasajero;
            this.crucero = crucero;
        }


        public Pasaje(ViajeExtraRegional viaje, Pasajero pasajero, Crucero crucero)
        {
            
            this.viaje = viaje;
            this.pasajero = pasajero;
            this.crucero = crucero;
        }

        public Crucero Crucero { get => crucero; }
        public Pasajero Pasajero { get => pasajero; }

        public Viaje Viaje { get => viaje; }
        
            
        


        private string MostrarPasaje()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Viaje: {this.Viaje.ToString()}");
            sb.AppendLine($"Pasajero: {this.pasajero.ToString()}");
            sb.AppendLine($"Crucero: {this.crucero.ToString()}");
            return sb.ToString();
        }

        public string MostrarPasajeShort()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Viaje: {this.Viaje.ToString()}");
            sb.AppendLine($"Pasajero: {this.pasajero.ToString()}");
            return sb.ToString();
        }
        


        public override string ToString()
        {
            return MostrarPasaje();
        }





    }
}
