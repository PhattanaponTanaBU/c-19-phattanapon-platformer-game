using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IShootable
{
    //Attributes
    GameObject Bullet { get; set; }
    Transform BulletSpawnPoint { get; set; }
    float BulletSpawnTime { get; set; } //Reload Time
    float BulletTimer { get; set; }

    //Method
    void Shoot();
}
