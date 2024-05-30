using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CastleWall"))
        {
            Destroy(gameObject);
            gameManager.Updatehealth(-5);
            Debug.Log("Castle has been hit, Castle health now at ");
        }
        else if (other.CompareTag("CastleEnter"))
        {
            Destroy(gameObject);
            Debug.Log("An animal entered the castle");
        }
    }
}
