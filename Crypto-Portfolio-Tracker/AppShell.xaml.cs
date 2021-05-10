using Crypto_Portfolio_Tracker.ViewModels;
using Crypto_Portfolio_Tracker.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Crypto_Portfolio_Tracker
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
