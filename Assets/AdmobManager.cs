using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using GoogleMobileAds.Api;

public class AdmobManager : MonoBehaviour
{
    public void Start()
    {
        // Initialize the Google Mobile Ads SDK.
      /*  MobileAds.Initialize((InitializationStatus initStatus) =>
        {
           LoadInterstitialAd();
        });*/
    }

    // These ad units are configured to always serve test ads.
/*#if UNITY_ANDROID
    private string _adUnitId = "ca-app-pub-3940256099942544/1033173712";
#elif UNITY_IPHONE
  private string _adUnitId = "ca-app-pub-3940256099942544/4411468910";
#else
  private string _adUnitId = "unused";
#endif
    
    private InterstitialAd interstitialAd;*/

    /// <summary>
    /// Loads the interstitial ad.
    /// </summary>
   /* public void LoadInterstitialAd()
    {
        // Clean up the old ad before loading a new one.
        if (interstitialAd != null)
        {
            interstitialAd.Destroy();
            interstitialAd = null;
        }

        Debug.Log("Cargando el anuncio intersticial.");

        // create our request used to load the ad.
        var adRequest = new AdRequest();
        adRequest.Keywords.Add("unity-admob-sample");

        // send the request to load the ad.
        InterstitialAd.Load(_adUnitId, adRequest,
            (InterstitialAd ad, LoadAdError error) =>
            {
              // if error is not null, the load request failed.
              if (error != null || ad == null)
                {
                    Debug.LogError("el anuncio intersticial no pudo cargar un anuncio " +
                                   "con error : " + error);
                    return;
              }

                Debug.Log("Anuncio intersticial cargado con respuesta : "
                          + ad.GetResponseInfo());

                interstitialAd = ad;
               // ShowAd();
            });
    }*/

    /// <summary>
    /// Shows the interstitial ad.
    /// </summary>
    public void ShowAd()
    {
       /* if (interstitialAd != null && interstitialAd.CanShowAd())
        {
            Debug.Log("Mostrando anuncio intersticial");
            interstitialAd.Show();
        }
        else
        {
            Debug.LogError("El anuncio intersticial aún no está listo.");
        }*/
    }
}
