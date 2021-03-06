﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using TestApi.Pages;
using Windows.App.Pages;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Windows.App
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

        private void btn_Account_Click(object sender, RoutedEventArgs e)
        {
            frm_Main.Navigate(typeof(Login));
        }

        private void btn_Home_Click(Object sender, RoutedEventArgs e)
        {
            frm_Main.Navigate(typeof(Home));
        }

        private void btn_Setting_Click(Object sender, RoutedEventArgs e)
        {
            frm_Main.Navigate(typeof(Setting));
        }

        private void btn_Clear_Click(Object sender, RoutedEventArgs e)
        {
            frm_Main.Navigate(typeof(Home));
        }
    }
}
