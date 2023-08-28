using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Entidades
{
    public class Crucero
    {
        protected string matricula;
        protected string nombre;
        protected int cantidadCamarotesPremium; 
        protected int cantidadCamarotesTurista;
        protected int cantidadCasinos; //Puede no tener
        protected int capacidadBodega;//en kilogramos
        protected List<Pasajero> pasajeros;
        private bool enRuta;

        private Crucero()
        {
            this.pasajeros = new List<Pasajero>();
        }

        public Crucero(string matricula, string nombre) : this()
        {
            this.matricula = matricula;
            this.nombre = nombre;
        }


        public Crucero(string matricula, string nombre, int cantidadCamarotesPremium, int cantidadCamarotesTurista, int cantidadCasinos, int capacidadBodega) : this(matricula, nombre)
        {
            this.cantidadCamarotesTurista = cantidadCamarotesTurista;
            this.CantidadCamarotesPremium = cantidadCamarotesPremium;
            this.cantidadCasinos = cantidadCasinos;
            this.capacidadBodega = capacidadBodega;
        }

        public string Matricula { get => matricula; set => matricula = value; }
        public int CantidadCasinos { get => cantidadCasinos; set => cantidadCasinos = value; }
        public int CapacidadBodega { get => capacidadBodega; set => capacidadBodega = value; }

        public int CantidadPasajeros
        {
            get
            {
                if (this.pasajeros.Count > 0)
                {
                    return this.pasajeros.Count;
                }
                else
                {
                    return 0;
                }
            }
        }


        public int CantidadCamarotesPremium { get => cantidadCamarotesPremium; set => cantidadCamarotesPremium = value; }
        public int CantidadCamarotesTurista { get => cantidadCamarotesTurista; set => cantidadCamarotesTurista = value; }
        public bool EnRuta { get => enRuta; set => enRuta = value; }
        public string NombreCrucero { get => nombre; set => nombre = value; }

        
       public List<Pasajero> Pasajeros { get => pasajeros; }

        private string MostrarCrucero()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("-----CRUCERO-----");
            sb.AppendLine($"Matricula: {this.matricula}");
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Cantidad de camarotes premium: {this.CantidadCamarotesPremium}");
            sb.AppendLine($"Cantidad de camarotes turista: {this.CantidadCamarotesTurista}");
            sb.AppendLine($"Cantidad de casinos: {this.cantidadCasinos}");
            sb.AppendLine($"Capacidad bodega: {this.capacidadBodega}");

            //if (pasajeros.Count >= 1)
            //{
            //    sb.AppendLine($"**********PASAJEROS: {CantidadPasajeros}**********");

            //    foreach (Pasajero item in pasajeros)
            //    {
            //        sb.AppendLine(item.ToString());
            //    }
            //}
            return sb.ToString();
        }



        public Pasajero BuscarPasajeroPasaporte(int numPasaporte)
        {
            foreach (Pasajero item in pasajeros)
            {
                if (numPasaporte == item.NumeroPasaporte)
                {
                    return item;
                }
            }
            return null;
        }

        public static bool operator ==(Crucero crucero, Pasajero pasajero)
        {
            bool retorno = false;

            foreach (Pasajero item in crucero.pasajeros)
            {
                if (item == pasajero)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public static bool operator !=(Crucero crucero, Pasajero pasajero)
        {
            return !(crucero == pasajero);
        }

        public static Crucero operator +(Crucero crucero, Pasajero pasajero)
        {
            if (!(crucero == pasajero)) //si no esta
            {
                crucero.pasajeros.Add(pasajero);
            }
            else
            {
                Console.WriteLine("El pasajero ya se encuentra en el viaje");
            }

            return crucero;
        }


        public override string ToString()
        {
            return this.MostrarCrucero();
        }




        public void LlenarCrucero(List<Crucero> listaCruceros)
        {
            //listaCruceros.Add(Datos.pasajero1);
            //listaCruceros.Add(Datos.pasajero2);
            //listaCruceros.Add(Datos.pasajero3);
            //listaCruceros.Add(Datos.pasajero4);
            //listaCruceros.Add(Datos.pasajero5);
            //listaCruceros.Add(Datos.pasajero6);
            //listaCruceros.Add(Datos.pasajero7);
            //listaCruceros.Add(Datos.pasajero8);
            //listaCruceros.Add(Datos.pasajero9);
            //listaCruceros.Add(Datos.pasajero19);
        }




    }
}
