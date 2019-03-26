using System;
namespace myfirstxamarin.Model
{
    public class AuthResponseToken
    {
        public string refresh_token { get; set; }
        public string grant_type { get; set; }
        public string status_code { get; set; }
    }
}
