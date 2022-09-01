using MetaFrm.Extensions;

namespace MetaFrm.Maui.Devices
{
    /// <summary>
    /// Battery
    /// </summary>
    public class Battery : IBattery
    {
        /// <summary>
        /// BatteryChargeLevel
        /// </summary>
        public double BatteryChargeLevel => Microsoft.Maui.Devices.Battery.Default.ChargeLevel;

        /// <summary>
        /// BatteryState
        /// </summary>
        public BatteryState BatteryState => Microsoft.Maui.Devices.Battery.Default.State.EnumParse<BatteryState>();

        /// <summary>
        /// BatteryPowerSource
        /// </summary>
        public BatteryPowerSource BatteryPowerSource => Microsoft.Maui.Devices.Battery.Default.PowerSource.EnumParse<BatteryPowerSource>();

        /// <summary>
        /// EnergySaverStatus
        /// </summary>
        public EnergySaverStatus EnergySaverStatus => Microsoft.Maui.Devices.Battery.Default.EnergySaverStatus.EnumParse<EnergySaverStatus>();

        private BatteryInfoChanged BatteryInfoChanged;

        /// <summary>
        /// BatteryInfoChangedEvent
        /// </summary>
        public event BatteryInfoChanged BatteryInfoChangedEvent
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

        private void Battery_BatteryInfoChanged(object sender, Microsoft.Maui.Devices.BatteryInfoChangedEventArgs e) => BatteryInfoChanged?.Invoke(sender, new BatteryInfoChangedEventArgs(e.ChargeLevel, e.State.EnumParse<BatteryState>(), e.PowerSource.EnumParse<BatteryPowerSource>()));

        private EnergySaverStatusChanged EnergySaverStatusChanged;

        /// <summary>
        /// EnergySaverStatusChangedEvent
        /// </summary>
        public event EnergySaverStatusChanged EnergySaverStatusChangedEvent
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

        private void Battery_EnergySaverStatusChanged(object sender, Microsoft.Maui.Devices.EnergySaverStatusChangedEventArgs e) => EnergySaverStatusChanged?.Invoke(sender, new EnergySaverStatusChangedEventArgs(e.EnergySaverStatus.EnumParse<EnergySaverStatus>()));
    }
}