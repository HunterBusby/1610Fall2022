using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChallengeScript3 : MonoBehaviour
{
    void Start () 
    {

        Vector2 pos = transform.position;
        pos = new Vector2(6, 5, 9);
        

        Transform move = transform;
        move.position = new Vector2(9, 5, 6);
    }
}
