using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pasaporte 
    {

        private int numero;
        private string sexo;
        private DateTime fechaNacimiento;
        private DateTime fechaVencimiento;
        private string nacionalidad;

        public Pasaporte(int numero, string sexo, DateTime fechaNacimiento, DateTime fechaVencimiento, string nacionalidad)
        {
            this.numero = numero;
            this.sexo = sexo;
            this.fechaNacimiento = fechaNacimiento;
            this.fechaVencimiento = fechaVencimiento;
            this.nacionalidad = nacionalidad;
        }


        public int Numero { get => numero; set => numero = value; }
        private string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("-----PASAPORTE-----");
            sb.AppendLine($"Numero: {this.numero}");
            sb.AppendLine($"Sexo: {this.sexo}");
            sb.AppendLine($"Fecha Nacimiento: {this.fechaNacimiento.ToShortTimeString()}");
            sb.AppendLine($"Fecha Vencimiento: {this.fechaVencimiento.ToShortTimeString()}");
            sb.AppendLine($"Nacionalidad: {this.nacionalidad}");

            return sb.ToString();
        }


        public override string ToString()
        {
            return this.MostrarDatos();
        }



        public static bool operator ==(Pasaporte pasaporte1, Pasaporte pasaporte2)
        {
            bool retorno = false;

            if (pasaporte1.numero == pasaporte2.numero)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Pasaporte pasaporte1, Pasaporte pasaporte2)
        {
            return !(pasaporte1 == pasaporte2);
        }


    }






}
