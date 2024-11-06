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

    public IShootable Shooter;

    //Method
    /*public void Initialize(IShootable newShooter, int newdamage)
    {
        Damage = newdamage
        Shooter = newShooter;

    }*/

    public abstract void OnHitWith(Character character);
    public abstract void Move();

    public int GetShootDirection()
    {
        float shootDir = Shooter.BulletSpawnPoint.transform.position.x - Shooter.BulletSpawnPoint.parent.transform.position.x;
        if (shootDir < 0)
        { //Turn Left
            return -1;
        }
        return 1;//Right
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        OnHitWith(other.GetComponent<Character>());
        Destroy(this.gameObject, 5f);
    }

    private void Start()
    {
        Move();
    }
}
