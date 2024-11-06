using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : Weapon
{
    //Attributes
    [SerializeField] private Rigidbody2D rb2d;
    [SerializeField] private Vector2 force;

    private void Start()
    {
        force = new Vector2(GetShootDirection() * 100, 100);
        Move();
    }

    //Method
    public override void Move()
    {
        rb2d.AddForce(force);
    }

    public override void OnHitWith(Character character)
    {
        if (character is Player)
        {
            character.TakeDamage(Damage);
        }


    }
}
