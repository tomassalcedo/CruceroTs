using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ViajeExtraRegional : Viaje
    {

        //public enum EDestinos
        //{
        //    LaHabana,
        //    Venecia,
        //    Acapulco,
        //    Miami,
        //    NuevaYork,
        //    Bangkok,
        //    Taipei,
        //    Atenas
        //}

        //private EDestinos destino;



        public ViajeExtraRegional(Crucero cruceroEncargado, string codigoViaje, DateTime fechaInicioViaje, EDestinos destino) : base(cruceroEncargado, codigoViaje, fechaInicioViaje,destino)
        {
           // SetDuracion();
            Random numRandom = new Random();
            int duracion = numRandom.Next(480, 720);
            this.duracionViaje = duracion;
            const int pesoHora = 30;
            const int pesoHoraPremium = 50;
            double costo = this.duracionViaje * pesoHora;
            double costoPremium = this.duracionViaje * pesoHoraPremium;
            this.CostoTurista = costo;
            this.CostoPremium = costoPremium;
        }

        public override int Duracion
        {
            get
            {
               return this.duracionViaje;
            }
        }

        public override double CostoTurista { get => this.costoTurista; set => this.costoTurista = value; }
        public override double CostoPremium { get => this.costoPremium; set => this.costoPremium = value; }

        //public override double CostoTurista
        //{
        //    get
        //    {
        //        SetDuracion();
        //        const int pesoHora = 30;
        //        double costo = 0;
        //        costo = duracionViaje * pesoHora;
        //        return costo;
        //    }
        //}




        //public override double CostoPremium
        //{
        //    get
        //    {
        //        SetDuracion();
        //        const int pesoHora = 50;
        //        double costo = 0;
        //        costo = duracionViaje * pesoHora;
        //        return costo;
        //    }
        //}




        //public override double Costo
        //{

        //    get
        //    {
        //        SetDuracion();
        //        const int pesoHora = 57;
        //        int hora = 0;
        //        double costo = 0;

        //        for (int i = 0; i < this.duracionViaje; i++)
        //        {
        //            hora++;
        //        }

        //        costo = hora * pesoHora;

        //        return costo;
        //    }
        //}


        protected override string MostrarViaje()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre del crucero: {this.cruceroEncargado.NombreCrucero}");
            sb.AppendLine($"Codigo de viaje: {this.CodigoViaje}");
            sb.AppendLine($"Destino: {this.destino}");
            sb.AppendLine($"Camararotes Premium: {this.cruceroEncargado.CantidadCamarotesPremium}");
            sb.AppendLine($"Camarotes Turista: {this.cruceroEncargado.CantidadCamarotesTurista}");
            sb.AppendLine($"Costo premium: {this.CostoPremium}");
            sb.AppendLine($"Costo turista: ${this.CostoTurista}");
            sb.AppendLine($"Duracion del viaje: {this.Duracion.ToString()} HS");
            sb.AppendLine($"--------------------------------------------------------------");
            return sb.ToString();
        }





        public override string ToString()
        {
            return this.MostrarViaje();
        }

    }
}
