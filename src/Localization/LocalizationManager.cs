using MetaFrm.Control;
using MetaFrm.Localization;
using System.ComponentModel;

namespace MetaFrm.Maui.Essentials.Localization
{
    /// <summary>
    /// LocalizationNotifier
    /// </summary>
    /// <param name="cultureChanged"></param>
    /// <param name="languageCollector"></param>
    public partial class LocalizationNotifier(ICultureChanged cultureChanged, ILanguageCollector languageCollector) : INotifyPropertyChanged, IActionEvent
    {
        private readonly ICultureChanged CultureChange = cultureChanged;
        private readonly ILanguageCollector LanguageCollector = languageCollector;

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

                    if (!string.IsNullOrEmpty(key))
                        tmps.Remove(key);

                    result = key.Translate(this.CultureChange?.CultureInfo ?? Thread.CurrentThread.CurrentCulture, out successful, [.. tmps]);
                }
                else
                    result = key.Translate(this.CultureChange?.CultureInfo ?? Thread.CurrentThread.CurrentCulture, out successful);

                if (successful != null && successful == false)
                    this.LanguageCollector.Add(key);

                return result;
            }
        }

        /// <summary>
        /// PropertyChanged
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Action
        /// </summary>
        public event MetaFrmEventHandler? Action;

        /// <summary>
        /// ActionEvnt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public object? ActionEvnt(ICore sender, MetaFrmEventArgs e)
        {
            if (e.Action == "CultureChange")
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));

            this.Action?.Invoke(sender, e);

            return null;
        }
    }
}