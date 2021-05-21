using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levels : MonoBehaviour
{
    public GameObject[] levelLocks;     //kilit gorseli olabilir

    private void Start()
    {
        for (int a = 1; a < levelLocks.Length; a++)
        {
            if (PlayerPrefs.GetInt("Level" + (a).ToString()) == 100)
            {
                levelLocks[a-1].SetActive(false);
            }
            else
            {
                levelLocks[a-1].SetActive(true);
            }
        }
    }

    public void SelectLevel(int number)
    {

        if (PlayerPrefs.GetInt("Level" + number.ToString()) == 100)
        {
            Debug.Log("Level" + number.ToString() + "yukleniyor");
            SceneManager.LoadScene("Level" + number.ToString());
        }
        else
        {
            Debug.Log("level yuklenemiyor");
        }
    }

    public void LevelOne()
    {
        SceneManager.LoadScene("Level1");
    }
}
