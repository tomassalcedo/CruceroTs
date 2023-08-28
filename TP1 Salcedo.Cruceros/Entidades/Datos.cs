using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Datos
    {

        public static List<Viaje> viajesDisponibles = new List<Viaje>();
        public static List<Usuario> usuariosHardcodeados = new List<Usuario>();
        public static List<Crucero> flotaCruceros;
        public static List<Venta> ventas = new List<Venta>();
        public static int id = 4;


        //PASAPORTES
        public static Pasaporte pasaporteM1 = new Pasaporte(56240, "m", new DateTime(1997, 05, 1), new DateTime(2025, 11, 9), "Argentina");
        public static Pasaporte pasaporteM2 = new Pasaporte(2252, "m", new DateTime(1999, 02, 12), new DateTime(2027, 3, 20), "Argentina");
        public static Pasaporte pasaporteM3 = new Pasaporte(2284, "m", new DateTime(1993, 04, 7), new DateTime(2029, 2, 4), "Argentina");
        public static Pasaporte pasaporteM4 = new Pasaporte(6193, "m", new DateTime(2000, 02, 22), new DateTime(2023, 4, 2), "Argentina");
        public static Pasaporte pasaporteM5 = new Pasaporte(1542, "m", new DateTime(1977, 01, 2), new DateTime(2027, 12, 1), "Argentina");
        public static Pasaporte pasaporteM6 = new Pasaporte(1943, "m", new DateTime(2010, 12, 9), new DateTime(2028, 9, 9), "Argentina");
        public static Pasaporte pasaporteM7 = new Pasaporte(1541, "m", new DateTime(2012, 2, 5), new DateTime(2029, 6, 4), "Argentina");
        public static Pasaporte pasaporteM8 = new Pasaporte(2154, "m", new DateTime(2018, 12, 9), new DateTime(2026, 12, 9), "Argentina");
        public static Pasaporte pasaporteM9 = new Pasaporte(5874, "m", new DateTime(1991, 02, 12), new DateTime(2026, 10, 2), "Argentina");
        public static Pasaporte pasaporteM10 = new Pasaporte(1254, "m", new DateTime(1994, 08, 12), new DateTime(2029, 12, 5), "Argentina");

        

        //FLOTA DE CRUCEROS
        public static Crucero crucero1 = new Crucero("AABC11", "Titanic",1,1,3,5000);
        public static Crucero crucero2 = new Crucero("KKA001", "Atenas", 1000,600,8 ,7000);
        public static Crucero crucero3 = new Crucero("MMI112", "Carpathia", 400, 280,0,2000);
        public static Crucero crucero4 = new Crucero("OOS221", "SantaTeresita", 3000, 1900,7,20000);
        public static Crucero crucero5 = new Crucero("MLP441", "CostaFarba", 700, 800,1 ,1500);
        public static Crucero crucero6 = new Crucero("BBV001", "Perseus", 880, 200, 0,5000);
        public static Crucero crucero7 = new Crucero("AOE149", "Britanic", 2000,2000 ,9,60000);

        //PASAJEROS
        public static PasajeroPremium pasajero1 = new PasajeroPremium("Mario", "Ballotelli", pasaporteM1, 25);
        public static PasajeroPremium pasajero2 = new PasajeroPremium("Marcos", "Saracho", pasaporteM2, 50);
        public static PasajeroPremium pasajero3 = new PasajeroPremium("Pedro", "Rojo", pasaporteM3, 15);
        public static PasajeroPremium pasajero4 = new PasajeroPremium("Miguel", "Borja", pasaporteM4, 20);
        public static PasajeroPremium pasajero5 = new PasajeroPremium("Alejo", "Ferrari", pasaporteM5, 23);
        public static PasajeroPremium pasajero6 = new PasajeroPremium("Martin", "Demichellis", pasaporteM6, 27);
        public static PasajeroPremium pasajero7 = new PasajeroPremium("Tony", "Hack", pasaporteM7, 35);
        public static PasajeroPremium pasajero8 = new PasajeroPremium("Octavio", "Fernandez", pasaporteM8, 48);
        public static PasajeroPremium pasajero9 = new PasajeroPremium("Maximiliano", "Ferreira", pasaporteM9, 24);
        public static PasajeroPremium pasajero19 = new PasajeroPremium("Facundo", "Buen Dia", pasaporteM10, 47);



        //VIAJES DISPONIBLEs
        public static ViajeExtraRegional viaje1 = new ViajeExtraRegional(crucero1,"BOO61",new DateTime(2022, 07, 12),EDestinos.Venecia);
        public static ViajeExtraRegional viaje2 = new ViajeExtraRegional(crucero2,"YAA61",new DateTime(2022, 08, 11),EDestinos.Atenas);
        public static ViajeExtraRegional viaje3 = new ViajeExtraRegional(crucero3,"CAA61",new DateTime(2022, 11, 2),EDestinos.Bangkok);
        public static ViajeExtraRegional viaje4 = new ViajeExtraRegional(crucero4,"SIXUA",new DateTime(2022, 02, 9),EDestinos.Miami);
        public static ViajeExtraRegional viaje5 = new ViajeExtraRegional(crucero5, "NINE51", new DateTime(2023, 12, 2),EDestinos.Acapulco);
        


        //PASAJES VENDIDOS
        public static Pasaje pasaje1 = new Pasaje(viaje1,pasajero1,crucero1);
        public static Pasaje pasaje2 = new Pasaje(viaje2,pasajero2,crucero1);
        public static Pasaje pasaje3 = new Pasaje(viaje3,pasajero3,crucero1);
        public static Pasaje pasaje4 = new Pasaje(viaje4,pasajero4,crucero1);
        public static Pasaje pasaje5 = new Pasaje(viaje5,pasajero5,crucero1);


        //USUARIOS
        public static Usuario usuario1 = new Usuario("TomasElCreador", "booyaca619", true);
        public static Usuario usuario2 = new Usuario("Karlita", "carlita15", true);
        public static Usuario usuario3 = new Usuario("Billie", "1234", true);

        //VENTAS
        public static Venta venta1 = new Venta(1,usuario1, pasaje1);
        public static Venta venta2 = new Venta(2,usuario2, pasaje2);
        public static Venta venta3 = new Venta(3,usuario3, pasaje3);
       
        //public static List<Crucero> FlotaCruceros()
        //{
        //    flotaCruceros = new List<Crucero>();
        //    flotaCruceros.Add(crucero1);
        //    flotaCruceros.Add(crucero2);
        //    flotaCruceros.Add(crucero3);
        //    flotaCruceros.Add(crucero4);
        //    flotaCruceros.Add(crucero5);
        //    flotaCruceros.Add(crucero6);
        //    flotaCruceros.Add(crucero7);
        //    return flotaCruceros;
        //}

        public static void FlotaCruceros()
        {
            flotaCruceros = new List<Crucero>();
            flotaCruceros.Add(crucero1);
            flotaCruceros.Add(crucero2);
            flotaCruceros.Add(crucero3);
            flotaCruceros.Add(crucero4);
            flotaCruceros.Add(crucero5);
            flotaCruceros.Add(crucero6);
            flotaCruceros.Add(crucero7);
        }

        public static List<Pasajero> Pasajeros()
        {
            List<Pasajero> auxPasajeros = new List<Pasajero>();
            auxPasajeros.Add(pasajero1);
            auxPasajeros.Add(pasajero2);
            auxPasajeros.Add(pasajero3);
            auxPasajeros.Add(pasajero4);
            auxPasajeros.Add(pasajero5);
            auxPasajeros.Add(pasajero6);
            auxPasajeros.Add(pasajero7);
            auxPasajeros.Add(pasajero8);
            auxPasajeros.Add(pasajero9);
            auxPasajeros.Add(pasajero19);
            return auxPasajeros;
        }

        

        public static void LlenarCrucero(Crucero crucero)
        {
            crucero.Pasajeros.Add(pasajero1);
            crucero.Pasajeros.Add(pasajero2);
            crucero.Pasajeros.Add(pasajero3);
            crucero.Pasajeros.Add(pasajero4);
            crucero.Pasajeros.Add(pasajero5);
            crucero.Pasajeros.Add(pasajero6);
            crucero.Pasajeros.Add(pasajero7);
            crucero.Pasajeros.Add(pasajero8);
            crucero.Pasajeros.Add(pasajero9);
            crucero.Pasajeros.Add(pasajero19);
        }

        public static void LlenarCrucero(List<Crucero> cruceros)
        {
            for (int i = 0; i < cruceros.Count; i++)
            {
                cruceros[i].Pasajeros.Add(pasajero1);
                cruceros[i].Pasajeros.Add(pasajero2);
                cruceros[i].Pasajeros.Add(pasajero3);
                cruceros[i].Pasajeros.Add(pasajero4);
            }
        }

       
        public static List<Viaje> ObtenerViajesDisponibles()
        {
            
            return viajesDisponibles;

        }

        public static void LlenarListaViajes()
        {
            viajesDisponibles.Add(viaje1);
            viajesDisponibles.Add(viaje2);
            viajesDisponibles.Add(viaje3);
            viajesDisponibles.Add(viaje4);
            viajesDisponibles.Add(viaje5);
        }


        public static void HardcodearVentas(List<Venta> ventas)
        {
            
            ventas.Add(venta1);
            ventas.Add(venta2);
            ventas.Add(venta3);
            
        }


        public static void HardcodearVentas()
        {
            ventas.Add(venta1);
            ventas.Add(venta2);
            ventas.Add(venta3);
        }

        public static List<Viaje> HardCodearViaes()
        {
            List<Viaje> viajes = new List<Viaje>();
            viajes.Add(viaje1);
            viajes.Add(viaje2);
            viajes.Add(viaje3);
            viajes.Add(viaje4);
            viajes.Add(viaje5);
            return viajes;
        }

        public static Viaje BuscarViaje(string codigoViaje)
        {
            foreach (Viaje item in viajesDisponibles)
            {
                if (codigoViaje == item.CodigoViaje)
                {
                    return item;
                }
            }
            return null;
        }

        public static Crucero BuscarCrucero(string matricula)
        {
            foreach (Crucero item in flotaCruceros)
            {
                if (matricula == item.Matricula)
                {
                    return item;
                }
            }
            return null;
        }

       

        //METODOS
        public static List<Usuario> HardcodearUsuarios()
        {
           // List<Usuario> usuarios = new List<Usuario>();
            //ADMINS
            usuariosHardcodeados.Add(usuario1);
            usuariosHardcodeados.Add(usuario2);
            usuariosHardcodeados.Add(usuario3);
            return usuariosHardcodeados;
        }






    }
}
