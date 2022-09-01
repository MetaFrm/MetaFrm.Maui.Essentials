using MetaFrm.Extensions;

namespace MetaFrm.Maui.Devices
{
    /// <summary>
    /// DeviceDisplay
    /// </summary>
    public class DeviceDisplay : IDeviceDisplay
    {
        /// <summary>
        /// KeepScreenOn
        /// </summary>
        public bool KeepScreenOn
        {
            get
            {
                return Microsoft.Maui.Devices.DeviceDisplay.Current.KeepScreenOn;
            }
            set
            {
                Microsoft.Maui.Devices.DeviceDisplay.Current.KeepScreenOn = value;
            }
        }

        /// <summary>
        /// MainDisplayInfo
        /// </summary>
        public DisplayInfo MainDisplayInfo => new DisplayInfo(Microsoft.Maui.Devices.DeviceDisplay.Current.MainDisplayInfo.Width
                    , Microsoft.Maui.Devices.DeviceDisplay.Current.MainDisplayInfo.Height
                    , Microsoft.Maui.Devices.DeviceDisplay.Current.MainDisplayInfo.Density
                    , Microsoft.Maui.Devices.DeviceDisplay.Current.MainDisplayInfo.Orientation.EnumParse<DisplayOrientation>()
                    , Microsoft.Maui.Devices.DeviceDisplay.Current.MainDisplayInfo.Rotation.EnumParse<DisplayRotation>()
                    , Microsoft.Maui.Devices.DeviceDisplay.Current.MainDisplayInfo.RefreshRate);

        private MainDisplayInfoChanged MainDisplayInfoChanged;

        /// <summary>
        /// MainDisplayInfoChangedEvent
        /// </summary>
        public event MainDisplayInfoChanged MainDisplayInfoChangedEvent
        {
            add
            {
                this.MainDisplayInfoChanged += value;

                try
                {
                    try
                    {
                        Microsoft.Maui.Devices.DeviceDisplay.Current.MainDisplayInfoChanged -= MainDisplayInfo_MainDisplayInfoChanged;
                    }
                    catch (Exception)
                    {
                    }
                    Microsoft.Maui.Devices.DeviceDisplay.Current.MainDisplayInfoChanged += MainDisplayInfo_MainDisplayInfoChanged;
                }
                catch (Exception)
                {
                }
            }
            remove
            {
                try
                {
                    Microsoft.Maui.Devices.DeviceDisplay.Current.MainDisplayInfoChanged -= MainDisplayInfo_MainDisplayInfoChanged;
                }
                catch (Exception)
                {
                }

                this.MainDisplayInfoChanged -= value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainDisplayInfo_MainDisplayInfoChanged(object sender, Microsoft.Maui.Devices.DisplayInfoChangedEventArgs e) => MainDisplayInfoChanged?.Invoke(sender, new DisplayInfoChangedEventArgs(new DisplayInfo(e.DisplayInfo.Width, e.DisplayInfo.Height, e.DisplayInfo.Density
                                                                                                , e.DisplayInfo.Orientation.EnumParse<DisplayOrientation>()
                                                                                                , e.DisplayInfo.Rotation.EnumParse<DisplayRotation>()
                                                                                                , e.DisplayInfo.RefreshRate)));
    }
}