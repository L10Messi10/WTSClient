using Firebase.Database;
using System;
using WTSClient.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WTSClient
{
    public partial class App : Application
    {
        public static FirebaseClient client = new FirebaseClient("https://dadwasc-default-rtdb.asia-southeast1.firebasedatabase.app/");
        public App()
        {
            InitializeComponent();
           
            var isLoogged = Xamarin.Essentials.SecureStorage.GetAsync("isLogged").Result;
            if (isLoogged == "1")
            {
                MainPage = new AppShell();
            }
            else
            {
                MainPage = new WelcomePage();
            }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
