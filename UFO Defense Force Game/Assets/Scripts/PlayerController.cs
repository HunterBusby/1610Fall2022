using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;

    public float speed;

    public float xRange;

    public Transform blaster;
    
    public GameObject laserBolt;

    public GameManager gameManager;

    public AudioClip laserSound;

    private AudioSource playerAudio;
    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        playerAudio = GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update()
    {
        //set horizontalInput to receive values from keyboard  
        horizontalInput = Input.GetAxis("Horizontal");
        
        // Moves Player left and Right
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        // Keep Player within bounds.
        //Left side wall 

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        //Right side wall
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        // if space bar is pressed fire laser bolt

        if (Input.GetKeyDown(KeyCode.Space) && gameManager.isGameOver == false)
        {
            //create laser bolt at blaster transform position maintaining the objects rotation
            Instantiate(laserBolt, blaster.transform.position, laserBolt.transform.rotation);
            playerAudio.PlayOneShot(laserSound);
        }
    }
    //delete any object with a trigger that hits the player

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
