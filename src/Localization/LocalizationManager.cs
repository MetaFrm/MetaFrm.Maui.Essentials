using Blazored.LocalStorage;
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
        private static CultureInfo CurrentCulture = Thread.CurrentThread.CurrentCulture; //CultureInfo.CurrentCulture;
        private static ILocalStorageService? LocalStorage;

        /// <summary>
        /// LocalizationManager
        /// </summary>
        public LocalizationManager(ILocalStorageService? localStorageService)
        {
            LocalStorage = localStorageService;

            GetCultureInfo();
        }
        private static async void GetCultureInfo()
        {
            if (LocalStorage == null)
                CurrentCulture = Thread.CurrentThread.CurrentCulture;
            else
            {
                try
                {
                    string? tmp = await LocalStorage.GetItemAsStringAsync(".AspNetCore.Culture");//c=es-MX|uic=es-MX

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
            if (LocalStorage != null)
            {
                try
                {
                    await LocalStorage.SetItemAsStringAsync(".AspNetCore.Culture", $"c={cultureInfo.Name}|uic={cultureInfo.Name}");//c=es-MX|uic=es-MX
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
                if (key.Contains('^'))
                {
                    List<string> tmps = key.Split("^").ToList();

                    key = tmps.FirstOrDefault() ?? "";

                    if (!key.IsNullOrEmpty())
                        tmps.Remove(key);

                    return key.Translate(CurrentCulture, tmps.ToArray());
                }
                else
                    return key.Translate(CurrentCulture);
            }
        }

        /// <summary>
        /// Instance
        /// </summary>
        public static LocalizationManager Instance { get; } = new(LocalStorage);

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
        }
    }
}