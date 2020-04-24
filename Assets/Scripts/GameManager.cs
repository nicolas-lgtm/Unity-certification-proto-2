using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [HideInInspector] public bool gameIsActive = true;
    [SerializeField] GameObject gameOverScreen;
    [SerializeField] TextMeshProUGUI animalsFedUI;
    [HideInInspector] public int animalsFed = 0;

    // Update is called once per frame
    void Update()
    {
        animalsFedUI.text = "Animals fed: " + animalsFed.ToString();
        if (!gameIsActive) gameOverScreen.gameObject.SetActive(true);
    }
}
