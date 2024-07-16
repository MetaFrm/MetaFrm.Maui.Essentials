namespace MetaFrm.Maui.Essentials.ApplicationModel
{
    /// <summary>
    /// Permissions
    /// </summary>
    public class Permissions : Maui.ApplicationModel.IPermissions
    {
        /// <summary>
        /// PermissionsRequestAsync
        /// </summary>
        /// <param name="permissionType"></param>
        /// <returns></returns>
        public async Task PermissionsRequestAsync(Maui.ApplicationModel.PermissionType permissionType)
        {
            PermissionStatus state;

            switch (permissionType)
            {
                case Maui.ApplicationModel.PermissionType.StorageWrite: state = await Microsoft.Maui.ApplicationModel.Permissions.CheckStatusAsync<Microsoft.Maui.ApplicationModel.Permissions.StorageWrite>(); break;
                case Maui.ApplicationModel.PermissionType.StorageRead: state = await Microsoft.Maui.ApplicationModel.Permissions.CheckStatusAsync<Microsoft.Maui.ApplicationModel.Permissions.StorageRead>(); break;
                case Maui.ApplicationModel.PermissionType.Speech: state = await Microsoft.Maui.ApplicationModel.Permissions.CheckStatusAsync<Microsoft.Maui.ApplicationModel.Permissions.Speech>(); break;
                case Maui.ApplicationModel.PermissionType.Sms: state = await Microsoft.Maui.ApplicationModel.Permissions.CheckStatusAsync<Microsoft.Maui.ApplicationModel.Permissions.Sms>(); break;
                case Maui.ApplicationModel.PermissionType.Sensors: state = await Microsoft.Maui.ApplicationModel.Permissions.CheckStatusAsync<Microsoft.Maui.ApplicationModel.Permissions.Sensors>(); break;
                case Maui.ApplicationModel.PermissionType.Reminders: state = await Microsoft.Maui.ApplicationModel.Permissions.CheckStatusAsync<Microsoft.Maui.ApplicationModel.Permissions.Reminders>(); break;
                case Maui.ApplicationModel.PermissionType.PhotosAddOnly: state = await Microsoft.Maui.ApplicationModel.Permissions.CheckStatusAsync<Microsoft.Maui.ApplicationModel.Permissions.PhotosAddOnly>(); break;
                case Maui.ApplicationModel.PermissionType.Photos: state = await Microsoft.Maui.ApplicationModel.Permissions.CheckStatusAsync<Microsoft.Maui.ApplicationModel.Permissions.Photos>(); break;
                case Maui.ApplicationModel.PermissionType.Phone: state = await Microsoft.Maui.ApplicationModel.Permissions.CheckStatusAsync<Microsoft.Maui.ApplicationModel.Permissions.Phone>(); break;
                case Maui.ApplicationModel.PermissionType.NetworkState: state = await Microsoft.Maui.ApplicationModel.Permissions.CheckStatusAsync<Microsoft.Maui.ApplicationModel.Permissions.NetworkState>(); break;
                case Maui.ApplicationModel.PermissionType.Microphone: state = await Microsoft.Maui.ApplicationModel.Permissions.CheckStatusAsync<Microsoft.Maui.ApplicationModel.Permissions.Microphone>(); break;
                case Maui.ApplicationModel.PermissionType.Media: state = await Microsoft.Maui.ApplicationModel.Permissions.CheckStatusAsync<Microsoft.Maui.ApplicationModel.Permissions.Media>(); break;
                case Maui.ApplicationModel.PermissionType.Maps: state = await Microsoft.Maui.ApplicationModel.Permissions.CheckStatusAsync<Microsoft.Maui.ApplicationModel.Permissions.Maps>(); break;
                case Maui.ApplicationModel.PermissionType.LocationAlways: state = await Microsoft.Maui.ApplicationModel.Permissions.CheckStatusAsync<Microsoft.Maui.ApplicationModel.Permissions.LocationAlways>(); break;
                case Maui.ApplicationModel.PermissionType.LocationWhenInUse: state = await Microsoft.Maui.ApplicationModel.Permissions.CheckStatusAsync<Microsoft.Maui.ApplicationModel.Permissions.LocationWhenInUse>(); break;
                case Maui.ApplicationModel.PermissionType.LaunchApp: state = await Microsoft.Maui.ApplicationModel.Permissions.CheckStatusAsync<Microsoft.Maui.ApplicationModel.Permissions.LaunchApp>(); break;
                case Maui.ApplicationModel.PermissionType.Flashlight: state = await Microsoft.Maui.ApplicationModel.Permissions.CheckStatusAsync<Microsoft.Maui.ApplicationModel.Permissions.Flashlight>(); break;
                case Maui.ApplicationModel.PermissionType.ContactsWrite: state = await Microsoft.Maui.ApplicationModel.Permissions.CheckStatusAsync<Microsoft.Maui.ApplicationModel.Permissions.ContactsWrite>(); break;
                case Maui.ApplicationModel.PermissionType.ContactsRead: state = await Microsoft.Maui.ApplicationModel.Permissions.CheckStatusAsync<Microsoft.Maui.ApplicationModel.Permissions.ContactsRead>(); break;
                case Maui.ApplicationModel.PermissionType.Camera: state = await Microsoft.Maui.ApplicationModel.Permissions.CheckStatusAsync<Microsoft.Maui.ApplicationModel.Permissions.Camera>(); break;
                case Maui.ApplicationModel.PermissionType.CalendarWrite: state = await Microsoft.Maui.ApplicationModel.Permissions.CheckStatusAsync<Microsoft.Maui.ApplicationModel.Permissions.CalendarWrite>(); break;
                case Maui.ApplicationModel.PermissionType.CalendarRead: state = await Microsoft.Maui.ApplicationModel.Permissions.CheckStatusAsync<Microsoft.Maui.ApplicationModel.Permissions.CalendarRead>(); break;
                case Maui.ApplicationModel.PermissionType.Battery: state = await Microsoft.Maui.ApplicationModel.Permissions.CheckStatusAsync<Microsoft.Maui.ApplicationModel.Permissions.Battery>(); break;
                case Maui.ApplicationModel.PermissionType.Vibrate: state = await Microsoft.Maui.ApplicationModel.Permissions.CheckStatusAsync<Microsoft.Maui.ApplicationModel.Permissions.Vibrate>(); break;
                default:
                    return;
            }

            if (state != PermissionStatus.Granted)
            {
                switch (permissionType)
                {
                    case Maui.ApplicationModel.PermissionType.StorageWrite: state = await Microsoft.Maui.ApplicationModel.Permissions.RequestAsync<Microsoft.Maui.ApplicationModel.Permissions.StorageWrite>(); break;
                    case Maui.ApplicationModel.PermissionType.StorageRead: state = await Microsoft.Maui.ApplicationModel.Permissions.RequestAsync<Microsoft.Maui.ApplicationModel.Permissions.StorageRead>(); break;
                    case Maui.ApplicationModel.PermissionType.Speech: state = await Microsoft.Maui.ApplicationModel.Permissions.RequestAsync<Microsoft.Maui.ApplicationModel.Permissions.Speech>(); break;
                    case Maui.ApplicationModel.PermissionType.Sms: state = await Microsoft.Maui.ApplicationModel.Permissions.RequestAsync<Microsoft.Maui.ApplicationModel.Permissions.Sms>(); break;
                    case Maui.ApplicationModel.PermissionType.Sensors: state = await Microsoft.Maui.ApplicationModel.Permissions.RequestAsync<Microsoft.Maui.ApplicationModel.Permissions.Sensors>(); break;
                    case Maui.ApplicationModel.PermissionType.Reminders: state = await Microsoft.Maui.ApplicationModel.Permissions.RequestAsync<Microsoft.Maui.ApplicationModel.Permissions.Reminders>(); break;
                    case Maui.ApplicationModel.PermissionType.PhotosAddOnly: state = await Microsoft.Maui.ApplicationModel.Permissions.RequestAsync<Microsoft.Maui.ApplicationModel.Permissions.PhotosAddOnly>(); break;
                    case Maui.ApplicationModel.PermissionType.Photos: state = await Microsoft.Maui.ApplicationModel.Permissions.RequestAsync<Microsoft.Maui.ApplicationModel.Permissions.Photos>(); break;
                    case Maui.ApplicationModel.PermissionType.Phone: state = await Microsoft.Maui.ApplicationModel.Permissions.RequestAsync<Microsoft.Maui.ApplicationModel.Permissions.Phone>(); break;
                    case Maui.ApplicationModel.PermissionType.NetworkState: state = await Microsoft.Maui.ApplicationModel.Permissions.RequestAsync<Microsoft.Maui.ApplicationModel.Permissions.NetworkState>(); break;
                    case Maui.ApplicationModel.PermissionType.Microphone: state = await Microsoft.Maui.ApplicationModel.Permissions.RequestAsync<Microsoft.Maui.ApplicationModel.Permissions.Microphone>(); break;
                    case Maui.ApplicationModel.PermissionType.Media: state = await Microsoft.Maui.ApplicationModel.Permissions.RequestAsync<Microsoft.Maui.ApplicationModel.Permissions.Media>(); break;
                    case Maui.ApplicationModel.PermissionType.Maps: state = await Microsoft.Maui.ApplicationModel.Permissions.RequestAsync<Microsoft.Maui.ApplicationModel.Permissions.Maps>(); break;
                    case Maui.ApplicationModel.PermissionType.LocationAlways: state = await Microsoft.Maui.ApplicationModel.Permissions.RequestAsync<Microsoft.Maui.ApplicationModel.Permissions.LocationAlways>(); break;
                    case Maui.ApplicationModel.PermissionType.LocationWhenInUse: state = await Microsoft.Maui.ApplicationModel.Permissions.RequestAsync<Microsoft.Maui.ApplicationModel.Permissions.LocationWhenInUse>(); break;
                    case Maui.ApplicationModel.PermissionType.LaunchApp: state = await Microsoft.Maui.ApplicationModel.Permissions.RequestAsync<Microsoft.Maui.ApplicationModel.Permissions.LaunchApp>(); break;
                    case Maui.ApplicationModel.PermissionType.Flashlight: state = await Microsoft.Maui.ApplicationModel.Permissions.RequestAsync<Microsoft.Maui.ApplicationModel.Permissions.Flashlight>(); break;
                    case Maui.ApplicationModel.PermissionType.ContactsWrite: state = await Microsoft.Maui.ApplicationModel.Permissions.RequestAsync<Microsoft.Maui.ApplicationModel.Permissions.ContactsWrite>(); break;
                    case Maui.ApplicationModel.PermissionType.ContactsRead: state = await Microsoft.Maui.ApplicationModel.Permissions.RequestAsync<Microsoft.Maui.ApplicationModel.Permissions.ContactsRead>(); break;
                    case Maui.ApplicationModel.PermissionType.Camera: state = await Microsoft.Maui.ApplicationModel.Permissions.RequestAsync<Microsoft.Maui.ApplicationModel.Permissions.Camera>(); break;
                    case Maui.ApplicationModel.PermissionType.CalendarWrite: state = await Microsoft.Maui.ApplicationModel.Permissions.RequestAsync<Microsoft.Maui.ApplicationModel.Permissions.CalendarWrite>(); break;
                    case Maui.ApplicationModel.PermissionType.CalendarRead: state = await Microsoft.Maui.ApplicationModel.Permissions.RequestAsync<Microsoft.Maui.ApplicationModel.Permissions.CalendarRead>(); break;
                    case Maui.ApplicationModel.PermissionType.Battery: state = await Microsoft.Maui.ApplicationModel.Permissions.RequestAsync<Microsoft.Maui.ApplicationModel.Permissions.Battery>(); break;
                    case Maui.ApplicationModel.PermissionType.Vibrate: state = await Microsoft.Maui.ApplicationModel.Permissions.RequestAsync<Microsoft.Maui.ApplicationModel.Permissions.Vibrate>(); break;
                    default:
                        return;
                }

                if (state != PermissionStatus.Granted)
                    return;
            }
        }
    }
}