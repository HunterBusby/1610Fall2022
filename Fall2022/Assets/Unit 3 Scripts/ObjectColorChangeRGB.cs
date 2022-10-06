using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectColorChangeRGB : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<Renderer> ().material.color = Color.red;
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            GetComponent<Renderer> ().material.color = Color.green;
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            GetComponent<Renderer> ().material.color = Color.blue;
        }
    }
}
