using Crypto_Portfolio_Tracker.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Crypto_Portfolio_Tracker.Views
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