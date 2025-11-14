using Plugin.MauiMtAdmob;

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
            builder.UseMauiMTAdmob();

            builder.Services.AddSingleton<Ads.IAds, MTAdmob>();

            return builder;
        }

        /// <summary>
        /// MTAdmobInit
        /// </summary>
        /// <param name="activity"></param>
        public static void MTAdmobInit(this MauiAppCompatActivity activity)
        {
            CrossMauiMTAdmob.Current.Init(activity, Factory.ProjectService.Attribute.SingleOrDefault(x => x.AttributeName == "Maui.Essentials.Platforms.AndroidAdsId")?.AttributeValue ?? "");
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