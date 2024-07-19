﻿using MetaFrm.Extensions;

namespace MetaFrm.Maui.Essentials.Platforms
{
    /// <summary>
    /// UseMetaFrm
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// UseMetaFrm
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="baseAddress"></param>
        /// <param name="accessKey"></param>
        /// <param name="platform"></param>
        /// <param name="registerFirebaseServices"></param>
        /// <param name="registerMTAdmobServices"></param>
        /// <returns></returns>
        public static MauiAppBuilder UseMetaFrm(this MauiAppBuilder builder, string baseAddress, string accessKey, Maui.Devices.DevicePlatform platform, bool registerFirebaseServices, bool registerMTAdmobServices)
        {
            Factory.AppDataDirectory = FileSystem.Current.AppDataDirectory;

            builder.Services.AddFactory(baseAddress, accessKey, platform);

            if (registerFirebaseServices && registerMTAdmobServices)
            {
                if (Factory.Platform == Maui.Devices.DevicePlatform.Android)
                    return builder.RegisterFirebaseServices().RegisterMTAdmobServices("MetaFrm.Maui.Platforms".GetAttribute("AndroidAdsId"));
                if (Factory.Platform == Maui.Devices.DevicePlatform.iOS)
                    return builder.RegisterFirebaseServices().RegisterMTAdmobServices("MetaFrm.Maui.Platforms".GetAttribute("iOSAdsId"));
            }
            else if (registerFirebaseServices && !registerMTAdmobServices)
                return builder.RegisterFirebaseServices();
            else if (!registerFirebaseServices && registerMTAdmobServices)
            {
                if (Factory.Platform == Maui.Devices.DevicePlatform.Android)
                    return builder.RegisterMTAdmobServices("MetaFrm.Maui.Platforms".GetAttribute("AndroidAdsId"));
                if (Factory.Platform == Maui.Devices.DevicePlatform.iOS)
                    return builder.RegisterMTAdmobServices("MetaFrm.Maui.Platforms".GetAttribute("iOSAdsId"));
            }

            builder.Services.AddMetaFrm();//AddMetaFrm

            return builder;
        }
    }
}