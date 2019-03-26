using System;
using System.Net.Http;
using System.Collections.Generic;

namespace myfirstxamarin.Model
{
    public class User
    {
        public String Username { get; set; }
        public String Password { get; set; }
        public User(){
            this.Username = "";
            this.Password = "";
        }
        public User(String username, String password) {
            this.Username = username;
            this.Password = password;
        }
        public bool CheckingValidity() { 
            if(!this.Username.Equals("") && !this.Password.Equals("")) {
                return true;
            }
            return false;
        }
        public List<KeyValuePair<string, string>> toParam() {
            var param = new List<KeyValuePair<string, string>>();
            param.Add(new KeyValuePair<string, string>("username", this.Username));
            param.Add(new KeyValuePair<string, string>("password", this.Password));
            return param;
        }

    }
}
