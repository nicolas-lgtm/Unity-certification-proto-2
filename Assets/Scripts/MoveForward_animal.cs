using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward_animal : MonoBehaviour
{
    public float speed;
    private float speedRelatedToTime = 0f;
    private TimeManager timeManagerScript;

    private void Start()
    {
        timeManagerScript = GameObject.Find("Spawn Manager").GetComponent<TimeManager>();
    }

    // Update is called once per frame
    void Update()
    {
        speedRelatedToTime = 1 + (timeManagerScript.elapsedTime) / 40;
        transform.Translate(Vector3.forward * Time.deltaTime * speed * speedRelatedToTime);
    }
}
