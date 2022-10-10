using System;
using System.Collections;

namespace PII_Herencia;

public class Driver : User
{
    public string CarModel;
    public string Bio;
    public Driver(string forename, string surname, int id, string bio, string carmodel) : base(forename, surname, id)
    {
        this.CarModel = carmodel;
        this.Bio = bio;
    }
}