using System;
using System.Collections;

namespace PII_Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Print printer = new Print();
            UserManager usermanager = UserManager.GetInstance();
            usermanager.Attach(printer);
            User pasajero1 = new Passenger("Leo", "Conde", 123);
            User pasajero2 = new Passenger("Pepe", "Onzuma", 323);
            User pasajero3 = new Passenger("Mauricio", "Josue", 645);
            usermanager.AddUser(pasajero1);
            usermanager.AddUser(pasajero2);
            usermanager.AddUser(pasajero3);
            Console.WriteLine(pasajero1.Name+pasajero1.UserID);
            Console.WriteLine(pasajero2.Name+pasajero2.UserID+pasajero1.GetType().Name);
            Console.WriteLine(User.GlobalUserID);
            /*
            En éste método deberas mostrar un ejemplo de funcionamiento de tu programa an pseudocódigo. A continuación te 
            planteamos un ejemplo de como hacerlo. Esto no significa que te limites a hacer solamente esto, debes pensar 
            en grande!

            Usuario pasajero1 = nuevo Pasajero()
            Usuario pasajero2 = nuevo Pasajero()
            Usuario pasajero3 = nuevo Pasajero()
            Usuario conductor1 = nuevo Conductor()
            Usuario conductorPool1 = nuevo ConductorPool(maxPasajeros = 3)
            UcuRideShare rideShare = nuevo UcuRideShare()
            
            rideShare.Add(conductor1)
            Se publica en Twitter un nuevo conductor!

            rideShare.Add(conductorPool1)
            Se publica en Twitter un nuevo conductor!
            
            rideShare.Add(pasajero1)
            Se publica en Twitter nuevo registro de pasajero!
            
            rideShare.Add(pasajero2)
            Se publica en Twitter nuevo registro de pasajero!

            rideShare.Add(pasajero3)
            Se publica en Twitter nuevo registro de pasajero!

            */
        }
    }
}
