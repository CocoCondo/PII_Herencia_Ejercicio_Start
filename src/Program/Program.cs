using System;
using System.Collections;
using System.Collections.Generic;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            GetWelcomeText printer = new GetWelcomeText();
            UserManager usermanager = UserManager.GetInstance();
            usermanager.Attach(printer);
            User pasajero1 = new Passenger("Leo", "Conde", 123, "..\\ProfilePics\\happy-smiling-man-looking-away-confident-young-big-smile-handsome-guy-window-thinking-future-closeup-face-152000693.jpg");
            User pasajero2 = new Passenger("José", "Onzuma", 323, "..\\ProfilePics\\depositphotos_75196567-stock-photo-handsome-man-smiling.jpg");
            User pasajero3 = new Passenger("Mauricio", "Josue", 645, "..\\ProfilePics\\29c0ded349939ac65db5020f1e90b0ed.jpg");
            User conductor1 = new Driver("Santi", "Almagro", 5533, "..\\ProfilePics\\mark-zuckerberg_gettyimages-512304736jpg.jpg", "Apuesto chofer para las chichis de la UCU", "Fiat 600");
            User conductorPool1 = new PoolDriver("Sofi", "Hernández", 9958, "..\\ProfilePics\\smiling-woman-on-winter-street.jpg", "Chofer de Pool nueva", "Suzuki Celerio", 4);
            usermanager.AddUser(pasajero1);
            usermanager.AddUser(pasajero2);
            usermanager.AddUser(pasajero3);
            usermanager.AddUser(conductor1);
            usermanager.AddUser(conductorPool1);
            Console.WriteLine(usermanager.ToString()); //Me imprime los usuarios que están en la lista de UserManager. Estos son los que se verificó la foto de perfil

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
