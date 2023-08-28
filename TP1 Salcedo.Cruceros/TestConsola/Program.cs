using System;
using Entidades;

namespace TestConsola
{
    class Program
    {
        static void Main(string[] args)
        {

          //  Crucero titanic = new Crucero("asd", "titanic", 2, 0, 2000);

           // Pasajero pasajero = new Pasajero("Tomas","Salcedo",new Pasaporte("121",'m',new DateTime(1999,07,12),new DateTime(2027,01,22),"Argentina"),40);

           // Pasajero pasajero2 = new Pasajero("Carla", "Molina", new Pasaporte("122", 'f', new DateTime(1997, 03, 9), new DateTime(2029, 04, 22), "Argentina"), 80);

            //  Viaje viaje = new Viaje("Buenos Aires", "Cordoba", new DateTime(2022,07,12),titanic,40,80,5000,2000);

            // viaje += pasajero;

            //   Console.WriteLine(viaje.ToString());



            // ViajeExtraRegional viaje = new ViajeExtraRegional(new DateTime(2022, 07, 12), 40, 80, 5000, 2000,ViajeExtraRegional.EDestinos.Atenas);

        //    ViajeRegional viaje = new ViajeRegional("Buenos aires", new DateTime(2022, 12, 22), 200, 100, ViajeRegional.EDestinos.Cartagena);

         //   Datos.crucero1 += pasajero;

            
           // viaje += pasajero;
          //  viaje += pasajero2;

           // Console.WriteLine(viaje.ToString());
           

          //  Console.WriteLine(Datos.crucero1.ToString());

            Console.WriteLine("-----------------------------");
/*
            if (Datos.crucero1 == pasajero)
            {
                Console.WriteLine("El wachin esta");
            }
            else
            {
                Console.WriteLine("El wachin no esta");
            }
*/
            Console.WriteLine("************************************");


            ViajeExtraRegional viaje1 = new ViajeExtraRegional(new DateTime(2022, 05, 12), 400, 200, ViajeExtraRegional.EDestinos.Miami);

            PasajeroPremium pasajero = new PasajeroPremium("Tomas", "Salcedo", Datos.pasaporteM1, 50);

            Pasaje pasaje = new Pasaje(viaje1, pasajero, Datos.crucero6);

            Console.WriteLine(pasaje.ToString());

            Console.WriteLine("----------------SEPARACION----------------");


            ViajeRegional viaje2 = new ViajeRegional("Buenos aires",new DateTime(2022, 05, 12), 400, 200, ViajeRegional.EDestinos.IslaGalapagos);

            PasajeroPremium pasajero2 = new PasajeroPremium("Juan", "Zapata", Datos.pasaporteM1, 20);

            Pasaje pasaje2 = new Pasaje(viaje2, pasajero2, Datos.crucero3);

            Console.WriteLine(pasaje2.ToString());




        }
    }
}
