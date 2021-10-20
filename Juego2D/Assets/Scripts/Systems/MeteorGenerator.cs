using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorGenerator : MonoBehaviour
{
    [SerializeField]
    public GameObject[] meteor;
    
    [SerializeField]
    public Transform[] positions;

    void Start()
    {
        StartCoroutine(GenerateMeteor());
    }

    IEnumerator GenerateMeteor()
    {
        int a = Random.Range(0, 4);
        int t = Random.Range(0, 2);
        Instantiate(meteor[t], positions[a].position, Quaternion.identity);
        yield return new WaitForSeconds(1.0f);
        StartCoroutine(GenerateMeteor());
    }
}
