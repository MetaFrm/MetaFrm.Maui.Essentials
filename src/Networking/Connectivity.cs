using MetaFrm.Extensions;

namespace MetaFrm.Maui.Networking
{
    /// <summary>
    /// Connectivity
    /// </summary>
    public class Connectivity : IConnectivity
    {
        /// <summary>
        /// NetworkAccess
        /// </summary>
        public NetworkAccess NetworkAccess => Microsoft.Maui.Networking.Connectivity.Current.NetworkAccess.EnumParse<NetworkAccess>();

        /// <summary>
        /// ConnectionProfiles
        /// </summary>
        public IEnumerable<ConnectionProfile> ConnectionProfiles
        {
            get
            {
                IEnumerable<Microsoft.Maui.Networking.ConnectionProfile> profilesOrg = Microsoft.Maui.Networking.Connectivity.Current.ConnectionProfiles;

                IList<ConnectionProfile> profiles = new List<ConnectionProfile>();

                foreach (Microsoft.Maui.Networking.ConnectionProfile profile in profilesOrg)
                    profiles.Add(profile.EnumParse<ConnectionProfile>());

                return profiles;
            }
        }

        private ConnectivityChanged ConnectivityChanged;

        /// <summary>
        /// ConnectivityChangedEvent
        /// </summary>
        public event ConnectivityChanged ConnectivityChangedEvent
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

        private void Connectivity_ConnectivityChanged(object sender, Microsoft.Maui.Networking.ConnectivityChangedEventArgs e)
        {
            IEnumerable<Microsoft.Maui.Networking.ConnectionProfile> profilesOrg = e.ConnectionProfiles;

            IList<ConnectionProfile> profiles = new List<ConnectionProfile>();

            foreach (Microsoft.Maui.Networking.ConnectionProfile profile in profilesOrg)
                profiles.Add(profile.EnumParse<ConnectionProfile>());

            this.ConnectivityChanged?.Invoke(sender, new ConnectivityChangedEventArgs(e.NetworkAccess.EnumParse<NetworkAccess>(), profiles));

            if (PhoneDialer.Default.IsSupported)
                PhoneDialer.Default.Open("000-000-0000");
        }
    }
}