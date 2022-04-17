using System.Text.RegularExpressions;

namespace MainLogic
{
    public static class UrlHelper
    {
        public static bool UrlIsCorrect(string url)
        {
            string urlPattern = 
                @"(((http|https):\/\/)|(\/)|(..\/))(\w+:{0,1}\w*@)?(\S+)(:[0-9]+)?(\/|\/([\w#!:.?+=&%@!\-\/]))?";

            return Regex.IsMatch(url, urlPattern);
        }
    }
}
