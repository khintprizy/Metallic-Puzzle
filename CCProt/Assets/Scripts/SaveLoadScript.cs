using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveLoadScript : MonoBehaviour
{
    public void StartGame()
    {
        if (PlayerPrefs.GetInt("SavedScene") > -1)
        {
            SceneManager.LoadScene(PlayerPrefs.GetInt("SavedScene"));
        }
        else
        {
            SceneManager.LoadScene("Level1");
        }
    }

    public void NewGame()
    {
        SceneManager.LoadScene("Level1");
    }
}
