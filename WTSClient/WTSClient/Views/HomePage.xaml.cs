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
    public partial class HomePage : ContentPage
    {
        Bills bills = new Bills();
        public HomePage()
        {
            InitializeComponent();
        }
    }
}