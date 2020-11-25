using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.API.Mobile.Models;
using Test.API.Mobile.ViewModels;
using Test.API.Mobile.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Test.API.Mobile.Views
{
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel _viewModel;

        public ItemsPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new ItemsViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}