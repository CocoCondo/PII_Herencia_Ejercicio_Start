using System;
using System.Collections;

namespace PII_Herencia;

public class PoolDriver : Driver
{
    public int MaxPassenger;
    public PoolDriver(string forename, string surname, int id, string bio, string carmodel, int maxpassenger) : base(forename, surname, id, bio, carmodel)
    {
        this.MaxPassenger = maxpassenger;
    }
}