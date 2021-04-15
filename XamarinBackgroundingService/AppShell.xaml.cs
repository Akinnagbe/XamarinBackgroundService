using System;
using System.Collections.Generic;
using XamarinBackgroundingService.ViewModels;
using XamarinBackgroundingService.Views;
using Xamarin.Forms;

namespace XamarinBackgroundingService
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
