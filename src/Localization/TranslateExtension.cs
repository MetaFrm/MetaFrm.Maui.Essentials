namespace MetaFrm.Maui.Essentials.Localization
{
    /// <summary>
    /// TranslateExtension
    /// </summary>
    [AcceptEmptyServiceProvider]
    [ContentProperty(nameof(Text)), QueryProperty(nameof(Text), nameof(Args))]
    public class TranslateExtension : IMarkupExtension<BindingBase>
    {
        /// <summary>
        /// Text
        /// </summary>
        public string? Text { get; set; }

        /// <summary>
        /// Args
        /// </summary>
        public string? Args { get; set; }

        /// <summary>
        /// ProvideValue
        /// </summary>
        /// <param name="serviceProvider"></param>
        /// <returns></returns>
        public BindingBase ProvideValue(IServiceProvider serviceProvider)
        {
            if (string.IsNullOrEmpty(Args))
                return new Binding
                {
                    Mode = BindingMode.OneWay,
                    Path = $"[{Text}]",
                    Source = Factory.NotifyPropertyChanged
                };
            else
                return new Binding
                {
                    Mode = BindingMode.OneWay,
                    Path = $"[{Text}^{Args}]",
                    Source = Factory.NotifyPropertyChanged
                };
        }

        object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider)
        {
            return this.ProvideValue(serviceProvider);
        }
    }
}