using System.ComponentModel;
using WTSClient.ViewModels;
using Xamarin.Forms;

namespace WTSClient.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}