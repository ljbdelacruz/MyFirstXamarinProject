using System;
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
    }
}
