﻿using System;
using System.Collections.Generic;
using System.Windows.Input;
//using WTSClient.ViewModels;
using WTSClient.Views;
using Xamarin.Forms;

namespace WTSClient
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            
        }
        

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Xamarin.Essentials.SecureStorage.SetAsync("isLogged", "0");
            await Current.GoToAsync("//LoginPage");
        }

        private async void Itembrowse_OnClicked(object sender, EventArgs e)
        {
            Current.FlyoutIsPresented = false;
            //await Navigation.PushModalAsync(new ItemsPage());
        }

        private async void Itemabout_OnClicked(object sender, EventArgs e)
        {
            Current.FlyoutIsPresented = false;
            //await Navigation.PushModalAsync(new AboutPage());
        }

        private async void Itemuser_OnClicked(object sender, EventArgs e)
        {
            Current.FlyoutIsPresented = false;
            //await Navigation.PushModalAsync(new ProfilePage());
        }

        private async void ItemStat_OnClicked(object sender, EventArgs e)
        {
            Current.FlyoutIsPresented = false;
            //await Navigation.PushModalAsync(new StatisticsPage());
        }
    }
}
