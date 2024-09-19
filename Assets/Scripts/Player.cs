using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IStatusBehaviour, IStatusSubject
{
    public float maxHP;
    float hp = 50;
    public float HPEffect()
    {
        return hp;
    }

    public int baseStrength;
    int strength;
    public int StrengthEffect()
    {
        return strength;
    }

    public int baseDefense;
    int defense;
    public int DefenseEffect()
    {
        return defense;
    }

    public List<StatusEffect> effects = new List<StatusEffect>();

    public event IStatusSubject.StatusSubject Observers;

    void Start()
    {
        AddStatusEffect(new StatusWeak(this));
        AddStatusEffect(new StatusFire(this, this));
    }

    void FixedUpdate()
    {
        //as the observers are logic-related put this in FixedUpdate.
        UpdateObservers();
    }

    void Update()
    {
        //as this is input put this in Update instead.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            UpdateEffects();
        }
    }

    void AddStatusEffect(StatusEffect effect)
    {
        effects.Add(effect);

        UpdateEffects();
    }

    //only recheck status effects when necessary.
    void UpdateEffects()
    {
        //reset to base stats.
        strength = baseStrength;
        defense = baseDefense;

        //cycle through all status effects.
        for (int i = 0; i < effects.Count; ++i)
        {
            hp = effects[i].HPEffect();
            strength = effects[i].StrengthEffect();
            defense = effects[i].DefenseEffect();
        }

        if (hp > maxHP)
        {
            hp = maxHP;
        }

        Debug.Log(hp + " : " + strength + " : " + defense);
    }

    void UpdateObservers()
    {
        Observers?.Invoke();
    }
}
