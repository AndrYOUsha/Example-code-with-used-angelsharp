using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using AngleSharp.Dom.Html;
using ParserAutoZone54.Core.Interfaces;

namespace ParserAutoZone54.Core.AutoZone54
{
    class HtmlLoader 
    {
        readonly HttpClient client;
        readonly string url;
        
        public HtmlLoader(IParserSettings settings)
        {
            client = new HttpClient();
            url = $"{settings.BaseUrl}/{settings.Prefix}/";
        }

        public async Task<string> GetSource()
        {
            var responce = await client.GetAsync(url);
            string source = null;

            if(responce != null && responce.StatusCode == System.Net.HttpStatusCode.OK)
            {
                source = await responce.Content.ReadAsStringAsync();
            }

            return source;
        }
    }
}
