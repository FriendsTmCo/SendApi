using System;
using System.Net.Http;
using TestApi.Pages;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;
using Windows.UI.Popups;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TestApi
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        //private async void btnAccount_Click(object sender, RoutedEventArgs e)
        //{
        //    var currentAV = ApplicationView.GetForCurrentView();
        //    var newAV = CoreApplication.CreateNewView();
        //    await newAV.Dispatcher.RunAsync(
        //                    CoreDispatcherPriority.Normal,
        //                    async () =>
        //                    {
        //                        var newWindow = Window.Current;
        //                        var newAppView = ApplicationView.GetForCurrentView();
        //                        newAppView.Title = "Login";

        //                        var frame = new Frame();
        //                        frame.Navigate(typeof(Login), null);
        //                        newWindow.Content = frame;
        //                        newWindow.Activate();

        //                        await ApplicationViewSwitcher.TryShowAsStandaloneAsync(
        //                            newAppView.Id,
        //                            ViewSizePreference.UseMinimum,
        //                            currentAV.Id,
        //                            ViewSizePreference.UseMinimum);
        //                    });
        //}


        private async void btnSend_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog msg = new MessageDialog($"Send To ({txtUrl.Text})");
            msg.Commands.Add(new UICommand { Id = 0, Label = "OK" });
            msg.Commands.Add(new UICommand { Id = 1, Label = "Cancel" });
            var result = await msg.ShowAsync();
            if ((int)result.Id == 0)
            {
               
            }
        }

        private void btn_showResult_Click(object sender, RoutedEventArgs e)
        {
            spl_Result.IsPaneOpen = true;
        }

        private void ChoseMethod(object sender, RoutedEventArgs e)
        {
            var option = ((MenuFlyoutItem)sender).Tag.ToString();

            dpb_Metod.Content = option;
        }

        private void ChoseType(object sender, RoutedEventArgs e)
        {
            var option = ((MenuFlyoutItem)sender).Tag.ToString();

            dpb_Type.Content = option;
        }


        private void main_Loaded(object sender, RoutedEventArgs e)
        {
            lbl_Date.Text = DateTime.Now.Year.ToString() + " " + DateTime.Now.DayOfWeek.ToString() + " " + DateTime.Now.Month.ToString("00");
        }

        private async void NavigationView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            var option = (NavigationViewItem)sender.SelectedItem;
            MessageDialog msg = new MessageDialog($"{option.Tag.ToString()}");
            msg.Commands.Add(new UICommand { Id = 0, Label = "OK" });
            msg.Commands.Add(new UICommand { Id = 1, Label = "Cancel" });
            await msg.ShowAsync();
        }
    }
}


