using System.ComponentModel;
using Test.API.Mobile.ViewModels;
using Xamarin.Forms;

namespace Test.API.Mobile.Views
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