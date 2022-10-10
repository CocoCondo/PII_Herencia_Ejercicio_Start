using System;
using System.Collections;

namespace Herencia;

public class PoolDriver : Driver
{
    public int MaxPassenger;
    public PoolDriver(string forename, string surname, int id, string profilepicture, string bio, string carmodel, int maxpassenger) : base(forename, surname, id, profilepicture, bio, carmodel)
    {
        this.MaxPassenger = maxpassenger;
    }
}