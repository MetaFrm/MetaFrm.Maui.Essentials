using MetaFrm.Extensions;

namespace MetaFrm.Maui.Essentials.Networking
{
    /// <summary>
    /// Connectivity
    /// </summary>
    public class Connectivity : Maui.Networking.IConnectivity
    {
        /// <summary>
        /// NetworkAccess
        /// </summary>
        public Maui.Networking.NetworkAccess NetworkAccess => Microsoft.Maui.Networking.Connectivity.Current.NetworkAccess.EnumParse<Maui.Networking.NetworkAccess>();

        /// <summary>
        /// ConnectionProfiles
        /// </summary>
        public IEnumerable<Maui.Networking.ConnectionProfile> ConnectionProfiles
        {
            get
            {
                IEnumerable<ConnectionProfile> profilesOrg = Microsoft.Maui.Networking.Connectivity.Current.ConnectionProfiles;

                List<Maui.Networking.ConnectionProfile> profiles = [];

                foreach (ConnectionProfile profile in profilesOrg)
                    profiles.Add(profile.EnumParse<Maui.Networking.ConnectionProfile>());

                return profiles;
            }
        }

        private Maui.Networking.ConnectivityChanged? ConnectivityChanged;

        /// <summary>
        /// ConnectivityChangedEvent
        /// </summary>
        public event Maui.Networking.ConnectivityChanged ConnectivityChangedEvent
        {
            add
            {
                this.ConnectivityChanged += value;

                try
                {
                    try
                    {
                        Microsoft.Maui.Networking.Connectivity.Current.ConnectivityChanged -= Connectivity_ConnectivityChanged;
                    }
                    catch (Exception)
                    {
                    }
                    Microsoft.Maui.Networking.Connectivity.Current.ConnectivityChanged += Connectivity_ConnectivityChanged;
                }
                catch (Exception)
                {
                }
            }
            remove
            {
                try
                {
                    Microsoft.Maui.Networking.Connectivity.Current.ConnectivityChanged -= Connectivity_ConnectivityChanged;
                }
                catch (Exception)
                {
                }

                this.ConnectivityChanged -= value;
            }
        }

        private void Connectivity_ConnectivityChanged(object? sender, ConnectivityChangedEventArgs e)
        {
            IEnumerable<ConnectionProfile> profilesOrg = e.ConnectionProfiles;

            List<Maui.Networking.ConnectionProfile> profiles = [];

            foreach (ConnectionProfile profile in profilesOrg)
                profiles.Add(profile.EnumParse<Maui.Networking.ConnectionProfile>());

            this.ConnectivityChanged?.Invoke(sender, new Maui.Networking.ConnectivityChangedEventArgs(e.NetworkAccess.EnumParse<Maui.Networking.NetworkAccess>(), profiles));

            if (PhoneDialer.Default.IsSupported)
                PhoneDialer.Default.Open("000-000-0000");
        }
    }
}