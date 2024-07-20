using MetaFrm.Localization;
using MetaFrm.Storage;
using System.ComponentModel;
using System.Globalization;

namespace MetaFrm.Maui.Essentials.Localization
{
    /// <summary>
    /// LocalizationManager
    /// </summary>
    public class LocalizationManager : INotifyPropertyChanged, ICultureChanged
    {
        private static CultureInfo CurrentCulture = Thread.CurrentThread.CurrentCulture; //CultureInfo.CurrentCulture;
        private static ICookieStorageService? CookieStorageService;
        private static LocalizationManager? localizationManager;

        /// <summary>
        /// LocalizationManager
        /// </summary>
        public LocalizationManager(ICookieStorageService? cookieStorageService)
        {
            CookieStorageService = cookieStorageService;

            localizationManager ??= this;

            GetCultureInfo();
        }
        private static async void GetCultureInfo()
        {
            if (CookieStorageService == null)
                CurrentCulture = Thread.CurrentThread.CurrentCulture;
            else
            {
                try
                {
                    string? tmp = await CookieStorageService.GetItemAsStringAsync(".AspNetCore.Culture");//c=es-MX|uic=es-MX

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
        private static async void SetCultureInfo(CultureInfo cultureInfo)
        {
            if (CookieStorageService != null)
            {
                try
                {
                    await CookieStorageService.SetItemAsStringAsync(".AspNetCore.Culture", $"c={cultureInfo.Name}|uic={cultureInfo.Name}", 365);//c=es-MX|uic=es-MX
                }
                catch (Exception)
                {
                }
            }

            CurrentCulture = cultureInfo;
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
                    List<string> tmps = key.Split("^").ToList();

                    key = tmps.FirstOrDefault() ?? "";

                    if (!key.IsNullOrEmpty())
                        tmps.Remove(key);

                    result = key.Translate(CurrentCulture, out successful, tmps.ToArray());
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
        public static LocalizationManager Instance { get; } = localizationManager ?? new(CookieStorageService);

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
            LocalizationManager.SetCultureInfo(cultureInfo);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));

            if (localizationManager != null && !this.Equals(localizationManager))
                localizationManager.CultureChange(cultureInfo);
        }

        /// <summary>
        /// CultureInfo
        /// </summary>
        public CultureInfo CultureInfo => CurrentCulture;
    }
}