using System;
using System.Collections.Generic;
using System.ComponentModel;
using WTSClient.Models;
using WTSClient.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WTSClient.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}