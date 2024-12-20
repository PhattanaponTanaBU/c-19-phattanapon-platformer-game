using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Croccodile : Enemy, IShootable
{
    //Attributes
    [SerializeField] private float attackRange;
    [SerializeField] public Player player;

    [field: SerializeField] public GameObject Bullet { get; set; }
    [field: SerializeField] public Transform BulletSpawnPoint { get; set; }
    [field: SerializeField] public float BulletSpawnTime { get; set; } //Reload Time
    public float BulletTimer { get; set; }

    //Method
    private void Update()
    {
        BulletTimer -= Time.deltaTime;
        Behavior();
    }

    public override void Behavior()
    {
        //throw new System.NotImplementedException();
        //Debug.Log("Croc run Brhavior");

        Vector3 direction = player.transform.position - transform.position;
        float distance = direction.magnitude;

        if (distance < attackRange)
        {
            Shoot();
        }
    }
    public void Shoot()
    {
        if (BulletTimer <= 0)
        {
            anim.SetTrigger("Shoot");
            BulletTimer = BulletSpawnTime;
            GameObject projectile = Instantiate(Bullet, BulletSpawnPoint.position, Quaternion.identity);
            projectile.gameObject.GetComponent<Weapon>().Shooter = this;

        }
    }
}
