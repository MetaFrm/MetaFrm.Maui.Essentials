using MetaFrm.Control;
using MetaFrm.Storage;
using System.Globalization;

namespace MetaFrm.Maui.Essentials.Localization
{
    /// <summary>
    /// CultureChanger
    /// </summary>
    /// <param name="cookieStorageService"></param>
    /// <param name="preferences"></param>
    public class CultureChanger(ICookieStorageService? cookieStorageService, Maui.Storage.IPreferences? preferences) : MetaFrm.Localization.CultureChanger(cookieStorageService, preferences)
    {
        /// <summary>
        /// CultureChange
        /// </summary>
        /// <param name="cultureInfo"></param>
        public override void CultureChange(CultureInfo cultureInfo)
        {
            base.CultureChange(cultureInfo);

            if (Factory.NotifyPropertyChanged is IActionEvent action)
                action.ActionEvnt(this, new() { Action = "CultureChange", Value = null });
        }
    }
}