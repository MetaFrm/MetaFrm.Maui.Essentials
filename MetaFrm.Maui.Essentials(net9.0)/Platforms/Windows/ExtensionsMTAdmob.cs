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
            builder.Services.AddSingleton<Ads.IAds, MTAdmob>();

            return builder;
        }
    }
}