using System;
using System.Collections;

namespace Herencia;

public interface ISubject
{
    void Attach(IObserver observer);
    void Dettach(IObserver observer);
    void Notify(User user);
}