using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootSystem : ShootingSystem
{
    /*private void Shoot()
    {
        /*if (shootType == false)
        {
            for (int i = 1; i < 3; i++)
            {
                var shot = Instantiate(projectile, shotPoint[i].position, shotPoint[i].rotation);
                shot.GetComponent<Rigidbody2D>().AddForce(shotPoint[i].up * fireForce);
            }
            var telShoot = Mathf.Atan2(meteorite.y - projectile.y, meteorite.x - projectile.x);
        } 
    }*/

    void Start()
    {
    }
    public override void Shoot()
    {
        /*var shoot = Instantiate(projectile, shotPoint.position, shotPoint.rotation);
        shoot.GetComponent<Rigidbody2D>().AddForce(shotPoint.transform.up * fireForce);*/

        GameObject shot = PoolingManager.Instance.GetPooledObject("shots");
        if (shot != null)
        {
            shot.transform.position = shotPoint.position;
            shot.transform.rotation = shotPoint.rotation;
            shot.SetActive(true);
            shot.GetComponent<Rigidbody2D>().AddForce(transform.up * shootingdata.fireForce);
        }
    }

    private void FixedUpdate()
    {
        Vector3 pos = transform.position;
        Vector3 normpos = Camera.main.WorldToViewportPoint(pos);
        if (normpos.x < 0 || normpos.y > 1 || normpos.x > 1 || normpos.y < 0)
        {
            gameObject.SetActive(false);
        }
    }
}
