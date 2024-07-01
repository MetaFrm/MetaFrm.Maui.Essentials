﻿using Plugin.MauiMTAdmob;

namespace MetaFrm.Maui.Ads
{
    /// <summary>
    /// MTAdmob
    /// </summary>
    public class MTAdmob : IAds
    {
        /// <summary>
        /// IsDebug
        /// </summary>
        public bool IsDebug { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        private readonly string bannerAdsId;
        /// <summary>
        /// BannerAdsId
        /// </summary>
        public string BannerAdsId => this.bannerAdsId;

        private readonly string interstitialAdsId;
        /// <summary>
        /// InterstitialAdsId
        /// </summary>
        public string InterstitialAdsId => this.interstitialAdsId;

        private readonly string rewardeAdsId;
        /// <summary>
        /// RewardeAdsId
        /// </summary>
        public string RewardeAdsId => this.rewardeAdsId;

        private event EventHandler InterstitialOpened;
        /// <summary>
        /// OnInterstitialOpened
        /// </summary>
        public event EventHandler OnInterstitialOpened
        {

            add
            {
                this.InterstitialOpened += value;

                try
                {
                    try
                    {
                        CrossMauiMTAdmob.Current.OnInterstitialOpened -= Current_OnInterstitialOpened;
                    }
                    catch (Exception)
                    {
                    }
                    CrossMauiMTAdmob.Current.OnInterstitialOpened += Current_OnInterstitialOpened;
                }
                catch (Exception)
                {
                }
            }
            remove
            {
                try
                {
                    CrossMauiMTAdmob.Current.OnInterstitialOpened -= Current_OnInterstitialOpened;
                }
                catch (Exception)
                {
                }

                this.InterstitialOpened -= value;
            }
        }
        private void Current_OnInterstitialOpened(object sender, EventArgs e) => this.InterstitialOpened?.Invoke(sender, e);

        private event EventHandler InterstitialClosed;
        /// <summary>
        /// OnInterstitialClosed
        /// </summary>
        public event EventHandler OnInterstitialClosed
        {

            add
            {
                this.InterstitialOpened += value;

                try
                {
                    try
                    {
                        CrossMauiMTAdmob.Current.OnInterstitialClosed -= Current_OnInterstitialClosed;
                    }
                    catch (Exception)
                    {
                    }
                    CrossMauiMTAdmob.Current.OnInterstitialClosed += Current_OnInterstitialClosed;
                }
                catch (Exception)
                {
                }
            }
            remove
            {
                try
                {
                    CrossMauiMTAdmob.Current.OnInterstitialClosed -= Current_OnInterstitialClosed;
                }
                catch (Exception)
                {
                }

                this.InterstitialOpened -= value;
            }
        }
        private void Current_OnInterstitialClosed(object sender, EventArgs e) => this.InterstitialClosed?.Invoke(sender, e);

        private event EventHandler RewardedOpened;
        /// <summary>
        /// OnRewardedOpened
        /// </summary>
        public event EventHandler OnRewardedOpened
        {

            add
            {
                this.RewardedOpened += value;

                try
                {
                    try
                    {
                        CrossMauiMTAdmob.Current.OnRewardedOpened -= Current_OnRewardedOpened;
                    }
                    catch (Exception)
                    {
                    }
                    CrossMauiMTAdmob.Current.OnRewardedOpened += Current_OnRewardedOpened;
                }
                catch (Exception)
                {
                }
            }
            remove
            {
                try
                {
                    CrossMauiMTAdmob.Current.OnRewardedOpened -= Current_OnRewardedOpened;
                }
                catch (Exception)
                {
                }

                this.RewardedOpened -= value;
            }
        }
        private void Current_OnRewardedOpened(object sender, EventArgs e) => this.RewardedOpened?.Invoke(sender, e);

        private event EventHandler RewardedClosed;
        /// <summary>
        /// OnRewardedClosed
        /// </summary>
        public event EventHandler OnRewardedClosed
        {

            add
            {
                this.RewardedClosed += value;

                try
                {
                    try
                    {
                        CrossMauiMTAdmob.Current.OnRewardedClosed -= Current_OnRewardedClosed;
                    }
                    catch (Exception)
                    {
                    }
                    CrossMauiMTAdmob.Current.OnRewardedClosed += Current_OnRewardedClosed;
                }
                catch (Exception)
                {
                }
            }
            remove
            {
                try
                {
                    CrossMauiMTAdmob.Current.OnRewardedClosed -= Current_OnRewardedClosed;
                }
                catch (Exception)
                {
                }

                this.RewardedClosed -= value;
            }
        }
        private void Current_OnRewardedClosed(object sender, EventArgs e) => this.RewardedClosed?.Invoke(sender, e);

        /// <summary>
        /// IsInterstitialLoaded
        /// </summary>
        public bool IsInterstitialLoaded => CrossMauiMTAdmob.Current.IsInterstitialLoaded();
        /// <summary>
        /// IsRewardedLoaded
        /// </summary>
        public bool IsRewardedLoaded => CrossMauiMTAdmob.Current.IsRewardedLoaded();

        /// <summary>
        /// MTAdmob
        /// </summary>
        public MTAdmob()
        {
            try
            {
                if (DeviceInfo.Platform.Equals(DevicePlatform.Android))
                    this.bannerAdsId = this.IsDebug ? "ca-app-pub-3940256099942544/6300978111" : this.GetAttribute("AndroidBannerAdsId");
                else if (DeviceInfo.Platform.Equals(DevicePlatform.iOS))
                    this.bannerAdsId = this.IsDebug ? "ca-app-pub-3940256099942544/2934735716" : this.GetAttribute("iOSBannerAdsId");
                else
                    this.bannerAdsId = "";
            }
            catch (Exception)
            {
                this.bannerAdsId = "";
            }

            try
            {
                if (DeviceInfo.Platform.Equals(DevicePlatform.Android))
                    this.interstitialAdsId = this.IsDebug ? "ca-app-pub-3940256099942544/1033173712" : this.GetAttribute("AndroidInterstitialAdsId");
                else if (DeviceInfo.Platform.Equals(DevicePlatform.iOS))
                    this.interstitialAdsId = this.IsDebug ? "ca-app-pub-3940256099942544/4411468910" : this.GetAttribute("iOSInterstitialAdsId");
                else
                    this.interstitialAdsId = "";
            }
            catch (Exception)
            {
                this.interstitialAdsId = "";
            }

            try
            {
                if (DeviceInfo.Platform.Equals(DevicePlatform.Android))
                    this.rewardeAdsId = this.IsDebug ? "ca-app-pub-3940256099942544/5224354917" : this.GetAttribute("AndroidRewardeAdsId");
                else if (DeviceInfo.Platform.Equals(DevicePlatform.iOS))
                    this.rewardeAdsId = this.IsDebug ? "ca-app-pub-3940256099942544/1712485313" : this.GetAttribute("iOSRewardeAdsId");
                else
                    this.rewardeAdsId = "";
            }
            catch (Exception)
            {
                this.rewardeAdsId = "";
            }
        }
    }
}