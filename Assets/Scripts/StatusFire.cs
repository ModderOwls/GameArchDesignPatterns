using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusFire : StatusEffect, IStatusObserver
{
    float damage;

    public IStatusSubject subject { get; set; }

    public StatusFire(IStatusBehaviour behaviour, IStatusSubject subject)
    {
        this.behaviour = behaviour;

        this.subject = subject;
        subject.AddObserver(this);
    }

    public override float HPEffect()
    {
        //since hp doesn't return after an effect ends,
        //we reset the damage so it doesn't compound from previous HPEffect.
        float damageToDo = damage;
        damage = 0;
        return behaviour.HPEffect() - damageToDo;
    }


    public void Update()
    {
        damage += Time.fixedDeltaTime;
    }
}
