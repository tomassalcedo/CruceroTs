using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ViajeRegional : Viaje
    {


        //public enum EDestinos
        //{
        //    Montevideo,
        //    Ushuaia,
        //    Recife,
        //    Santiago,
        //    Lima,
        //    IscaDePascua,
        //    IslaGalapagos,
        //    PuertoMadryn,
        //    RioDeJaneiro,
        //    Cartagena
        //}

        //private EDestinos destino;

        public ViajeRegional(Crucero cruceroEngarcado, string codigoViaje, DateTime fechaInicioViaje, EDestinos destino) : base(cruceroEngarcado, codigoViaje, fechaInicioViaje,destino)
        {
           
        }


        public override int Duracion
        {
            get
            {
                Random random = new Random();
                int duracion;

                duracion = random.Next(72, 360);

                return duracion;
            }
        }

      

        public override double CostoTurista { get => this.costoTurista; set => this.costoTurista = value; }
        public override double CostoPremium { get => this.costoPremium; set => this.costoPremium = value; }

        // private void SetDuracion()
        // {
        //  this.duracionViaje = Duracion;
        //  }



        //hora X precio


        //public override double Costo
        //{
        //    get
        //    {
        //        SetDuracion();
        //        const int pesosHora = 57;
        //        int hora = 0;
        //        double costo = 0;

        //        for (int i = 0; i < this.duracionViaje; i++)
        //        {
        //            hora++;
        //        }

        //        costo = hora * pesosHora;

        //        return costo;
        //    }
        //}


        protected override string MostrarViaje()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"----------------------------------------------------");
            sb.AppendLine($"Destino: {this.destino}");
            sb.AppendLine($"Camararotes Premium: {this.CruceroEncargado.CantidadCamarotesPremium}");
            sb.AppendLine($"Camarotes Turista: {this.CruceroEncargado.CantidadCamarotesTurista}");
            sb.AppendLine($"Costo premium: {this.CostoPremium}");
            sb.AppendLine($"Costo turista: ${this.CostoTurista}");
            sb.AppendLine($"Duracion: {this.duracionViaje.ToString()}");
            sb.AppendLine($"----------------------------------------------------");
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.MostrarViaje();
        }






    }
}
