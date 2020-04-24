using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    [HideInInspector] public float elapsedTime = 0;

    void Update()
    {
        elapsedTime += Time.deltaTime;
    }
}
