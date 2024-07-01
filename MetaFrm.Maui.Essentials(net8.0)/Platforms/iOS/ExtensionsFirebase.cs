using Microsoft.Maui.LifecycleEvents;
using Plugin.Firebase.CloudMessaging;
using Plugin.Firebase.Core.Platforms.iOS;

namespace MetaFrm.Maui.Platforms
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
                events.AddiOS(iOS => iOS.FinishedLaunching((app, launchOptions) =>
                {
#if RELEASE
                    CrossFirebase.Initialize();
                    FirebaseCloudMessagingImplementation.Initialize();
#endif
                    return false;
                }));
            });

            return builder;
        }
    }
}