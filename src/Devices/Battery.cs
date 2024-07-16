using MetaFrm.Extensions;

namespace MetaFrm.Maui.Essentials.Devices
{
    /// <summary>
    /// Battery
    /// </summary>
    public class Battery : Maui.Devices.IBattery
    {
        /// <summary>
        /// BatteryChargeLevel
        /// </summary>
        public double BatteryChargeLevel => Microsoft.Maui.Devices.Battery.Default.ChargeLevel;

        /// <summary>
        /// BatteryState
        /// </summary>
        public Maui.Devices.BatteryState BatteryState => Microsoft.Maui.Devices.Battery.Default.State.EnumParse<Maui.Devices.BatteryState>();

        /// <summary>
        /// BatteryPowerSource
        /// </summary>
        public Maui.Devices.BatteryPowerSource BatteryPowerSource => Microsoft.Maui.Devices.Battery.Default.PowerSource.EnumParse<Maui.Devices.BatteryPowerSource>();

        /// <summary>
        /// EnergySaverStatus
        /// </summary>
        public Maui.Devices.EnergySaverStatus EnergySaverStatus => Microsoft.Maui.Devices.Battery.Default.EnergySaverStatus.EnumParse<Maui.Devices.EnergySaverStatus>();

        private Maui.Devices.BatteryInfoChanged? BatteryInfoChanged;

        /// <summary>
        /// BatteryInfoChangedEvent
        /// </summary>
        public event Maui.Devices.BatteryInfoChanged BatteryInfoChangedEvent
        {
            add
            {
                this.BatteryInfoChanged += value;

                try
                {
                    try
                    {
                        Microsoft.Maui.Devices.Battery.Default.BatteryInfoChanged -= Battery_BatteryInfoChanged;
                    }
                    catch (Exception)
                    {
                    }
                    Microsoft.Maui.Devices.Battery.Default.BatteryInfoChanged += Battery_BatteryInfoChanged;
                }
                catch (Exception)
                {
                }
            }
            remove
            {
                try
                {
                    Microsoft.Maui.Devices.Battery.Default.BatteryInfoChanged -= Battery_BatteryInfoChanged;
                }
                catch (Exception)
                {
                }

                this.BatteryInfoChanged -= value;
            }
        }

        private void Battery_BatteryInfoChanged(object? sender, BatteryInfoChangedEventArgs e) => BatteryInfoChanged?.Invoke(sender, new Maui.Devices.BatteryInfoChangedEventArgs(e.ChargeLevel, e.State.EnumParse<Maui.Devices.BatteryState>(), e.PowerSource.EnumParse<Maui.Devices.BatteryPowerSource>()));

        private Maui.Devices.EnergySaverStatusChanged? EnergySaverStatusChanged;

        /// <summary>
        /// EnergySaverStatusChangedEvent
        /// </summary>
        public event Maui.Devices.EnergySaverStatusChanged EnergySaverStatusChangedEvent
        {
            add
            {
                this.EnergySaverStatusChanged += value;

                try
                {
                    try
                    {
                        Microsoft.Maui.Devices.Battery.Default.EnergySaverStatusChanged -= Battery_EnergySaverStatusChanged;
                    }
                    catch (Exception)
                    {
                    }
                    Microsoft.Maui.Devices.Battery.Default.EnergySaverStatusChanged += Battery_EnergySaverStatusChanged;
                }
                catch (Exception)
                {
                }
            }
            remove
            {
                try
                {
                    Microsoft.Maui.Devices.Battery.Default.EnergySaverStatusChanged -= Battery_EnergySaverStatusChanged;
                }
                catch (Exception)
                {
                }

                this.EnergySaverStatusChanged -= value;
            }
        }

        private void Battery_EnergySaverStatusChanged(object? sender, EnergySaverStatusChangedEventArgs e) => this.EnergySaverStatusChanged?.Invoke(sender, new Maui.Devices.EnergySaverStatusChangedEventArgs(e.EnergySaverStatus.EnumParse<Maui.Devices.EnergySaverStatus>()));
    }
}