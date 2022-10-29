using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class Spawn : MonoBehaviour
{
    public float rate;
    
    public Transform spawn;

    public GameObject pickup;

// Update is called once per frame
    void Update()
    {
        
        {
           
            Instantiate(pickup, spawn.transform.position, pickup.transform.rotation);
        }
    }
}
