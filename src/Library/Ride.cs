using System;
using System.Collections;
using System.Collections.Generic;

namespace PII_Herencia;

public class Ride
{
    public List<User> currentRide = new List<User>();
    public void AddUser(User user)
    {
        if (currentRide.Contains(user))
        {
            Console.WriteLine($"ERROR: User {user} is already on the list");
        }
        else
        {
            this.currentRide.Add(user);
        }
    }
    public void RemoveUser(User user)
    {
        if (currentRide.Contains(user))
        {
            this.currentRide.Remove(user);
        }
        else
        {
            Console.WriteLine($"ERROR: User {user} is not on the list");
        }
    }
}