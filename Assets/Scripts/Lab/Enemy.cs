using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : Character
{
    //Attributes
    private int damageHit;
    public int DamageHit {
        get { return damageHit; }
        set {  damageHit = value; }
    }

    //Method
    public abstract void Behavior();

    private void Start()
    {
        Behavior();
    }
}
