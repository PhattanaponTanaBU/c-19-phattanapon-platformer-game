using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : Weapon
{
    //Attributes
    [SerializeField] private Rigidbody2D rb2d;
    [SerializeField] private Vector2 force;

    //Method
    public override void Move()
    {
        Debug.Log($"Rock Is Moving With Rigid-body force: {force}");
    }

    public override void OnHitWith(Character character)
    {
        Debug.Log($"Rock Is Hitting With Something");
    }
}
