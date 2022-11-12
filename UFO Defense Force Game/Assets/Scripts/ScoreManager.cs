using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Text Mesh Pro name space added to access the unity libraries for UI

public class ScoreManager : MonoBehaviour
{
    public int score; // keep out score value
    
    public TextMeshProUGUI scoreText; // visual text element to be modified

    public void IncreaseScore(int amount) // this method when called increases the score by a predetermined amount set in score variable
    {
        score += amount;
        UpdateScoreText();
    }

    public void DecreaseScore(int amount) // this method when called decreases the score by a predetermined amount set in score variable
    {
        score -= amount;
        UpdateScoreText();
    }
    
    public void UpdateScoreText()  // this method updates the score in the HUD UI Text
    {
        scoreText.text = "Score " + score;
    }
    
}
