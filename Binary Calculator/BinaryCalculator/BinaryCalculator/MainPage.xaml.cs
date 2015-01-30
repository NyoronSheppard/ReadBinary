using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using BinaryCalculator.Resources;
using System.Windows.Media.Imaging;

using BinaryCalculator.Models;
using System.Windows.Input;

namespace BinaryCalculator
{
    public partial class MainPage : PhoneApplicationPage
    {

        //Atributtes
        string stringDEC;

        // Constructor
        public MainPage()
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

                BitmapImage arrow = new BitmapImage(new Uri(@"/Assets/next.png", UriKind.RelativeOrAbsolute));
                Arrow.Source = arrow;
            }
            else
            {
                BitmapImage bm = new BitmapImage(new Uri(@"/Assets/calculatorBlack.png", UriKind.RelativeOrAbsolute));
                iconApp.Source = bm;

                BitmapImage arrow = new BitmapImage(new Uri(@"/Assets/nextBlack.png", UriKind.RelativeOrAbsolute));
                Arrow.Source = arrow;
            }

            stringDEC = "";

            //Initial Base
            if (Models.BaseUpdate.firstTime == false)
            {
                Models.BaseUpdate.first();
            }

            LabelBase1.Text = Models.BaseUpdate.nameShortBase1;
            LabelBase2.Text = Models.BaseUpdate.nameShortBase2;
            LabelBase3.Text = Models.BaseUpdate.nameShortBase3;
            LabelBase4.Text = Models.BaseUpdate.nameShortBase4;

            // Código de ejemplo para traducir ApplicationBar
            //BuildLocalizedApplicationBar();

            //Input Text
            textBoxDEC.InputScope = null;

            InputScope scope = new InputScope();
            InputScopeName name = new InputScopeName();

            if (Models.BaseUpdate.nameShortBase1 == "HEX")
            {
                name.NameValue = InputScopeNameValue.Default;
                scope.Names.Clear();
                scope.Names.Add(name);
            }
            else
            {
                name.NameValue = InputScopeNameValue.Number;
                scope.Names.Clear();
                scope.Names.Add(name);
            }

            textBoxDEC.InputScope = scope;

            var asdf = textBoxDEC.InputScope.Names[0].GetType().Name.ToString();
        }

        //Dec Text
        private void textBoxDEC_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Models.BaseUpdate.nameShortBase1 == "DEC")
            {

                try
                {
                    if (textBoxDEC.Text.Length <= 6)
                    {
                        stringDEC = textBoxDEC.Text;

                        int intDEC = int.Parse(stringDEC);

                        DecimalToBase decT = new DecimalToBase(intDEC);

                        //To binary
                        textBlockBIN.Text = decT.getDecimalToBinary();

                        //To octal
                        textBlockOCT.Text = decT.getDecimalToOctal();

                        //To hexadecimal
                        textBlockHEX.Text = decT.getDecimalToHexadecimal();
                    }
                    else
                    {
                        textBoxDEC.Text = stringDEC;
                    }
                }
                catch
                {
                    if (stringDEC == "")
                    {
                        textBlockBIN.Text = "0";
                        textBlockOCT.Text = "0";
                        textBlockHEX.Text = "0";
                    }
                    else
                    {
                        textBlockBIN.Text = "Numerical Error";
                        textBlockOCT.Text = "Numerical Error";
                        textBlockHEX.Text = "Numerical Error";
                    }
                }       
            }
            else if (Models.BaseUpdate.nameShortBase1 == "BIN")
            {

                try
                {
                    if (textBoxDEC.Text.Length <= 9)
                    {
                        stringDEC = textBoxDEC.Text;

                        int intBIN = int.Parse(stringDEC);

                        BinaryToBase toBin = new BinaryToBase(intBIN);

                        //To decimal
                        textBlockBIN.Text = toBin.getBinaryToDecimal();

                        //To octal
                        textBlockOCT.Text = toBin.getBinaryToOctal();

                        //To hexadecimal
                        textBlockHEX.Text = toBin.getBinaryToHexadecimal();
                    }
                    else
                    {
                        textBoxDEC.Text = stringDEC;
                    }
                }
                catch
                {
                    if (stringDEC == "")
                    {
                        textBlockBIN.Text = "0";
                        textBlockOCT.Text = "0";
                        textBlockHEX.Text = "0";
                    }
                    else
                    {
                        textBlockBIN.Text = "Numerical Error";
                        textBlockOCT.Text = "Numerical Error";
                        textBlockHEX.Text = "Numerical Error";
                    }
                }       
            }
            else if (Models.BaseUpdate.nameShortBase1 == "OCT")
            {

                try
                {
                    if (textBoxDEC.Text.Length <= 7)
                    {
                        stringDEC = textBoxDEC.Text;

                        int intOCT = int.Parse(stringDEC);

                        OctalToBase octT = new OctalToBase(intOCT);

                        //To decimal
                        textBlockBIN.Text = octT.getOctalToDecimal();

                        //To binary
                        textBlockOCT.Text = octT.getOctalToBinary(); ;

                        //To hexadecimal
                        textBlockHEX.Text = octT.getOctalToHexadecimal();
                    }
                    else
                    {
                        textBoxDEC.Text = stringDEC;
                    }
                }
                catch
                {
                    if (stringDEC == "")
                    {
                        textBlockBIN.Text = "0";
                        textBlockOCT.Text = "0";
                        textBlockHEX.Text = "0";
                    }
                    else
                    {
                        textBlockBIN.Text = "Numerical Error";
                        textBlockOCT.Text = "Numerical Error";
                        textBlockHEX.Text = "Numerical Error";
                    }
                }    
            }
            else if (Models.BaseUpdate.nameShortBase1 == "HEX")
            {

                try
                {
                    if (textBoxDEC.Text.Length <= 5)
                    {
                        stringDEC = textBoxDEC.Text;

                        //int intHEX = int.Parse(stringDEC);

                        HexadecimalToBase hexT = new HexadecimalToBase(stringDEC);

                        //To decimal
                        textBlockBIN.Text = hexT.getHexadecimalToDecimal();

                        //To binary
                        textBlockOCT.Text = hexT.getHexadecimalToBinary();

                        //To octal
                        textBlockHEX.Text = hexT.getHexadecimalToOctal();
                    }
                    else
                    {
                        textBoxDEC.Text = stringDEC;
                    }
                }
                catch
                {
                    if (stringDEC == "")
                    {
                        textBlockBIN.Text = "0";
                        textBlockOCT.Text = "0";
                        textBlockHEX.Text = "0";
                    }
                    else
                    {
                        textBlockBIN.Text = "Numerical Error";
                        textBlockOCT.Text = "Numerical Error";
                        textBlockHEX.Text = "Numerical Error";
                    }
                }
            }
        }

        //Remove ',' and '.' from Keyboard
        private void textBoxDEC_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.PlatformKeyCode == 190)
            {
                e.Handled = true;
            }

            if (e.PlatformKeyCode == 188)
            {
                e.Handled = true;
            }
        }

        //Remove all textBlocks
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            textBoxDEC.Text = "0";
        }

        //Check the Base
        private void Image_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/BasePage.xaml", UriKind.RelativeOrAbsolute));
        }

        //Go to About Page
        private void onClickAbout(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/About.xaml", UriKind.Relative));
        }



        // Código de ejemplo para compilar una ApplicationBar traducida
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Establecer ApplicationBar de la página en una nueva instancia de ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Crear un nuevo botón y establecer el valor de texto en la cadena traducida de AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Crear un nuevo elemento de menú con la cadena traducida de AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}