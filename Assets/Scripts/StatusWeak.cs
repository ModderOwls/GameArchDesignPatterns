using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusWeak : StatusEffect
{
    public StatusWeak(IStatusBehaviour behaviour)
    {
        this.behaviour = behaviour;
    }

    
    public override int StrengthEffect()
    {
        return behaviour.StrengthEffect() - 5;
    }
}
