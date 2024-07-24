using MetaFrm.Extensions;

namespace MetaFrm.Maui.Essentials
{
    /// <summary>
    /// AddMetaFrm
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// AddMetaFrm
        /// </summary>
        /// <param name="services"></param>
        /// <param name="baseAddress"></param>
        /// <param name="accessKey"></param>
        /// <param name="platform"></param>
        /// <returns></returns>
        public static IServiceCollection AddMetaFrm(this IServiceCollection services, string baseAddress, string accessKey, Maui.Devices.DevicePlatform platform)
        {
            services.AddFactory(baseAddress, accessKey, platform);
            services.AddMetaFrm();

            return services;
        }

        /// <summary>
        /// AddMetaFrm
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddMetaFrm(this IServiceCollection services)
        {
            services.AddSingleton<Maui.ApplicationModel.IPermissions, ApplicationModel.Permissions>();
            services.AddSingleton<Maui.ApplicationModel.IBrowser, ApplicationModel.Browser>();
            services.AddScoped<Microsoft.AspNetCore.Components.Authorization.AuthenticationStateProvider, Auth.AuthenticationStateProvider>();
            services.AddSingleton<Maui.Devices.IDeviceInfo, Devices.DeviceInfo>();//DeviceInfo
            services.AddSingleton<Maui.Devices.IDeviceToken, Firebase.DeviceToken>();//DeviceToken
            services.AddSingleton<Maui.Notification.ICloudMessaging, Firebase.Notification.CloudMessaging>();//CloudMessaging
            services.AddScoped<Maui.Storage.IPreferences, Maui.Essentials.Storage.Preferences>();

            services.AddOptions();
            services.AddAuthorizationCore();

            services.AddSingleton<MetaFrm.Localization.ICultureChanged, Localization.LocalizationManager>();
            services.AddSingleton<Microsoft.Extensions.Localization.IStringLocalizer, Razor.Essentials.Localization.LocalizationManager>();

            services.AddLocalization();

            return services;
        }
    }
}