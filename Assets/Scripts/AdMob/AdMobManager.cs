using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class AdMobManager : MonoBehaviour
{
    public static AdMobManager Instance=new AdMobManager();
    public BannerView _AdBnr = null;

    /// <summary>
    /// バナー広告ユニットID
    /// </summary>
    string unitId_Bnr = "ca-app-pub-3940256099942544/6300978111";

    public void Init()
    {
        MobileAds.Initialize(initStatus => { });
        RequestBanner();
    }
    public void RequestBanner()
    {
        // バナー広告読み込み
        _AdBnr = new BannerView(unitId_Bnr, AdSize.SmartBanner, AdPosition.Bottom);
        AdRequest request = new AdRequest.Builder().Build();
        _AdBnr.LoadAd(request);
    }

}
