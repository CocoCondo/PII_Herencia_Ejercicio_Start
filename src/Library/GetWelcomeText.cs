using System;
using System.Collections;

namespace Herencia;

public class GetWelcomeText : IObserver
{
    public void Update(ISubject subject, User user)
    {
        PrintWelcome((user as User));
    }
    public void PrintWelcome(User user)
    {
        string[] WelcomeMsg = new string[3];
        WelcomeMsg[0] = $"Please welcome {user.GetType().Name} {user.Name} (ID: {user.UserID}) who has just registered!";
        WelcomeMsg[1] = user.ProfilePicture;
        if (user is Driver || user is PoolDriver)
        {
            WelcomeMsg[2] = (user as Driver).Bio;
            WelcomeMsg[0] = WelcomeMsg[0]+"\nDriver Bio: "+WelcomeMsg[2];
        }
        var twitter = new TwitterImage();
        Console.WriteLine(twitter.PublishToTwitter(WelcomeMsg[0], @$"{WelcomeMsg[1]}")); //Si no se le pone bien la dirección de la foto, tira error
    }
}