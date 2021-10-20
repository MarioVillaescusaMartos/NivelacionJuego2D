using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineSystem : ShootingSystem
{
    [SerializeField]
    private float rotationSpeed = 0.5f;

    void Start()
    {

    }
    public override void Shoot()
    {
        /*var mine = Instantiate(projectile, shotPoint.position, shotPoint.rotation);
        mine.GetComponent<Rigidbody2D>().AddForce(shotPoint.transform.up * fireForce);*/
        
    }
}