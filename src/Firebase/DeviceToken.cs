using MetaFrm.Maui.Devices;
using Plugin.Firebase.CloudMessaging;

namespace MetaFrm.Maui.Essentials.Firebase
{
    /// <summary>
    /// DeviceToken
    /// </summary>
    public class DeviceToken : IDeviceToken
    {
        /// <summary>
        /// GetToken
        /// </summary>
        /// <returns></returns>
        public async Task<string> GetToken()
        {
            PermissionStatus state;

            try
            {
                if (Factory.Platform == Maui.Devices.DevicePlatform.iOS || Factory.Platform == Maui.Devices.DevicePlatform.Android)
                {
                    if (Factory.Platform == Maui.Devices.DevicePlatform.Android)
                    {
                        state = await Permissions.CheckStatusAsync<Permissions.PostNotifications>();

                        if (state != PermissionStatus.Granted)
                            state = await Permissions.RequestAsync<Permissions.PostNotifications>();
                    }

                    await CrossFirebaseCloudMessaging.Current.CheckIfValidAsync();
                    var token = await CrossFirebaseCloudMessaging.Current.GetTokenAsync();

                    return token;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return "";
        }
    }
}