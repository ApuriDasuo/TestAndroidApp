using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class AdMobManager : MonoBehaviour
{
    public static AdMobManager Instance=new AdMobManager();
    public BannerView _AdBnr = null;

    /// <summary>
    /// �o�i�[�L�����j�b�gID
    /// </summary>
    string unitId_Bnr = "ca-app-pub-3940256099942544/6300978111";

    public void Init()
    {
        MobileAds.Initialize(initStatus => { });
        RequestBanner();
    }
    public void RequestBanner()
    {
        // �o�i�[�L���ǂݍ���
        _AdBnr = new BannerView(unitId_Bnr, AdSize.SmartBanner, AdPosition.Bottom);
        AdRequest request = new AdRequest.Builder().Build();
        _AdBnr.LoadAd(request);
    }

}
