using System;
using System.Collections;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            GetWelcomeText printer = new GetWelcomeText();
            UserManager usermanager = UserManager.GetInstance();
            usermanager.Attach(printer);
            User pasajero1 = new Passenger("Leo", "Conde", 123, "..\\ProfilePics\\256x256bb.jpg");
            User pasajero2 = new Passenger("José", "Onzuma", 323, "..\\ProfilePics\\2d035609483aad6a14b4b7a45223b32e.jpg");
            User pasajero3 = new Passenger("Mauricio", "Josue", 645, "..\\ProfilePics\\64ef980138c10eed414880785c501820.jpg");
            User conductor1 = new Driver("Santi", "Almagro", 5533, "..\\ProfilePics\\256x256bb.jpg", "Apuesto chofer para las nenas de la UCU", "Fiat 600");
            User conductorPool1 = new PoolDriver("Sofi", "Hernández", 9958, "..\\ProfilePics\\256x256bb.jpg", "Chofer de Pool nueva", "Suzuki Celerio", 4);
            Ride rideshare = new Ride();
            usermanager.AddUser(pasajero1);
            usermanager.AddUser(pasajero2);
            usermanager.AddUser(pasajero3);
            usermanager.AddUser(conductor1);
            usermanager.AddUser(conductorPool1);

            /*Console.WriteLine(pasajero1.Name+pasajero1.UserID);
            Console.WriteLine(pasajero2.Name+pasajero2.UserID+pasajero1.GetType().Name);
            Console.WriteLine(User.GlobalUserID);
            */

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
