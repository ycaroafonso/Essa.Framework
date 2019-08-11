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
        protected HttpClient Http { get; set; }

        readonly string _controllerUrl;
        HttpResponseMessage _response;


        public bool IsSuccessStatusCode => _response.IsSuccessStatusCode;



        public GenericRest(string servidor, string controllerUrl, HttpClient http)
        {
            _controllerUrl = controllerUrl;

            Http = http;

            _url = $"{servidor}{_controllerUrl}";
            //  Http.BaseAddress = new Uri($"{value}/api/" + _controllerUrl);
        }

        string _url = "";
    

        protected async Task GetOneAsync(string resource)
        {
            try
            {
                Http.DefaultRequestHeaders.Accept.Clear();
                Http.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                _response = await Http.GetAsync(resource);
            }
            catch (HttpRequestException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        protected async Task<T> GetOne<T>(string path)
        {
            try
            {
                Http.DefaultRequestHeaders.Accept.Clear();
                Http.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                _response = await Http.GetAsync(_url + path);

                if (IsSuccessStatusCode)
                {
                    var content = await _response.Content.ReadAsStringAsync();
                    return await Task.Run(() => JsonConvert.DeserializeObject<T>(content)).ConfigureAwait(false);
                }

                return await Task.Run(() => JsonConvert.DeserializeObject<T>("")).ConfigureAwait(false);
            }
            catch (HttpRequestException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {

                throw;
            }
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
                _response = await Http.PostAsync(_url + path, content);

                if (IsSuccessStatusCode)
                {
                    var json = await _response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    var res = JsonConvert.DeserializeObject<T>(json);
                    return res;
                }
                throw new Exception();
            }
            catch (DuplicateWaitObjectException exD)
            {
                throw exD;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }




        protected MultipartFormDataContent ContentMultiPart { get; set; }

        protected async Task<T> Post<T, TSend>(string path, byte[] upfilebytes, string nomeparametro, string nomearquivo, TSend obj)
            where T : class
        {
            if (ContentMultiPart == null)
                ContentMultiPart = new MultipartFormDataContent();

            ContentMultiPart.Add(new ByteArrayContent(upfilebytes), nomeparametro, nomearquivo);
            ContentMultiPart.Add(new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json"));

            return await PostMultipart<T>(path);
        }


        protected async Task<T> PostMultipart<T>(string path)
            where T : class
        {
            _response = await Http.PostAsync(path, ContentMultiPart);

            if (IsSuccessStatusCode)
            {
                var json = await _response.Content.ReadAsStringAsync();
                return await Task.Run(() => json.ToObject<T>()).ConfigureAwait(false);
            }

            return await Task.Run(() => "".ToObject<T>()).ConfigureAwait(false);
        }

    }
}
