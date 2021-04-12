using System;

namespace RSSFeedCreator.Helpers
{
    public static class UrlValidator
    {
        public static bool ValidateUrl(string url)
        {
            Uri uriResult;
            bool valid = Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);

            return valid;
        }
    }
}
