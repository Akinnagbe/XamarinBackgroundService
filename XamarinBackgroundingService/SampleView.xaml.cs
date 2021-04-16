using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinBackgroundingService
{
    public partial class SampleView : ContentPage
    {
        INotificationManager notificationManager;
        int notificationNumber = 0;
        public SampleView()
        {
            InitializeComponent();

            notificationManager = DependencyService.Get<INotificationManager>();
            notificationManager.NotificationReceived += (sender, eventArgs) =>
            {
                var evtData = (NotificationEventArgs)eventArgs;
                ShowNotification(evtData.Title, evtData.Message);
            };
        }

        void ShowNotification(string title, string message)
        {
            Device.BeginInvokeOnMainThread(() =>
            {

                lblText.Text = $"Notification Received:\nTitle: {title}\nMessage: {message}";
               
               
            });
        }
    }
}
