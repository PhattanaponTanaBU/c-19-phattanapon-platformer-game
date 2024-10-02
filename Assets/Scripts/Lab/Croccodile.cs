using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Croccodile : Enemy
{
    //Attributes
    [SerializeField] private float attackRange;
    [SerializeField] public Player player;

    [SerializeField] private GameObject bullet;
    [SerializeField] private GameObject bulletSpawnPoint;
    [SerializeField] private float bulletSpawnTime;
    private float bulletTimer;

    //Method
    private void Update()
    {
        bulletTimer -= Time.deltaTime;
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
        if (bulletTimer <= 0)
        {
            bulletTimer = bulletSpawnTime;
            Instantiate(bullet, bulletSpawnPoint.transform.position, Quaternion.identity);
        }
    }
}
