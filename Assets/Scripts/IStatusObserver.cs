using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IStatusObserver
{
    public IStatusSubject subject { get; set; }

    public void Update()
    {

    }
}
