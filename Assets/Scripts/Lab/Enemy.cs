using System.Collections;
using System.Collections.Generic;
using UnityEditor.Overlays;
using UnityEngine;

public abstract class Enemy : Character
{
    //Attributes
    private int damageHit = 5;
    public int DamageHit {
        get { return damageHit; }
        set {  damageHit = value; }
    }

    //Method
    public abstract void Behavior();

    private void Start()
    {
        DamageHit = 5;
    }
}
