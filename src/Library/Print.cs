using System;
using System.Collections;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http;
using System.Linq;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;

namespace Herencia;

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
        var twitter = new TwitterImage();
        Console.WriteLine(twitter.PublishToTwitter("text", @"PathToImage.png"));
    }
}

/*
var twitter = new TwitterImage();
Console.WriteLine(twitter.PublishToTwitter("text", @"PathToImage.png"));
*/