using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

//

public class Player : Character, IShootable
{
    //Attributes
    [field: SerializeField] public GameObject Bullet { get; set; }
    [field: SerializeField] public Transform BulletSpawnPoint { get; set; }
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
        GameObject projectile = Instantiate(Bullet, BulletSpawnPoint.transform.position, Quaternion.identity);
        projectile.gameObject.GetComponent<Weapon>().Shooter = this;

    }

    public void OnHitWith(Enemy enemy)
    {
        TakeDamage(enemy.DamageHit);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Enemy enemy = collision.gameObject.GetComponent<Enemy>();
        if (enemy != null)
        {
            OnHitWith(enemy);
        }
    }

}
