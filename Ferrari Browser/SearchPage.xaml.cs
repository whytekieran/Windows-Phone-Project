using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Ferrari_Browser
{
    public partial class SearchPage : PhoneApplicationPage
    {
        public SearchPage()
        {
            InitializeComponent();
        }

        private void btnWebGo(object sender, RoutedEventArgs e)
        {
             try
             {
                 webBrowser.Navigate(new Uri("http://www.Ferrari.com", UriKind.Absolute));
             }
             catch (WebBrowserNavigationException)
             {
                 MessageBox.Show("There has been an Internet connection error - please check your connection",
                         "Connection Error", MessageBoxButton.OK);
             }
        }

        private void btnAbout(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/AboutPage.xaml", UriKind.Relative));
        }

        private void btnWebHelp(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/WebHelpPage.xaml", UriKind.Relative));
        }
    }
}