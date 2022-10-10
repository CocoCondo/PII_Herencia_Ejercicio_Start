using System;
using System.Collections;
using System.Collections.Generic;

namespace PII_Herencia;

public abstract class User
{
    protected string Forename;
    protected string Surname;
    protected int Id;
    protected double Score = 0; //Hasta acá los atributos básicos
    public static int GlobalUserID; //Un número estático que va aumentando cada vez que se instancia User (va a servir para los IDs de cada user)
    public int UserID {get;} //El UserID propio de cada user, me puede servir para localizar users sin tener que poner nombre, apellido, etc etc
   
    protected User(string forename, string surname, int id)
    {
        this.Forename = forename;
        this.Surname = surname;
        this.Id = id;
        this.UserID = GlobalUserID;
        GlobalUserID++;
    }

    public string Name
    {
        get
        {
            return this.Forename;
        }
    }
}