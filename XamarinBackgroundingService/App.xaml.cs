using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinBackgroundingService.Services;
using XamarinBackgroundingService.Views;

namespace XamarinBackgroundingService
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new SampleView();// new AppShell();
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
