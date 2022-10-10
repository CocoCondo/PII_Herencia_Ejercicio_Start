using System;
using System.Collections;
using System.Collections.Generic;

namespace Herencia;

public sealed class UserManager : ISubject
{
    public List<User> userList = new List<User>();
    private List<IObserver> _Observers = new List<IObserver>(); //Me creo una lista para utilizar el observer con la publicación de twitter

    public void Attach(IObserver observer)  //Para agregar observers
    {
        this._Observers.Add(observer);
        Console.WriteLine($"CONSOLE: Observer {observer} attached");
    }
    public void Dettach(IObserver observer)
    {
        this._Observers.Remove(observer);
        Console.WriteLine($"CONSOLE: Observer {observer} dettached");
    }

    public void Notify(User user) //Para notificar cuando se agrega un usuario nuevo a la lista de users
    {
        //Console.WriteLine($"CONSOLE: Notifying observers..."); //Para probar
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
            bool[] FaceCheckResult = CheckFace.Check(user);
            if((user is Passenger && FaceCheckResult[0]) || (user is Driver && FaceCheckResult[1]))
            {
                this.userList.Add(user);
                Console.WriteLine($"CONSOLE: {user.Name} Successfully registered!");
                //this.Notify(user); //Notifica a los observers
            }
            else if((FaceCheckResult[1] == false) && FaceCheckResult[0] == true)
            {
                Console.WriteLine($"ERROR: Our system cannot recognise a smile on {user.Name}'s picture");
            }
            else
            {
                Console.WriteLine($"ERROR: Our system cannot recognise a face on {user.Name}'s picture. Please provide another picture.");
            }
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
    private UserManager() //Un constructor privado porque el usermanager es Singleton
    {

    }
    private static UserManager _instance;
    public static UserManager GetInstance() //En vez de constructor, uso un método GetInstance
    {
        if (_instance == null)
        {
            _instance = new UserManager();
        }
        return _instance;
    }

    public override string ToString()
    {
        var result = new System.Text.StringBuilder();
        result.Append("CONSOLE: Registered Users: \n");
        foreach(User user in userList)
        {
            result.Append(user.ToString()+"\n");
        }
        return result.ToString();
    }
}