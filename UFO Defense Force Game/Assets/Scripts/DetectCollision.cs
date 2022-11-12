using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public AudioClip explosionSound;

    private AudioSource enemyAudio;
    
    public ScoreManager scoreManager; //store reference to store manager

    public int scoreToGive;

    
    
    

    private void Start()
    {
        enemyAudio = GetComponent<AudioSource>();
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); //Find ScoreManager gameobject and reference ScoreManager Script component

    }

    private void OnTriggerEnter(Collider other) //once the trigger has been entered record collision in the argument variable "other"
    {
        enemyAudio.PlayOneShot(explosionSound, 1.0f);
        scoreManager.IncreaseScore(scoreToGive); //increase the score
        Destroy(gameObject); //Destroy this game object
        Destroy(other.gameObject); //destroy the other game object it hits
    }
}
