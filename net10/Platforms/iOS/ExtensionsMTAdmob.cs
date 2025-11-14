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
        /// <param name="appDelegate"></param>
        public static void MTAdmobInit(this MauiUIApplicationDelegate appDelegate)
        {
            CrossMauiMTAdmob.Current.Init();
        }
        /// <summary>
        /// MTAdmobOnResume
        /// </summary>
        /// <param name="_"></param>
        public static void MTAdmobOnResume(this MauiUIApplicationDelegate _)
        {
            CrossMauiMTAdmob.Current.OnResume();
        }
    }
}