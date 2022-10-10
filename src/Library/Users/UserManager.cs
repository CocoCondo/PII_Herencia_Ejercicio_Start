using System;
using System.Collections;
using System.Collections.Generic;

namespace PII_Herencia;

public sealed class UserManager : ISubject
{
    public List<User> userList = new List<User>();
    private List<IObserver> _Observers = new List<IObserver>(); //Me creo una lista para utilizar el observer con la publicación de twitter

    public void Attach(IObserver observer)
    {
        this._Observers.Add(observer);
        Console.WriteLine($"CONSOLE: Observer {observer} attached");
    }
    public void Dettach(IObserver observer)
    {
        this._Observers.Remove(observer);
        Console.WriteLine($"CONSOLE: Observer {observer} dettached");
    }

    public void Notify(User user)
    {
        Console.WriteLine($"CONSOLE: Notifying observers...");
        foreach(var observers in _Observers)
        {
            observers.Update(this, user);
        }
    }
    public void AddUser(User user)
    {
        if (userList.Contains(user))
        {
            Console.WriteLine($"ERROR: User {user} is already on the list");
        }
        else
        {
            this.userList.Add(user);
            this.Notify(user);
        }
    }
    public void RemoveUser(User user)
    {
        if (userList.Contains(user))
        {
            this.userList.Remove(user);
        }
        else
        {
            Console.WriteLine($"ERROR: User {user} is not on the list");
        }
    }
    private UserManager()
    {

    }
    private static UserManager _instance;
    public static UserManager GetInstance()
    {
        if (_instance == null)
        {
            _instance = new UserManager();
        }
        return _instance;
    }
}