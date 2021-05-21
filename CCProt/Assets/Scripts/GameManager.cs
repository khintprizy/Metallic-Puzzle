using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public bool isRedReady;
    public bool isGreenReady;
    public bool isBlueReady;
    public bool isYellowReady;
    public bool isPurpleReady;
    public bool isOrangeReady;
    public bool isWhiteReady;
    public bool isPetrolReady;

    public string loadSceneString;
    public Canvas nextLevelCanvas;

    void Start()
    {
        isRedReady = true;
        isGreenReady = true;
        isBlueReady = true;
        isYellowReady = true;
        isPurpleReady = true;
        isOrangeReady = true;
        isWhiteReady = true;
        isPetrolReady = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isRedReady && isGreenReady && isBlueReady && isYellowReady && isPurpleReady && isOrangeReady && isWhiteReady && isPetrolReady)
        {
            //Debug.Log("GAMEOVERGAMEOVERGAMEOVERGAMEOVER");
            nextLevelCanvas.gameObject.SetActive(true);
        }
        if (!isRedReady || !isGreenReady || !isBlueReady || !isYellowReady || !isPurpleReady || !isOrangeReady || !isWhiteReady || !isPetrolReady)
        {
            nextLevelCanvas.gameObject.SetActive(false);
        }
    }
    public void LevelOver()
    {
        PlayerPrefs.SetInt("SavedScene", SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.LoadScene(loadSceneString);
    }

    public void ResetLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void CallLevels()
    {
        SceneManager.LoadScene("02LevelsMenu");
    }

    public void UnlockLevel(int number)
    {
        PlayerPrefs.SetInt("Level" + number.ToString(), 100);
        Debug.Log("Level" + number.ToString() + "unlocked");
    }
}
