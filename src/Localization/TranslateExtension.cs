namespace MetaFrm.Maui.Localization
{
    /// <summary>
    /// TranslateExtension
    /// </summary>
    [ContentProperty(nameof(Text)), QueryProperty(nameof(Text), nameof(Args))]
    public class TranslateExtension : IMarkupExtension<BindingBase>
    {
        /// <summary>
        /// Text
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Args
        /// </summary>
        public string Args { get; set; }

        /// <summary>
        /// ProvideValue
        /// </summary>
        /// <param name="serviceProvider"></param>
        /// <returns></returns>
        public BindingBase ProvideValue(IServiceProvider serviceProvider)
        {
            if (Args.IsNullOrEmpty())
                return new Binding
                {
                    Mode = BindingMode.OneWay,
                    Path = $"[{Text}]",
                    Source = LocalizationManager.Instance
                };
            else
                return new Binding
                {
                    Mode = BindingMode.OneWay,
                    Path = $"[{Text}^{Args}]",
                    Source = LocalizationManager.Instance
                };
        }

        object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider)
        {
            return ProvideValue(serviceProvider);
        }
    }
}