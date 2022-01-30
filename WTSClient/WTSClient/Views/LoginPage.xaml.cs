using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WTSClient.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WTSClient.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        Bills bills = new Bills();
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void btnclose_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}