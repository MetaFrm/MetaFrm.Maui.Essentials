namespace MetaFrm.Maui.ApplicationModel
{
    /// <summary>
    /// Permissions
    /// </summary>
    public class Permissions : IPermissions
    {
        /// <summary>
        /// PermissionsRequestAsync
        /// </summary>
        /// <param name="permissionType"></param>
        /// <returns></returns>
        public async Task PermissionsRequestAsync(PermissionType permissionType)
        {
            PermissionStatus state;

            switch (permissionType)
            {
                case PermissionType.StorageWrite: state = await Microsoft.Maui.ApplicationModel.Permissions.CheckStatusAsync<Microsoft.Maui.ApplicationModel.Permissions.StorageWrite>(); break;
                case PermissionType.StorageRead: state = await Microsoft.Maui.ApplicationModel.Permissions.CheckStatusAsync<Microsoft.Maui.ApplicationModel.Permissions.StorageRead>(); break;
                case PermissionType.Speech: state = await Microsoft.Maui.ApplicationModel.Permissions.CheckStatusAsync<Microsoft.Maui.ApplicationModel.Permissions.Speech>(); break;
                case PermissionType.Sms: state = await Microsoft.Maui.ApplicationModel.Permissions.CheckStatusAsync<Microsoft.Maui.ApplicationModel.Permissions.Sms>(); break;
                case PermissionType.Sensors: state = await Microsoft.Maui.ApplicationModel.Permissions.CheckStatusAsync<Microsoft.Maui.ApplicationModel.Permissions.Sensors>(); break;
                case PermissionType.Reminders: state = await Microsoft.Maui.ApplicationModel.Permissions.CheckStatusAsync<Microsoft.Maui.ApplicationModel.Permissions.Reminders>(); break;
                case PermissionType.PhotosAddOnly: state = await Microsoft.Maui.ApplicationModel.Permissions.CheckStatusAsync<Microsoft.Maui.ApplicationModel.Permissions.PhotosAddOnly>(); break;
                case PermissionType.Photos: state = await Microsoft.Maui.ApplicationModel.Permissions.CheckStatusAsync<Microsoft.Maui.ApplicationModel.Permissions.Photos>(); break;
                case PermissionType.Phone: state = await Microsoft.Maui.ApplicationModel.Permissions.CheckStatusAsync<Microsoft.Maui.ApplicationModel.Permissions.Phone>(); break;
                case PermissionType.NetworkState: state = await Microsoft.Maui.ApplicationModel.Permissions.CheckStatusAsync<Microsoft.Maui.ApplicationModel.Permissions.NetworkState>(); break;
                case PermissionType.Microphone: state = await Microsoft.Maui.ApplicationModel.Permissions.CheckStatusAsync<Microsoft.Maui.ApplicationModel.Permissions.Microphone>(); break;
                case PermissionType.Media: state = await Microsoft.Maui.ApplicationModel.Permissions.CheckStatusAsync<Microsoft.Maui.ApplicationModel.Permissions.Media>(); break;
                case PermissionType.Maps: state = await Microsoft.Maui.ApplicationModel.Permissions.CheckStatusAsync<Microsoft.Maui.ApplicationModel.Permissions.Maps>(); break;
                case PermissionType.LocationAlways: state = await Microsoft.Maui.ApplicationModel.Permissions.CheckStatusAsync<Microsoft.Maui.ApplicationModel.Permissions.LocationAlways>(); break;
                case PermissionType.LocationWhenInUse: state = await Microsoft.Maui.ApplicationModel.Permissions.CheckStatusAsync<Microsoft.Maui.ApplicationModel.Permissions.LocationWhenInUse>(); break;
                case PermissionType.LaunchApp: state = await Microsoft.Maui.ApplicationModel.Permissions.CheckStatusAsync<Microsoft.Maui.ApplicationModel.Permissions.LaunchApp>(); break;
                case PermissionType.Flashlight: state = await Microsoft.Maui.ApplicationModel.Permissions.CheckStatusAsync<Microsoft.Maui.ApplicationModel.Permissions.Flashlight>(); break;
                case PermissionType.ContactsWrite: state = await Microsoft.Maui.ApplicationModel.Permissions.CheckStatusAsync<Microsoft.Maui.ApplicationModel.Permissions.ContactsWrite>(); break;
                case PermissionType.ContactsRead: state = await Microsoft.Maui.ApplicationModel.Permissions.CheckStatusAsync<Microsoft.Maui.ApplicationModel.Permissions.ContactsRead>(); break;
                case PermissionType.Camera: state = await Microsoft.Maui.ApplicationModel.Permissions.CheckStatusAsync<Microsoft.Maui.ApplicationModel.Permissions.Camera>(); break;
                case PermissionType.CalendarWrite: state = await Microsoft.Maui.ApplicationModel.Permissions.CheckStatusAsync<Microsoft.Maui.ApplicationModel.Permissions.CalendarWrite>(); break;
                case PermissionType.CalendarRead: state = await Microsoft.Maui.ApplicationModel.Permissions.CheckStatusAsync<Microsoft.Maui.ApplicationModel.Permissions.CalendarRead>(); break;
                case PermissionType.Battery: state = await Microsoft.Maui.ApplicationModel.Permissions.CheckStatusAsync<Microsoft.Maui.ApplicationModel.Permissions.Battery>(); break;
                case PermissionType.Vibrate: state = await Microsoft.Maui.ApplicationModel.Permissions.CheckStatusAsync<Microsoft.Maui.ApplicationModel.Permissions.Vibrate>(); break;
                default:
                    return;
            }

            if (state != PermissionStatus.Granted)
            {
                switch (permissionType)
                {
                    case PermissionType.StorageWrite: state = await Microsoft.Maui.ApplicationModel.Permissions.RequestAsync<Microsoft.Maui.ApplicationModel.Permissions.StorageWrite>(); break;
                    case PermissionType.StorageRead: state = await Microsoft.Maui.ApplicationModel.Permissions.RequestAsync<Microsoft.Maui.ApplicationModel.Permissions.StorageRead>(); break;
                    case PermissionType.Speech: state = await Microsoft.Maui.ApplicationModel.Permissions.RequestAsync<Microsoft.Maui.ApplicationModel.Permissions.Speech>(); break;
                    case PermissionType.Sms: state = await Microsoft.Maui.ApplicationModel.Permissions.RequestAsync<Microsoft.Maui.ApplicationModel.Permissions.Sms>(); break;
                    case PermissionType.Sensors: state = await Microsoft.Maui.ApplicationModel.Permissions.RequestAsync<Microsoft.Maui.ApplicationModel.Permissions.Sensors>(); break;
                    case PermissionType.Reminders: state = await Microsoft.Maui.ApplicationModel.Permissions.RequestAsync<Microsoft.Maui.ApplicationModel.Permissions.Reminders>(); break;
                    case PermissionType.PhotosAddOnly: state = await Microsoft.Maui.ApplicationModel.Permissions.RequestAsync<Microsoft.Maui.ApplicationModel.Permissions.PhotosAddOnly>(); break;
                    case PermissionType.Photos: state = await Microsoft.Maui.ApplicationModel.Permissions.RequestAsync<Microsoft.Maui.ApplicationModel.Permissions.Photos>(); break;
                    case PermissionType.Phone: state = await Microsoft.Maui.ApplicationModel.Permissions.RequestAsync<Microsoft.Maui.ApplicationModel.Permissions.Phone>(); break;
                    case PermissionType.NetworkState: state = await Microsoft.Maui.ApplicationModel.Permissions.RequestAsync<Microsoft.Maui.ApplicationModel.Permissions.NetworkState>(); break;
                    case PermissionType.Microphone: state = await Microsoft.Maui.ApplicationModel.Permissions.RequestAsync<Microsoft.Maui.ApplicationModel.Permissions.Microphone>(); break;
                    case PermissionType.Media: state = await Microsoft.Maui.ApplicationModel.Permissions.RequestAsync<Microsoft.Maui.ApplicationModel.Permissions.Media>(); break;
                    case PermissionType.Maps: state = await Microsoft.Maui.ApplicationModel.Permissions.RequestAsync<Microsoft.Maui.ApplicationModel.Permissions.Maps>(); break;
                    case PermissionType.LocationAlways: state = await Microsoft.Maui.ApplicationModel.Permissions.RequestAsync<Microsoft.Maui.ApplicationModel.Permissions.LocationAlways>(); break;
                    case PermissionType.LocationWhenInUse: state = await Microsoft.Maui.ApplicationModel.Permissions.RequestAsync<Microsoft.Maui.ApplicationModel.Permissions.LocationWhenInUse>(); break;
                    case PermissionType.LaunchApp: state = await Microsoft.Maui.ApplicationModel.Permissions.RequestAsync<Microsoft.Maui.ApplicationModel.Permissions.LaunchApp>(); break;
                    case PermissionType.Flashlight: state = await Microsoft.Maui.ApplicationModel.Permissions.RequestAsync<Microsoft.Maui.ApplicationModel.Permissions.Flashlight>(); break;
                    case PermissionType.ContactsWrite: state = await Microsoft.Maui.ApplicationModel.Permissions.RequestAsync<Microsoft.Maui.ApplicationModel.Permissions.ContactsWrite>(); break;
                    case PermissionType.ContactsRead: state = await Microsoft.Maui.ApplicationModel.Permissions.RequestAsync<Microsoft.Maui.ApplicationModel.Permissions.ContactsRead>(); break;
                    case PermissionType.Camera: state = await Microsoft.Maui.ApplicationModel.Permissions.RequestAsync<Microsoft.Maui.ApplicationModel.Permissions.Camera>(); break;
                    case PermissionType.CalendarWrite: state = await Microsoft.Maui.ApplicationModel.Permissions.RequestAsync<Microsoft.Maui.ApplicationModel.Permissions.CalendarWrite>(); break;
                    case PermissionType.CalendarRead: state = await Microsoft.Maui.ApplicationModel.Permissions.RequestAsync<Microsoft.Maui.ApplicationModel.Permissions.CalendarRead>(); break;
                    case PermissionType.Battery: state = await Microsoft.Maui.ApplicationModel.Permissions.RequestAsync<Microsoft.Maui.ApplicationModel.Permissions.Battery>(); break;
                    case PermissionType.Vibrate: state = await Microsoft.Maui.ApplicationModel.Permissions.RequestAsync<Microsoft.Maui.ApplicationModel.Permissions.Vibrate>(); break;
                    default:
                        return;
                }

                if (state != PermissionStatus.Granted)
                    return;
            }
        }
    }
}