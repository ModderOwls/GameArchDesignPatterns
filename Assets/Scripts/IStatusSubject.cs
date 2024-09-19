using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IStatusSubject
{
    public delegate void StatusSubject();
    public event StatusSubject Observers;

    void UpdateObservers()
    {
    }

    public void AddObserver(IStatusObserver observer)
    {
        Observers += observer.Update;
    }

    public void RemoveObserver(IStatusObserver observer)
    {
        Observers -= observer.Update;
    }
}
