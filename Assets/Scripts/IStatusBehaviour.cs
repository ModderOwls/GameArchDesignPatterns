using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IStatusBehaviour
{
    public float HPEffect() 
    {
        return 0;
    }

    public int StrengthEffect()
    {
        return 0;
    }

    public int DefenseEffect()
    {
        return 0;
    }
}
