using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Media.Imaging;

namespace BinaryCalculator
{
    public partial class About : PhoneApplicationPage
    {
        public About()
        {
            InitializeComponent();

            // Determine the visibility of the dark background.
            Visibility darkBackgroundVisibility =
                (Visibility)Application.Current.Resources["PhoneDarkThemeVisibility"];

            // Icon dark or light
            if (darkBackgroundVisibility == Visibility.Visible)
            {
                BitmapImage bm = new BitmapImage(new Uri(@"/Assets/calculator.png", UriKind.RelativeOrAbsolute));
                iconApp.Source = bm;
            }
            else
            {
                BitmapImage bm = new BitmapImage(new Uri(@"/Assets/calculatorBlack.png", UriKind.RelativeOrAbsolute));
                iconApp.Source = bm;
            }
        }

        //Go to main page
        private void iconApp_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }
    }
}