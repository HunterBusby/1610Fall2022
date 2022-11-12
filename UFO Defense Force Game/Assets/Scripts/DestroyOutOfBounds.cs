using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public AudioClip gameOverSound;

    private AudioSource gameOverAudio;
    
    public float topBounds = 30.0f;

    public float lowerBounds = -10.0f;

    public GameManager gameManager;


    private void Start()
    {
        gameOverAudio = GetComponent<AudioSource>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBounds)
        {
            gameOverAudio.PlayOneShot(gameOverSound);
            Debug.Log("Game Over!");
            Destroy(gameObject);
            gameManager.isGameOver = true;
            

        }
    }
}
