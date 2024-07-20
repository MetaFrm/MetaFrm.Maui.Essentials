using Plugin.MauiMTAdmob;

namespace MetaFrm.Maui.Essentials.Platforms
{
    /// <summary>
    /// ExtensionsMTAdmob
    /// </summary>
    public static class ExtensionsMTAdmob
    {
        /// <summary>
        /// RegisterMTAdmobServices
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="adsId"></param>
        /// <returns></returns>
        public static MauiAppBuilder RegisterMTAdmobServices(this MauiAppBuilder builder, string adsId)
        {
            builder.UseMauiMTAdmob();

            CrossMauiMTAdmob.Current.AdsId = adsId;

            builder.Services.AddSingleton<Ads.IAds, MTAdmob>();

            return builder;
        }

        /// <summary>
        /// MTAdmobInit
        /// </summary>
        /// <param name="activity"></param>
        public static void MTAdmobInit(this MauiAppCompatActivity activity)
        {
            CrossMauiMTAdmob.Current.Init(activity, CrossMauiMTAdmob.Current.AdsId);
        }
        /// <summary>
        /// MTAdmobOnResume
        /// </summary>
        /// <param name="_"></param>
        public static void MTAdmobOnResume(this MauiAppCompatActivity _)
        {
            CrossMauiMTAdmob.Current.OnResume();
        }
    }
}