using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileSystem : ShootingSystem
{
    void Start()
    {

    }
    public override void Shoot()
    {

        GameObject miss = PoolingManager.Instance.GetPooledObject("shots");
        if (miss != null)
        {
            miss.transform.position = shotPoint.position;
            miss.transform.rotation = shotPoint.rotation;
            miss.SetActive(true);
            //miss.GetComponent<Missile>().SetTarget(GameObject.Find("Meteor").transform);
        }
        
    }
}
