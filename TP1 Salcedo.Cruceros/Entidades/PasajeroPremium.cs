using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PasajeroPremium : Pasajero
    {



        public PasajeroPremium(string nombre,string apellido,Pasaporte pasaporte,int pesoEquipaje) : base(nombre,apellido,pasaporte,pesoEquipaje)
        {
            this.cantidadValijas = 2;  //2 VALIJAS POR DEFECTO CLASE PREMIUM
        }
        /*

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Apellido: {this.apellido}");
            sb.AppendLine($"Peso equipaje: {this.pesoEquipaje}");
            sb.Append(this.pasaporte.ToString());

            return sb.ToString();
        }
        */
    }
}
