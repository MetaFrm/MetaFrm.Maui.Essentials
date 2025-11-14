using MetaFrm.Ads;

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
        /// <returns></returns>
        public static MauiAppBuilder RegisterMTAdmobServices(this MauiAppBuilder builder)
        {
            builder.Services.AddSingleton<Ads.IAds, DummyAds>();

            return builder;
        }
    }
}