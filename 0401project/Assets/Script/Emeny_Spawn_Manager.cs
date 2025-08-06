using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emeny_Spawn_Manager : MonoBehaviour
{
    public GameObject Enemy_Prefab;
    private float Time;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Time = Time + 1.0f; 

        Vector3 spwan_pos = this.gameObject.transform.position;
        float x_random = Random.Range(-10.0f, 10.0f);
        
        if (Time % 30 == 0)
        {
            Instantiate(Enemy_Prefab, new Vector3(x_random, 1.0f, 10.0f), Quaternion.identity);
        }
    }
}
