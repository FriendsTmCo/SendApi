using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI.Core;
using Windows.UI.Popups;
using Windows.UI.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Windows.App.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HomeContent : Page
    {
        public DateTime date = DateTime.Now;

        public HomeContent()
        {
            this.InitializeComponent();
        }


        private void btn_ChoseMethod(Object sender, RoutedEventArgs e)
        {
            var option = (MenuFlyoutItem)sender;
            drp_Type.Content = option.Tag;
        }

        private void RadioButton_Checked(Object sender, RoutedEventArgs e)
        {
            var checkBox = (RadioButton)sender;
            if (checkBox.Name == "raw")
            {
                if (checkBox.IsChecked.Value)
                {
                    drp_dataType.IsEnabled = true;
                }
                else
                {
                    drp_dataType.IsEnabled = false;
                }
            }
        }

        private void dataTypeChange(Object sender, RoutedEventArgs e)
        {
            var option = (MenuFlyoutItem)sender;
            drp_dataType.Content = option.Tag;
        }

    }
}
