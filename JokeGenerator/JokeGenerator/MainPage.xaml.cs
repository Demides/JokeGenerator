using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using RestSharp;
using RestSharp.Authenticators;
using System.Net;

namespace JokeGenerator
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();       
        }

        public void GetJoke()
        {
            string s = new WebClient().DownloadString("http://api.icndb.com/jokes/random");
            string z = "joke\": \"";
            int n = s.IndexOf(z);
            s = s.Remove(0, n + z.Length);
             z = "\", \"";
             n = s.IndexOf(z);
            s = s.Substring(0, n);
            JokeLabel.Text = s; 
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            GetJoke();
        }
    }
}
