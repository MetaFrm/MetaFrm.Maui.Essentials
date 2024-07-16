using MetaFrm.Extensions;

namespace MetaFrm.Maui.Essentials.Devices
{
    /// <summary>
    /// DeviceDisplay
    /// </summary>
    public class DeviceDisplay : Maui.Devices.IDeviceDisplay
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
        public Maui.Devices.DisplayInfo MainDisplayInfo => new(Microsoft.Maui.Devices.DeviceDisplay.Current.MainDisplayInfo.Width
                    , Microsoft.Maui.Devices.DeviceDisplay.Current.MainDisplayInfo.Height
                    , Microsoft.Maui.Devices.DeviceDisplay.Current.MainDisplayInfo.Density
                    , Microsoft.Maui.Devices.DeviceDisplay.Current.MainDisplayInfo.Orientation.EnumParse<Maui.Devices.DisplayOrientation>()
                    , Microsoft.Maui.Devices.DeviceDisplay.Current.MainDisplayInfo.Rotation.EnumParse<Maui.Devices.DisplayRotation>()
                    , Microsoft.Maui.Devices.DeviceDisplay.Current.MainDisplayInfo.RefreshRate);

        private Maui.Devices.MainDisplayInfoChanged? MainDisplayInfoChanged;

        /// <summary>
        /// MainDisplayInfoChangedEvent
        /// </summary>
        public event Maui.Devices.MainDisplayInfoChanged MainDisplayInfoChangedEvent
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
        private void MainDisplayInfo_MainDisplayInfoChanged(object? sender, DisplayInfoChangedEventArgs e) => this.MainDisplayInfoChanged?.Invoke(sender, new Maui.Devices.DisplayInfoChangedEventArgs(new Maui.Devices.DisplayInfo(e.DisplayInfo.Width, e.DisplayInfo.Height, e.DisplayInfo.Density
                                                                                                , e.DisplayInfo.Orientation.EnumParse<Maui.Devices.DisplayOrientation>()
                                                                                                , e.DisplayInfo.Rotation.EnumParse<Maui.Devices.DisplayRotation>()
                                                                                                , e.DisplayInfo.RefreshRate)));
    }
}