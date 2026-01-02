namespace MetaFrm.Maui.Essentials.Platforms
{
    /// <summary>
    /// Extensions
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// UseMetaFrmMauiApp
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="registerFirebaseServices"></param>
        /// <param name="registerMTAdmobServices"></param>
        /// <returns></returns>
        public static MauiAppBuilder UseMetaFrmMauiApp(this MauiAppBuilder builder, bool registerFirebaseServices, bool registerMTAdmobServices)
        {
            Factory.AppDataDirectory = FileSystem.Current.AppDataDirectory;

            if (registerFirebaseServices)
                builder.RegisterFirebaseServices();

            if (registerMTAdmobServices)
                builder.RegisterMTAdmobServices();
            else
                builder.Services.AddSingleton<Ads.IAds, MetaFrm.Ads.DummyAds>();

            return builder;
        }
    }
}