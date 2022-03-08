using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using GoogleMobileAds;

public class BannerReklam : MonoBehaviour
{
    private BannerView banner;
    void Start()
    {
        banner = new BannerView("ca-app-pub-6760811376462562/9267220005",AdSize.Banner,AdPosition.Bottom);

        AdRequest reklamistegi=new AdRequest.Builder().Build();
        banner.LoadAd(reklamistegi);
        banner.Show();
    }

}
