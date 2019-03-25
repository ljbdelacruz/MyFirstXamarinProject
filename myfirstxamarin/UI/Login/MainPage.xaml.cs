using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using myfirstxamarin.Model;
using myfirstxamarin.UI.Dashboard;

namespace myfirstxamarin
{
    public partial class MainPage : ContentPage
    {
        private User userInfo;
        public MainPage()
        {
            this.userInfo = new User();
            InitializeComponent();
        }
        void OnLoginClicked(Object sender, EventArgs e) {
            this.userInfo = new User(Entry_Username.Text, Entry_Password.Text);
            if (!this.userInfo.CheckingValidity()) {
                Entry_Username.TextColor = Color.Red;
                Entry_Password.TextColor = Color.Red;
            }
            else {
                Navigation.PushModalAsync(new Dashboard ());
            }
        }
    }
}
