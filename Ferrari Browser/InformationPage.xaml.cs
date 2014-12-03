using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Resources;
using System.Reflection;
using Ferrari_Browser.Resources;

namespace Ferrari_Browser
{
    public partial class InformationPage : PhoneApplicationPage
    {

        public InformationPage()
        {
            InitializeComponent();
        }

        //When the information page is navigated to, do the following
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            try
            {
                string msg = "";
                
                //This will recieve a string id number from the main page
                if (NavigationContext.QueryString.TryGetValue("msg", out msg))
                {
                    //Passing the string id number into a method
                    //using a string saved in app.xaml.cs
                    //informationMessage string is saved in App.xaml
                    (Application.Current as App).informationMessage = msg;
                    displayMessage((Application.Current as App).informationMessage);
                }
            }
            catch(Exception)
            {
                information.Text = "Unfortunatly there was an error getting the requested information - Please Try Again";
            }
        }

        private void displayMessage(String choice) 
        {
            //switch on the id number string to find the correct info from appResources file
            switch (choice)
            {
                case "1":
                    information.Text = AppResources.ferrari125s;
                    break;
                case "2":
                    information.Text = AppResources.ferrari166mm;
                    break;
                case "3":
                    information.Text = AppResources.ferrari250GT;
                    break;
                case "4":
                    information.Text = AppResources.ferrari375America;
                    break;
                case "5":
                    information.Text = AppResources.ferrari250TestaRossa;
                    break;
                case "6":
                    information.Text = AppResources.ferrariGTO;
                    break;
                case "7":
                    information.Text = AppResources.ferrariF40;
                    break;
                case "8":
                    information.Text = AppResources.ferrariF50;
                    break;
                case "9":
                    information.Text = AppResources.ferrariEnzo;
                    break;
                case "10":
                    information.Text = AppResources.ferrariF12Berlinetta;
                    break;
                case "11":
                    information.Text = AppResources.ferrariLaFerrari;
                    break;
                case "12":
                    information.Text = AppResources.ferrariFF;
                    break;
                case "13":
                    information.Text = AppResources.ferrari458Challenge;
                    break;
                case "14":
                    information.Text = AppResources.ferrariCalifornia;
                    break;
                case "15":
                    information.Text = AppResources.ferrari458Italia;
                    break;
            }
        }

        //Navigates to Search page
        private void btnSearch_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/SearchPage.xaml", UriKind.Relative));
        }

        //Navigates to About page
        private void btnAbout(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/AboutPage.xaml", UriKind.Relative));
        }

    }

}