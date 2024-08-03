using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInitial : MonoBehaviour
{
    GameSettings gameSettings;

    void Start()
    {
        int pairNumber = PlayerPrefs.GetInt("SelectedPair", 0);
        string categoryString = PlayerPrefs.GetString("SelectedCategory", "none");

        setupGame(pairNumber, categoryString);
    }

    void setupGame(int pairNumber, string categoryString)
    {
        if (pairNumber == 0 || categoryString == "none")
        {

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
