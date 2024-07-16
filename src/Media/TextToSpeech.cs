namespace MetaFrm.Maui.Essentials.Media
{
    /// <summary>
    /// TextToSpeech
    /// </summary>
    public class TextToSpeech : Maui.Media.ITextToSpeech
    {
        /// <summary>
        /// GetLocalesAsync
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Maui.Media.Locale>> GetLocalesAsync()
        {
            IEnumerable<Locale> localesOrg = await Microsoft.Maui.Media.TextToSpeech.Default.GetLocalesAsync();
            List<Maui.Media.Locale> locales = new();

            foreach (Locale locale in localesOrg)
                locales.Add(new Maui.Media.Locale { Language = locale.Language, Country = locale.Country, Name = locale.Name, Id = locale.Id });

            return locales;
        }

        /// <summary>
        /// SpeakAsync
        /// </summary>
        /// <param name="text"></param>
        /// <param name="options"></param>
        /// <param name="cancelToken"></param>
        /// <returns></returns>
        public async Task SpeakAsync(string text, Maui.Media.SpeechOptions? options = null, CancellationToken cancelToken = default)
        {
            Locale? locale = null;

            if (options != null && options.Locale != null)
            {
                IEnumerable<Locale> localesOrg = await Microsoft.Maui.Media.TextToSpeech.Default.GetLocalesAsync();
                locale = localesOrg.Where(x => x.Id == options.Locale.Id).FirstOrDefault();
            }

            await Microsoft.Maui.Media.TextToSpeech.Default.SpeakAsync(text, (options == null ? null : new SpeechOptions { Locale = locale, Pitch = options.Pitch, Volume = options.Volume }), cancelToken);
        }
    }
}