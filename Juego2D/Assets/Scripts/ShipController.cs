using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    public ShootingSystemData[] shootingData;
    public Transform[] shotPoints;
    private ShootingSystem launcher;

    void Awake()
    {
        InputSystemKeyboard sk;

        if (TryGetComponent<InputSystemKeyboard> (out sk))
        {
            sk.OnFire += Shot;
        }
    }

    void Update()
    {
        var input = Input.inputString;
        if (Input.GetKeyDown(KeyCode.B))
        {
            Destroy(gameObject.GetComponent<MissileSystem>());
            ShootSystem s = gameObject.AddComponent<ShootSystem>();
            s.shootingdata = shootingData[0];
            s.shotPoint = shotPoints[0];
            launcher = s;
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            if (GetComponent<MissileSystem>() == null)
            {
                Destroy(gameObject.GetComponent<ShootSystem>());
                MissileSystem m = gameObject.AddComponent<MissileSystem>();
                m.shootingdata = shootingData[1];
                m.shotPoint = shotPoints[0];
                launcher = m;
            }
        }
    }

    // Update is called once per frame
    void Shot()
    {
        launcher.Shoot();
    }
}