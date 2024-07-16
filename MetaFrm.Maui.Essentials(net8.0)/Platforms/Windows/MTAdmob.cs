using MetaFrm.Maui.Ads;

namespace MetaFrm.Maui.Essentials.Platforms
{
    /// <summary>
    /// MTAdmob
    /// </summary>
    public class MTAdmob : IAds
    {
        /// <summary>
        /// IsDebug
        /// </summary>
        public bool IsDebug { get; set; }

        /// <summary>
        /// BannerAdsId
        /// </summary>
        public string BannerAdsId => "";

        /// <summary>
        /// InterstitialAdsId
        /// </summary>
        public string InterstitialAdsId => "";

        /// <summary>
        /// RewardeAdsId
        /// </summary>
        public string RewardeAdsId => "";

        /// <summary>
        /// OnInterstitialOpened
        /// </summary>
        public event EventHandler OnInterstitialOpened { add { } remove { } }
        /// <summary>
        /// OnInterstitialClosed
        /// </summary>
        public event EventHandler OnInterstitialClosed { add { } remove { } }

        /// <summary>
        /// OnRewardedOpened
        /// </summary>
        public event EventHandler OnRewardedOpened { add { } remove { } }
        /// <summary>
        /// OnRewardedClosed
        /// </summary>
        public event EventHandler OnRewardedClosed { add { } remove { } }

        /// <summary>
        /// IsInterstitialLoaded
        /// </summary>
        public bool IsInterstitialLoaded => false;
        /// <summary>
        /// IsRewardedLoaded
        /// </summary>
        public bool IsRewardedLoaded => false;

        /// <summary>
        /// ShowInterstitial
        /// </summary>
        public void ShowInterstitial() { }

        /// <summary>
        /// ShowRewarded
        /// </summary>
        public void ShowRewarded() { }
    }
}