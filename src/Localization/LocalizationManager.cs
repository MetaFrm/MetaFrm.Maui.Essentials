using System.ComponentModel;
using System.Globalization;

namespace MetaFrm.Maui.Localization
{
    /// <summary>
    /// LocalizationManager
    /// </summary>
    public class LocalizationManager : INotifyPropertyChanged
    {
        private LocalizationManager()
        {
            if (Preferences.Get("Factory.CultureInfo", null).IsNullOrEmpty())
                Preferences.Set("Factory.CultureInfo", CultureInfo.CurrentCulture.Name);

            //Factory.CultureInfo = new("en-us");
            Factory.CultureInfo = new(Preferences.Get("Factory.CultureInfo", null));
        }

        /// <summary>
        /// Translate
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public object this[string key]
        {
            get
            {
                if (key.Contains('^'))
                {
                    List<string> tmps = key.Split("^").ToList();

                    key = tmps.FirstOrDefault();

                    tmps.Remove(key);

                    return key.Translate(tmps.ToArray());
                }
                else
                    return key.Translate();
            }
        }

        /// <summary>
        /// Instance
        /// </summary>
        public static LocalizationManager Instance { get; } = new();

        /// <summary>
        /// PropertyChanged
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// SetCulture
        /// </summary>
        /// <param name="culture"></param>
        public void SetCulture(CultureInfo culture)
        {
            Factory.CultureInfo = culture;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            Preferences.Set("Factory.CultureInfo", Factory.CultureInfo.Name);
        }
    }
}