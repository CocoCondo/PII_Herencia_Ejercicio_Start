using System;
using System.Collections;

namespace PII_Herencia;

public class Print : IObserver
{
    public void Update(ISubject subject, User user)
    {
        PrintWelcome((user as User));
    }
    public void PrintWelcome(User user)
    {
        Console.WriteLine($"TWITTER: ** :-) **");
        Console.WriteLine($"TWITTER: Please welcome {user.GetType().Name} {user.Name} (ID: {user.UserID}) who has just registered!");
    }
}