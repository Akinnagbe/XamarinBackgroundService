using System.ComponentModel;
using Xamarin.Forms;
using XamarinBackgroundingService.ViewModels;

namespace XamarinBackgroundingService.Views
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