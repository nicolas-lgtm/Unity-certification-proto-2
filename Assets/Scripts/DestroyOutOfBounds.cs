using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;
    GameManager gameManager;
    // Update is called once per frame
    private void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }
    void Update()
    {
        if (transform.position.z > topBound)
        {
            // Instead of destroying the projectile when it leaves the screen
            //Destroy(gameObject);

            // Just deactivate it
            gameObject.SetActive(false);

        }
        else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
            GameObject.Find("Game Manager").GetComponent<GameManager>().gameIsActive = false;
        }
    }
}
