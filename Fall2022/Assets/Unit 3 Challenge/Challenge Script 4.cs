using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChallengeScript4 : MonoBehaviour
{
    public GameObject[] enemies;

    void Start ()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        
        for(int i = 0; i < enemies.Length; i++)
        {
            Debug.Log("There are  "+i+" enemies in this dungeon "+enemies[i].name);
        }
    }
}
