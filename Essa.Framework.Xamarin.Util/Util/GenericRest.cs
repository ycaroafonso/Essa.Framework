namespace Essa.Framework.XamarinUtil.Util
{
    using Essa.Framework.XamarinUtil.Extensions;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Threading.Tasks;


    public class GenericRest
    {
        protected string BaseUrl { get; set; }
        protected HttpClient Http { get; set; }

        public GenericRest(string baseUrl, HttpClient http)
        {
            BaseUrl = baseUrl;
            Http = http;
        }


        protected async Task<T> GetOne<T>(string resource)
        {
            Http.DefaultRequestHeaders.Accept.Clear();
            Http.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = Http.GetAsync(FromUrl(BaseUrl, resource)).Result;
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return await Task.Run(() => JsonConvert.DeserializeObject<T>(content)).ConfigureAwait(false);
            }

            return await Task.Run(() => JsonConvert.DeserializeObject<T>("")).ConfigureAwait(false);
        }

        protected async Task<IEnumerable<T>> Get<T>(string resource)
        {
            return await GetOne<IEnumerable<T>>(resource);
        }

        protected async Task<T> Post<T>(string path, object obj)
        {
            try
            {
                HttpContent content = new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json");
                var response = await Http.PostAsync(FromUrl(BaseUrl, path), content);
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    var res = JsonConvert.DeserializeObject<T>(json);
                    return res;
                }
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        protected async Task<T> Post<T>(string path, byte[] upfilebytes, string nomeparametro, string nomearquivo, object obj = null)
            where T : class
        {
            MultipartFormDataContent content = new MultipartFormDataContent();

            content.Add(new ByteArrayContent(upfilebytes), nomeparametro, nomearquivo);

            if (obj != null)
                content.Add(new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json"));

            var response = await Http.PostAsync(FromUrl(BaseUrl, path), content);

            if (response.IsSuccessStatusCode)
            {
                var json = response.Content.ReadAsStringAsync();
                return StringExtension.ToObject<T>(json.Result);
            }
            throw new NotImplementedException();
        }


        protected async Task<bool> Post(string path, byte[] upfilebytes, string nomeparametro, string nomearquivo, object obj = null)
        {
            MultipartFormDataContent content = new MultipartFormDataContent();

            content.Add(new ByteArrayContent(upfilebytes), nomeparametro, nomearquivo);

            if (obj != null)
                content.Add(new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json"));

            return (await Http.PostAsync(FromUrl(BaseUrl, path), content)).IsSuccessStatusCode;
        }

        private string FromUrl(string baseUrl, string resource)
        {
            return string.Concat(baseUrl, resource);
        }
    }
}
