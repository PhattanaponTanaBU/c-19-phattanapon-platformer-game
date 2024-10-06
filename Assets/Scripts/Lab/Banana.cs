using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : Weapon
{
    //Attributes
    [SerializeField] private float speed;

    //Method
    public override void Move()
    {
        Debug.Log($"Banana Is Moving With Constant Speed Of: {speed}");
    }

    public override void OnHitWith(Character character)
    {
        Debug.Log($"Banana Is Hitting With Something");
    }
}
