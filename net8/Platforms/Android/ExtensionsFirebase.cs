using Microsoft.Maui.LifecycleEvents;
using Plugin.Firebase.Core.Platforms.Android;

namespace MetaFrm.Maui.Essentials.Platforms
{
    /// <summary>
    /// ExtensionsFirebase
    /// </summary>
    public static class ExtensionsFirebase
    {
        /// <summary>
        /// RegisterFirebaseServices
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static MauiAppBuilder RegisterFirebaseServices(this MauiAppBuilder builder)
        {
            builder.ConfigureLifecycleEvents(events =>
            {
                events.AddAndroid(android => android.OnCreate((activity, _) =>
                CrossFirebase.Initialize(activity)));
            });

            return builder;
        }
    }
}