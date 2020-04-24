using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    bool hasEaten = false;
    GameManager gameManager;
    void OnTriggerEnter(Collider other)
    {
        GameObject.Find("Game Manager").GetComponent<GameManager>().animalsFed++;

        if(!hasEaten) {
            gameObject.transform.Rotate(new Vector3(gameObject.transform.rotation.x, gameObject.transform.rotation.y + 180, gameObject.transform.rotation.z));
            hasEaten = true;
            GameObject.Find("Player").GetComponent<PlayerController>().munitions++;
        }

        other.gameObject.SetActive(false);
    }

}
