using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class HealthSystem : MonoBehaviour
{
    [SerializeField]
    private int health;

    [SerializeField]
    private int maxHealth = 10;

    private void OnEnable()
    {
        GetComponent<CollisionSystem>().OnColl += RestHealth;
    }

    private void OnDisable()
    {
        GetComponent<CollisionSystem>().OnColl -= RestHealth;
    }

    public event Action OnHealthZero = delegate { };
    private void RestHealth()
    {
        health--;

        if (health <= 0)
        {
            OnHealthZero();
        }
    }
}