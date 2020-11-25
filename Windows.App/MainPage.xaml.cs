using System;
using TestApi.Pages;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;
using Windows.UI.Popups;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

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

        private async  void btnAccount_Click(object sender, RoutedEventArgs e)
        {
            var currentAV = ApplicationView.GetForCurrentView();
            var newAV = CoreApplication.CreateNewView();
            await newAV.Dispatcher.RunAsync(
                            CoreDispatcherPriority.Normal,
                            async () =>
                            {
                                var newWindow = Window.Current;
                                var newAppView = ApplicationView.GetForCurrentView();
                                newAppView.Title = "Login";

                                var frame = new Frame();
                                frame.Navigate(typeof(Login),null);
                                newWindow.Content = frame;
                                newWindow.Activate();

                                await ApplicationViewSwitcher.TryShowAsStandaloneAsync(
                                    newAppView.Id,
                                    ViewSizePreference.UseMinimum,
                                    currentAV.Id,
                                    ViewSizePreference.UseMinimum);
                            });
        }

        private void btnTheme_Checked(object sender, RoutedEventArgs e)
        {
            main.Background = new SolidColorBrush(new Windows.UI.Color { R = 0,A = 0,B = 0,G =0});
        }

        private void btnTheme_Unchecked(object sender, RoutedEventArgs e)
        {
            main.Background = new SolidColorBrush(new Windows.UI.Color { R = 202, A = 180, B = 202, G = 202});
        }

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
    }    
}


