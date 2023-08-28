using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Pasajero
    {
        //ATRIBUTOS
        protected string nombre;
        protected string apellido;
        protected Pasaporte pasaporte;
        protected int cantidadValijas;
        protected int pesoEquipaje;
        protected bool esPremium;

        public Pasajero(string nombre, string apellido, Pasaporte pasaporte, int pesoEquipaje)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.pasaporte = pasaporte;
            this.pesoEquipaje = pesoEquipaje;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int NumeroPasaporte { get => pasaporte.Numero; set => pasaporte.Numero = value; }
        public int CantidadValijas { get => cantidadValijas; set => cantidadValijas = value; }
        public int PesoEquipaje { get => pesoEquipaje; set => pesoEquipaje = value; }






        /*
          private string MostrarDatos()
          {
              StringBuilder sb = new StringBuilder();

              sb.AppendLine($"Nombre: {this.nombre}");
              sb.AppendLine($"Apellido: {this.apellido}");
              sb.AppendLine($"Peso equipaje: {this.pesoEquipaje}");
              sb.Append(this.pasaporte.ToString());

              return sb.ToString();
          }



        */

        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Apellido: {this.apellido}");
            sb.AppendLine($"Peso equipaje: {this.pesoEquipaje}");
            sb.Append(this.pasaporte.ToString());

            return sb.ToString();
        }

        public void Psa()
        {

        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }

        public static bool operator ==(Pasajero p1, Pasajero p2)
        {
            bool retorno = false;

            if (p1.pasaporte == p2.pasaporte)
            {
                retorno = true;
            }

            return retorno;
        }


        public static bool operator !=(Pasajero p1, Pasajero p2)
        {
            return !(p1 == p2);
        }






    }
}
