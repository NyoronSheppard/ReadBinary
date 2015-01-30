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
    public partial class BasePage : PhoneApplicationPage
    {

        private static bool isCreated = false;

        public BasePage()
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



            if (isCreated == false)
            {
                BaseBoxList.ItemsSource = BaseList.GetCurrencyStart();
                isCreated = true;
            }
            else
            {
                BaseBoxList.ItemsSource = BaseList.GetCurrency();
            }
        }

        //Base Class
        public class Base
        {
            public string ID { get; set; }
            public string nameBase { get; set; }
            public string nameShort { get; set; }
            public bool selected { get; set; }
        }

        //Create a Currency List
        public static class BaseList
        {
            public static List<Base> lBase = new List<Base>();
            public static List<Base> GetCurrencyStart()
            {
                lBase.Add(new Base
                {
                    ID = "0",
                    nameBase = "Decimal",
                    nameShort = "DEC",
                    selected = false
                });

                lBase.Add(new Base
                {
                    ID = "1",
                    nameBase = "Binary",
                    nameShort = "BIN",
                    selected = false
                });

                lBase.Add(new Base
                {
                    ID = "2",
                    nameBase = "Octal",
                    nameShort = "OCT",
                    selected = false
                });

                lBase.Add(new Base
                {
                    ID = "3",
                    nameBase = "Hexadecimal",
                    nameShort = "HEX",
                    selected = false
                });

                return lBase;
            }

            public static List<Base> GetCurrency()
            {
                return lBase;
            }
        }

        private void BaseBoxList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (BaseBoxList.SelectedItem == null)
            {   //Nothing happens
                return;
            }

            BaseList.lBase[BaseBoxList.SelectedIndex].selected = true;

            Base currentCurrency = (Base)BaseBoxList.SelectedItem;

            //Base Decimal
            if (currentCurrency.nameShort == "DEC")
            {
                Models.BaseUpdate.nameBase1 = currentCurrency.nameBase;
                Models.BaseUpdate.nameShortBase1 = currentCurrency.nameShort;

                Models.BaseUpdate.nameBase2 = "Binary";
                Models.BaseUpdate.nameShortBase2 = "BIN";

                Models.BaseUpdate.nameBase3 = "Octal";
                Models.BaseUpdate.nameShortBase3 = "OCT";

                Models.BaseUpdate.nameBase4 = "Hexadecimal";
                Models.BaseUpdate.nameShortBase4 = "HEX";
            }

            //Base Binary
            if (currentCurrency.nameShort == "BIN")
            {
                Models.BaseUpdate.nameBase1 = currentCurrency.nameBase;
                Models.BaseUpdate.nameShortBase1 = currentCurrency.nameShort;

                Models.BaseUpdate.nameBase2 = "Decimal";
                Models.BaseUpdate.nameShortBase2 = "DEC";

                Models.BaseUpdate.nameBase3 = "Octal";
                Models.BaseUpdate.nameShortBase3 = "OCT";

                Models.BaseUpdate.nameBase4 = "Hexadecimal";
                Models.BaseUpdate.nameShortBase4 = "HEX";
            }

            //Base Octal
            if (currentCurrency.nameShort == "OCT")
            {
                Models.BaseUpdate.nameBase1 = currentCurrency.nameBase;
                Models.BaseUpdate.nameShortBase1 = currentCurrency.nameShort;

                Models.BaseUpdate.nameBase2 = "Decimal";
                Models.BaseUpdate.nameShortBase2 = "DEC";

                Models.BaseUpdate.nameBase3 = "Binary";
                Models.BaseUpdate.nameShortBase3 = "BIN";

                Models.BaseUpdate.nameBase4 = "Hexadecimal";
                Models.BaseUpdate.nameShortBase4 = "HEX";
            }

            //Base Hexadecimal
            if (currentCurrency.nameShort == "HEX")
            {
                Models.BaseUpdate.nameBase1 = currentCurrency.nameBase;
                Models.BaseUpdate.nameShortBase1 = currentCurrency.nameShort;

                Models.BaseUpdate.nameBase2 = "Decimal";
                Models.BaseUpdate.nameShortBase2 = "DEC";

                Models.BaseUpdate.nameBase3 = "Binary";
                Models.BaseUpdate.nameShortBase3 = "BIN";

                Models.BaseUpdate.nameBase4 = "Octal";
                Models.BaseUpdate.nameShortBase4 = "OCT";
            }           

            BaseList.lBase[BaseBoxList.SelectedIndex].selected = false;

            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

        //Go to Main Page
        private void iconApp_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }
    }
}