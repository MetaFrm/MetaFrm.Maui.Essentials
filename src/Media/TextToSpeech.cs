namespace MetaFrm.Maui.Media
{
    /// <summary>
    /// TextToSpeech
    /// </summary>
    public class TextToSpeech : ITextToSpeech
    {
        /// <summary>
        /// GetLocalesAsync
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Locale>> GetLocalesAsync()
        {
            IEnumerable<Microsoft.Maui.Media.Locale> localesOrg = await Microsoft.Maui.Media.TextToSpeech.Default.GetLocalesAsync();
            IList<Locale> locales = new List<Locale>();

            foreach (Microsoft.Maui.Media.Locale locale in localesOrg)
                locales.Add(new Locale { Language = locale.Language, Country = locale.Country, Name = locale.Name, Id = locale.Id });

            return locales;
        }

        /// <summary>
        /// SpeakAsync
        /// </summary>
        /// <param name="text"></param>
        /// <param name="options"></param>
        /// <param name="cancelToken"></param>
        /// <returns></returns>
        public async Task SpeakAsync(string text, SpeechOptions options = null, CancellationToken cancelToken = default)
        {
            Microsoft.Maui.Media.Locale locale;

            locale = null;
            if (options != null && options.Locale != null)
            {
                IEnumerable<Microsoft.Maui.Media.Locale> localesOrg = await Microsoft.Maui.Media.TextToSpeech.Default.GetLocalesAsync();
                locale = localesOrg.Where(x => x.Id == options.Locale.Id).FirstOrDefault();
            }

            await Microsoft.Maui.Media.TextToSpeech.Default.SpeakAsync(text, (options == null ? null : new Microsoft.Maui.Media.SpeechOptions { Locale = locale, Pitch = options.Pitch, Volume = options.Volume }), cancelToken);
        }
    }
}