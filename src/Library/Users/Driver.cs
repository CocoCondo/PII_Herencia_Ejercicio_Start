using System;
using System.Collections;

namespace Herencia;

public class Driver : User
{
    public string CarModel;
    public string Bio;
    public Driver(string forename, string surname, int id, string profilepicture, string bio, string carmodel) : base(forename, surname, id, profilepicture)
    {
        this.CarModel = carmodel;
        this.Bio = bio;
    }
}