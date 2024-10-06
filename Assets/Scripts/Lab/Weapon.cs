using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    //Attributes
    [SerializeField] private int damage;
    public int Damage
    {
        get
        {
            return damage;
        }
        set
        {
            damage = Math.Max(value, 0);
        }
    }

    protected string owner;

    //Method
    public abstract void OnHitWith(Character character);
    public abstract void Move();

    public int GetShootDirection()
    {
        return 1;
    }

    private void Start()
    {
        Move();
    }
}
