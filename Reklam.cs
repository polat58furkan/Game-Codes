using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using GoogleMobileAds;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Reklam : MonoBehaviour
{
    private InterstitialAd interstitialAd;
    public GameObject ReklamButton;

    public string adUnitId = "ca-app-pub-***********************";

    private void Start()
    {
        this.RequestAndLoadInterstitialAd();
        MobileAds.Initialize(interstitialAd => { });
        
    }

    public void RequestAndLoadInterstitialAd()
    {

        if (this.interstitialAd != null)
        {
            this.interstitialAd.Destroy();
        }

        this.interstitialAd = new InterstitialAd(adUnitId);
        AdRequest request = new AdRequest.Builder().Build();
        this.interstitialAd.LoadAd(request);
        
    }

    public void ShowInterstitialAd()
    {
        if (this.interstitialAd.IsLoaded())
        {
            this.interstitialAd.Show();
        }
        StartCoroutine(bekleme());
        Destroy(ReklamButton,1.5f);
        
    }

    public void DestroyInterstitialAd()
    {
        if (this.interstitialAd != null)
        {
            this.interstitialAd.Destroy();
        }
    }

    IEnumerator bekleme()
    {
        yield return new WaitForSeconds(0.5f);
        RequestAndLoadInterstitialAd();
    }
}
