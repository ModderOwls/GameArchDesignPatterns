using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StatusEffect : IStatusBehaviour
{
    public IStatusBehaviour behaviour;

    public virtual float HPEffect()
    {
        return behaviour.HPEffect();
    }

    public virtual int StrengthEffect()
    {
        return behaviour.StrengthEffect();
    }

    public virtual int DefenseEffect()
    {
        return behaviour.DefenseEffect();
    }
}
