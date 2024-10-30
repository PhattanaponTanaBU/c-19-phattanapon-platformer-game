using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IShootable
{
    //Attributes
    GameObject Bullet { get; set; }
    GameObject BulletSpawnPoint { get; set; }
    float BulletSpawnTime { get; set; } //Reload Time
    float BulletTimer { get; set; }

    //Method
    void Shoot();
}
