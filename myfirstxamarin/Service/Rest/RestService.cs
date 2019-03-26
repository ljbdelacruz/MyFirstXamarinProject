using System;
using System.Net.Http;
using System.Threading.Tasks;
using myfirstxamarin.Model;
using myfirstxamarin.Config;
using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;

namespace myfirstxamarin.Service.Rest
{
    public class RestService
    {
        public HttpClient client;
        public DeviceSettings dSettings;
        public RestService()
        {
            client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application\\x-www-form-urlencoded"));
            dSettings = new DeviceSettings();
        }
        public async Task<string> PostRequest(FormUrlEncodedContent content, string url) {
            var response = await client.PostAsync(url, content);
            var jsonResult = response.Content.ReadAsStringAsync().Result;
            return jsonResult;
        }
        public async Task<string> GetRequest(FormUrlEncodedContent content, string url) {
            var response = await client.GetAsync(url);
            var jsonResult = response.Content.ReadAsStringAsync().Result;
            return jsonResult;
        }
    }


    public class UserService: RestService { 
        public UserService() { 
        }
        public async Task<AuthResponseToken> Authenticate(User param) {
            var uri = Constant.baseURL + "";
            var content = new FormUrlEncodedContent(param.toParam());
            content.Headers.Add("uuid", Constant.deviceID);
            var response = this.PostRequest(content, uri);
            //convert the string json to 
            return JsonConvert.DeserializeObject<AuthResponseToken>(response.Result);
        }
    }
}
