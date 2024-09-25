using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ant : Enemy
{
    //Attributes
    private Vector2 velocity;
    private Transform[] movePoints;

    //Method
    public override void Behavior()
    {
        Debug.Log("Ant run Brhavior");
    }
}
