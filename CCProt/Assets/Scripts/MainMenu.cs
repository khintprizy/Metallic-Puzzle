using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject newGameButton;
    public GameObject continueButton;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("Level2") == 100)
        {
            continueButton.SetActive(true);
            newGameButton.SetActive(false);
        }
        else
        {
            continueButton.SetActive(false);
            newGameButton.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
