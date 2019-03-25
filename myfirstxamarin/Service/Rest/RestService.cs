using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using myfirstxamarin.Model;

namespace myfirstxamarin.Service.Rest
{
    public class RestService
    {
        HttpClient client;
        public RestService()
        {
            client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application\\x-www-form-urlencoded"));
        }

    }


    public class UserService: RestService { 
        public UserService() { 
        }
        public async Task<Boolean> Authenticate(User param) {
            return true;
        }
    }
}
