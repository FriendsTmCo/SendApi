using SendApi.Mobile.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace SendApi.Mobile.Views
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