using System;
using System.Collections;

namespace PII_Herencia;

public interface IObserver
{
    void Update(ISubject subject, User user);
}