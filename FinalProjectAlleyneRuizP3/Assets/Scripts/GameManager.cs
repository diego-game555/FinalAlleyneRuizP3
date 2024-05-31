using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int health;
    public TextMeshProUGUI scoreText;

    private int score;
   
    // Start is called before the first frame update
    void Start()
    {
        health = 100;
        Updatehealth(0);

        score = 0;
        UpdateScore(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Updatehealth(int healthToAdd)
    {
        health += healthToAdd;
        
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score:" + score;
    }
}
