using Microsoft.Extensions.Localization;

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

            publishedVersion = Factory.ProjectService.Attribute.SingleOrDefault(x => x.AttributeName == "PublishedVersionGooglePlay")?.AttributeValue ?? "";
            publishedUrl = Factory.ProjectService.Attribute.SingleOrDefault(x => x.AttributeName == "PublishedGooglePlayUrl")?.AttributeValue ?? "";

            publishedUrl = string.Format(publishedUrl, AppInfo.Current.PackageName);

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