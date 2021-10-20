using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ParticleSystem : MonoBehaviour
{
    [SerializeField]
    private Transform burnPoint;

    [SerializeField]
    private float burnLife;

    [SerializeField]
    private GameObject spaceshipBurn;

    [SerializeField]
    private Transform explosionPoint;

    [SerializeField]
    private GameObject explosion;

    private InputSystemKeyboard inputSystem;

    void Awake()
    {
        inputSystem = GetComponent<InputSystemKeyboard>();
    }

    private void OnEnable()
    {
        GetComponent<DieSystem>().OnDie += Explode;
    }

    private void OnDisable()
    {
        GetComponent<DieSystem>().OnDie -= Explode;
    }

    void Update()
    {
        if (inputSystem.ver == 1)
        {
            var burn = Instantiate(spaceshipBurn, burnPoint.position, burnPoint.rotation);
            Destroy(burn, burnLife);
        }
    }

    private void Explode()
    {
        var explode = Instantiate(explosion, explosionPoint.position, burnPoint.rotation);
        Destroy(explode, 5.0f);
    }
}