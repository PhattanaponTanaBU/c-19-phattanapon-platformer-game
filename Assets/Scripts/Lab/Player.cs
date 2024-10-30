using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//

public class Player : Character, IShootable
{
    //Attributes
    [field: SerializeField] public GameObject Bullet { get; set; }
    [field: SerializeField] public GameObject BulletSpawnPoint { get; set; }
    [field: SerializeField] public float BulletSpawnTime { get; set; } //Reload Time
    public float BulletTimer { get; set; }

    //Method
    private void Update()
    {
        BulletTimer -= Time.deltaTime;
        if (Input.GetButtonDown("Fire1") && BulletTimer <= 0)
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        BulletTimer = BulletSpawnTime;
        Instantiate(Bullet, BulletSpawnPoint.transform.position, Quaternion.identity);
    }

}
