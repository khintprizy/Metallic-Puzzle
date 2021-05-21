using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdsManager : MonoBehaviour
{
    string GooglePlay_ID = "4089925";
    //public bool testMode = true;

    private void Start()
    {
        Advertisement.Initialize(GooglePlay_ID);
    }

    public void ShowAd()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show();
        }
    }
}
