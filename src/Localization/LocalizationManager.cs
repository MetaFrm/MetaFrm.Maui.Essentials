using MetaFrm.Localization;
using System.ComponentModel;
using System.Globalization;

namespace MetaFrm.Maui.Essentials.Localization
{
    /// <summary>
    /// LocalizationManager
    /// </summary>
    public class LocalizationManager : INotifyPropertyChanged, ICultureChanged
    {
        private const string KeyValue = ".AspNetCore.Culture";
        private static CultureInfo CurrentCulture = Thread.CurrentThread.CurrentCulture; //CultureInfo.CurrentCulture;
        private static Maui.Storage.IPreferences? Preferences;
        private static LocalizationManager? LocalizationManagerInstance;

        /// <summary>
        /// LocalizationManager
        /// </summary>
        public LocalizationManager(Maui.Storage.IPreferences? preferences)
        {
            Preferences = preferences;

            LocalizationManagerInstance ??= this;

            GetCultureInfo();
        }
        private static void GetCultureInfo()
        {
            if (Preferences == null)
                CurrentCulture = Thread.CurrentThread.CurrentCulture;
            else
            {
                try
                {
                    string? tmp = Preferences.Get(KeyValue, "");//c=es-MX|uic=es-MX

                    if (tmp == null)
                        CurrentCulture = Thread.CurrentThread.CurrentCulture;
                    else
                    {
                        if (tmp.Contains('|'))
                            tmp = tmp.Split('|')[0];

                        if (tmp.Contains("c=") && tmp.Contains('-'))
                            CurrentCulture = new(tmp.Split('=')[1]);
                        else
                            CurrentCulture = Thread.CurrentThread.CurrentCulture;
                    }
                }
                catch (Exception)
                {
                    CurrentCulture = Thread.CurrentThread.CurrentCulture;
                }
            }
        }
        private static void SetCultureInfo(CultureInfo cultureInfo)
        {
            CurrentCulture = cultureInfo;

            if (Preferences != null)
            {
                try
                {
                    Preferences.Set(KeyValue, $"c={cultureInfo.Name}|uic={cultureInfo.Name}");//c=es-MX|uic=es-MX
                }
                catch (Exception)
                {
                }
            }
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
                string result;
                bool? successful;

                if (key.Contains('^'))
                {
                    List<string> tmps = [.. key.Split("^")];

                    key = tmps.FirstOrDefault() ?? "";

                    if (!key.IsNullOrEmpty())
                        tmps.Remove(key);

                    result = key.Translate(CurrentCulture, out successful, [.. tmps]);
                }
                else
                    result = key.Translate(CurrentCulture, out successful);

                if (successful != null && successful == false)
                    MetaFrm.Razor.Essentials.Localization.LocalizationManager.Instance.DictionaryCollectionInsert(key, CurrentCulture);

                return result;
            }
        }

        /// <summary>
        /// Instance
        /// </summary>
        public static LocalizationManager Instance
        {
            get
            {
                LocalizationManagerInstance ??= new(Preferences);
                return LocalizationManagerInstance;
            }
        }

        /// <summary>
        /// PropertyChanged
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// CultureChange
        /// </summary>
        /// <param name="cultureInfo"></param>
        public void CultureChange(CultureInfo cultureInfo)
        {
            SetCultureInfo(cultureInfo);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));

            if (LocalizationManagerInstance != null && !this.Equals(LocalizationManagerInstance))
                LocalizationManagerInstance.CultureChange(cultureInfo);
        }

        /// <summary>
        /// CultureInfo
        /// </summary>
        public CultureInfo CultureInfo => CurrentCulture;
    }
}