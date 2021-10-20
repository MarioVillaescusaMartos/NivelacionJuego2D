using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    [SerializeField]
    private GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var angulo = Mathf.Atan2(target.transform.position.y + transform.position.y, target.transform.position.x - transform.position.x) * Mathf.Rad2Deg;
    }
}
