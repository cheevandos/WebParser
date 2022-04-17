using HtmlAgilityPack;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace MainLogic
{
    public static class Parser
    {
        public static async Task<string> GetWebpageContent(string url)
        {
            using (HttpClient httpClient = new HttpClient() { Timeout = TimeSpan.FromSeconds(30) })
            {
                httpClient.DefaultRequestHeaders.Add(
                    "accept", 
                    "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9"
                );

                httpClient.DefaultRequestHeaders.Add(
                    "user-agent", 
                    "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/100.0.4896.88 Safari/537.36"
                );

                try
                {
                    HttpResponseMessage httpResponse = await httpClient.GetAsync(url).ConfigureAwait(false);

                    if (!httpResponse.IsSuccessStatusCode)
                    {
                        throw new Exception($"Http request error. Status code: {httpResponse.StatusCode}");
                    }

                    string webPageContent = await httpResponse.Content.ReadAsStringAsync();

                    if (string.IsNullOrWhiteSpace(webPageContent))
                    {
                        throw new Exception("Empty web page content");
                    }

                    return webPageContent;
                }
                catch (Exception ex)
                {
                    string originExceptionMessage = ex.Message;
                    throw new Exception($"Error: {originExceptionMessage}");
                }
            }
        }

        public static string ModifyHtmlContent(string content)
        {
            try
            {
                HtmlDocument sourceHtmlDoc = new HtmlDocument();
                sourceHtmlDoc.LoadHtml(content);

                sourceHtmlDoc.DocumentNode.SelectNodes("//");


                return string.Empty;
            }
            catch (Exception ex)
            {
                throw new Exception($"Html parsing error: {ex.Message}");
            }
        }
    }
}
