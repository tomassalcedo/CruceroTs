using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Viaje
    {
        private string codigoViaje;
        protected DateTime fechaInicioViaje;
        //  protected int cantidadCamarotesDispoPremium;
        //  protected int cantidadCamarotesDispoTurista;
        protected double costoPremium;
        protected double costoTurista;
        protected int duracionViaje; //En horas
                                     //  protected List<Pasajero> pasajeros; //lista de pasajeros
        protected Crucero cruceroEncargado;
        protected EDestinos destino;
        
        


        public Viaje(Crucero cruceroEncargado, string codigoViaje, DateTime fechaInicioViaje,EDestinos destino)
        {
            this.cruceroEncargado = cruceroEncargado;
            this.CodigoViaje = codigoViaje;
            this.fechaInicioViaje = fechaInicioViaje;
            this.destino = destino;
            //   this.cantidadCamarotesDispoPremium = cantidadCamarotesDispoPremium;
            //   this.cantidadCamarotesDispoTurista = cantidadCamarotesDispoTurista;
        }


        public DateTime FechaInicio
        {
            get => fechaInicioViaje; set => fechaInicioViaje = value;
        }

        //  public int CantidadCamarotesPremium { get => cantidadCamarotesDispoPremium; }
        //  public int CantidadCamarotesTurista { get => cantidadCamarotesDispoTurista; }


        /*
                public static bool operator ==(Viaje viaje, Pasajero pasajero)
                {
                    bool retorno = false;

                    foreach (Pasajero item in viaje.pasajeros)
                    {
                        if (item == pasajero)
                        {
                            retorno = true;
                            break;
                        }
                    }

                    return retorno;
                }



                public static bool operator !=(Viaje viaje, Pasajero pasajero)
                {
                    return !(viaje == pasajero);
                }

                */

        /*
        public static Viaje operator +(Viaje viaje, Pasajero pasajero)
        {
            if (!(viaje == pasajero))
            {
                viaje.pasajeros.Add(pasajero);
            }
            else
            {
                Console.WriteLine("El pasajero ya se encuentra en el viaje");
            }

            return viaje;
        }
        */

        //  public abstract double Costo { get; }

        public abstract int Duracion { get; }

        public abstract double CostoTurista { get; set; }
     //   public double CostoFijo { get => CostoTurista; }

        public abstract double CostoPremium { get; set; }
        public string CodigoViaje { get => codigoViaje; set => codigoViaje = value; }
        public Crucero CruceroEncargado { get => cruceroEncargado; set => cruceroEncargado = value; }

        public EDestinos Destino { get => destino; set => destino = value; }

       // public abstract EDestinosExtraRegionales Destino { get => this.}

        protected abstract string MostrarViaje();

        public override string ToString()
        {
            return this.MostrarViaje();
        }


        public override bool Equals(object obj)
        {
            bool retorno = false;

            if (obj is Viaje)
            {
                retorno = this == (Viaje)obj;
            }

            return retorno;
        }




    }
}
