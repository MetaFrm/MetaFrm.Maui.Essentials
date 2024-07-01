using MetaFrm.Maui.Devices;
using Plugin.Firebase.CloudMessaging;

namespace MetaFrm.Maui.Firebase
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
            try
            {
                if (Factory.Platform == Maui.Devices.DevicePlatform.iOS || Factory.Platform == Maui.Devices.DevicePlatform.Android)
                {
                    await CrossFirebaseCloudMessaging.Current.CheckIfValidAsync();
                    var token = await CrossFirebaseCloudMessaging.Current.GetTokenAsync();

                    return token;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return null;
        }
    }
}