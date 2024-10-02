using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//16607065563 พัทธนพล ธนวิบูลย์ชัย No.19 Sec_229C

public abstract class Character : MonoBehaviour
{
    //Attributes
    [SerializeField] private int health;
    public int Health {
        get { return health; }
        set { health = Math.Max(value, 0); } 
    }

    public Animator anim;
    public Rigidbody2D rb;

    //Method
    public bool IsDead()
    {
        return Health <= 0;
    }
    public void TakeDamage(int damage)
    {
        Health -= damage;
    }
}
