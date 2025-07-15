using MetaFrm.Extensions;
using System.ComponentModel;

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
            //services.AddSingleton<  Factory>();//ExtensionsIServiceCollection에서 기본으로 AddSingleton DI 해줌
            services.AddSingleton<  Maui.ApplicationModel.IPermissions, ApplicationModel.Permissions>();
            services.AddSingleton<  Maui.ApplicationModel.IBrowser, ApplicationModel.Browser>();
            services.AddSingleton<  Microsoft.AspNetCore.Components.Authorization.AuthenticationStateProvider, Auth.AuthenticationStateProvider>();
            services.AddSingleton<  Maui.Devices.IDeviceInfo, Devices.DeviceInfo>();
            services.AddSingleton<  Maui.Devices.IDeviceToken, Firebase.DeviceToken>();
            services.AddSingleton<  Maui.Notification.ICloudMessaging, Firebase.Notification.CloudMessaging>();
            //Maui.Ads.IAds 개별 플랫폼에 정의 되어 있음
            services.AddSingleton<  Maui.Storage.IPreferences, Storage.Preferences>();

            services.AddOptions();
            services.AddAuthorizationCore();

            services.AddSingleton<  MetaFrm.Localization.ICultureChanged, MetaFrm.Maui.Essentials.Localization.CultureChanger>();
            services.AddSingleton<  MetaFrm.Localization.ILanguageCollector, MetaFrm.Localization.LanguageCollector>();
            services.AddSingleton<  Microsoft.Extensions.Localization.IStringLocalizer, MetaFrm.Razor.Essentials.Localization.LocalizationManager>();

            services.AddSingleton<INotifyPropertyChanged, MetaFrm.Maui.Essentials.Localization.LocalizationNotifier>();//Maui xaml

            if (!services.Any(x => x.ServiceType == typeof(Control.IActionEvent)))
                services.AddSingleton<  Control.IActionEvent, Control.DummyActionEvent>();

            services.AddLocalization();

            return services;
        }
    }
}