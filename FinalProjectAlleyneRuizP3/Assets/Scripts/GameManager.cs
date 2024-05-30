using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    public int health;
    // Start is called before the first frame update
    void Start()
    {
        health = 100;
        Updatehealth(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Updatehealth(int healthToAdd)
    {
        health += healthToAdd;
        
    }
}
