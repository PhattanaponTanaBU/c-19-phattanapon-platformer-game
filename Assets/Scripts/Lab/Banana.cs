using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : Weapon
{
    //Attributes
    [SerializeField] private float speed;

    //Method
    private void FixedUpdate()
    {
        Move();
    }

    public override void Move()
    {
        float newX = transform.position.x + (speed * Time.fixedDeltaTime);
        float newY = transform.position.y;
        this.transform.position = new Vector2(newX, newY);

    }

    public override void OnHitWith(Character character)
    {
        if (character is Enemy)
        {
            character.TakeDamage(Damage);
        }
    }
}
