using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PasajeroTurista : Pasajero
    {
        public PasajeroTurista(string nombre, string apellido, Pasaporte pasaporte, int pesoEquipaje) : base(nombre, apellido, pasaporte, pesoEquipaje)
        {
            this.cantidadValijas = 1;
        }

        //protected override string MostrarDatos()
        //{
        //    throw new NotImplementedException();
        //}





    }
}
