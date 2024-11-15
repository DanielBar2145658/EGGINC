using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Subjects : MonoBehaviour
{
    private readonly ArrayList observers = new ArrayList();

    protected void Attach(Observer o) 
    {
        observers.Add(o);
    }

    protected void Detach(Observer o) 
    {
        observers.Remove(o);
    }

    protected void Notify() 
    {
        foreach (Observer observer in observers) 
        {
            observer.Notify(this);
        
        }
    }
}
