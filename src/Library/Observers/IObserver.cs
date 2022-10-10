using System;
using System.Collections;

namespace Herencia;

public interface IObserver
{
    void Update(ISubject subject, User user);
}