using Microsoft.Extensions.Localization;
using System.Globalization;

namespace MetaFrm.Maui.Essentials.Platforms
{
    /// <summary>
    /// ExtensionsCheckForUpdate
    /// </summary>
    public static class ExtensionsCheckForUpdate
    {
        /// <summary>
        /// CheckForUpdate
        /// </summary>
        /// <param name="page"></param>
        /// <param name="stringLocalizer"></param>
        public static async void CheckForUpdate(this ContentPage page, IStringLocalizer stringLocalizer)
        {
            string publishedVersion = "";
            string publishedUrl = "";

            publishedVersion = Factory.ProjectService.Attribute.SingleOrDefault(x => x.AttributeName == "PublishedVersionAppStore")?.AttributeValue ?? "";
            publishedUrl = Factory.ProjectService.Attribute.SingleOrDefault(x => x.AttributeName == "PublishedAppStoreUrl")?.AttributeValue ?? "";

            string state = (CultureInfo.CurrentCulture.Name.Contains('-') ? CultureInfo.CurrentCulture.Name.Split('-')[1] : CultureInfo.CurrentCulture.Name).ToLower();//"ko-KR"
            publishedUrl = string.Format(publishedUrl, state);

            if (!publishedVersion.IsNullOrEmpty() && publishedVersion != AppInfo.Current.VersionString)
            {
                bool update = await page.DisplayAlert(
                    stringLocalizer["업데이트 안내"],
                    stringLocalizer["새로운 버전이 있습니다. 업데이트 하시겠습니까?"],
                    stringLocalizer["업데이트"],
                    stringLocalizer["나중에"]
                );

                if (update)
                    await Launcher.OpenAsync(publishedUrl);
            }
        }
    }
}