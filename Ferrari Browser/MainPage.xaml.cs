using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Media;
using Ferrari_Browser.ViewModels;

namespace Ferrari_Browser
{
    public partial class MainPage : PhoneApplicationPage
    {
        List<Ferrari> listOfPastFerraris;
        List<Ferrari> listOfPresentFerraris;
        ListBoxItem list;
        int _iSelect;
        int _selectedItem;
        
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            createPastListCars();
            createPresentListCars();

            pastCarList.ItemsSource = listOfPastFerraris;
            presentCarList.ItemsSource = listOfPresentFerraris;

            DataContext = App.ViewModel;
        }//end Constructor

        //Create list of present ferrari's
        private void createPresentListCars()
        {
            Ferrari car;

            if (listOfPresentFerraris == null)
            {
                listOfPresentFerraris = new List<Ferrari>();
            }

            car = new Ferrari();
            car.carName = " Ferrari F12 Berlinetta";
            listOfPresentFerraris.Add(car);

            car = new Ferrari();
            car.carName = " Ferrari LaFerrari";
            listOfPresentFerraris.Add(car);

            car = new Ferrari();
            car.carName = " Ferrari FF";
            listOfPresentFerraris.Add(car);

            car = new Ferrari();
            car.carName = " Ferrari 458 Challenge";
            listOfPresentFerraris.Add(car);

            car = new Ferrari();
            car.carName = " Ferrari California";
            listOfPresentFerraris.Add(car);

            car = new Ferrari();
            car.carName = " Ferrari 458 Italia";
            listOfPresentFerraris.Add(car);
        }//end createPresentListCars()

        //Create list of present ferrari's
        private void createPastListCars()
        {
            Ferrari car;

            if (listOfPastFerraris == null)
            {
                listOfPastFerraris = new List<Ferrari>();
            }

            car = new Ferrari();
            car.carName = " Ferrari 125s";
            listOfPastFerraris.Add(car);

            car = new Ferrari();
            car.carName = " Ferrari 166mm";
            listOfPastFerraris.Add(car);

            car = new Ferrari();
            car.carName = " Ferrari 250GT Lusso";
            listOfPastFerraris.Add(car);

            car = new Ferrari();
            car.carName = " Ferrari 375 America";
            listOfPastFerraris.Add(car);

            car = new Ferrari();
            car.carName = " Ferrari 250 Testa Rossa";
            listOfPastFerraris.Add(car);

            car = new Ferrari();
            car.carName = " Ferrari GTO";
            listOfPastFerraris.Add(car);

            car = new Ferrari();
            car.carName = " Ferrari F40";
            listOfPastFerraris.Add(car);

            car = new Ferrari();
            car.carName = " Ferrari F50";
            listOfPastFerraris.Add(car);

            car = new Ferrari();
            car.carName = " Ferrari Enzo";
            listOfPastFerraris.Add(car);
        }//end createPastListCars()

        // Load data for the ViewModel Items
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }//end OnNavigatedTo

        //Navigate to the search page
        private void btnSearch_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/SearchPage.xaml", UriKind.Relative));
        }//end btnSearch_Click

        //Navigate to information page, depending on which list item is picked it passes an id to the information page.
        //Also changes the background color of selected item
       private void listItem_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            _iSelect = pastCarList.SelectedIndex;
            list = (ListBoxItem)sender;

            switch(_iSelect)
            {
                case 0:
                    list.Focus();
                    list.Background = App.Current.Resources["PhoneChromeBrush"] as SolidColorBrush;
                    NavigationService.Navigate(new Uri("/InformationPage.xaml?msg=" +1, UriKind.Relative)); 
                    break;
                case 1:
                    list.Focus();
                    list.Background = App.Current.Resources["PhoneChromeBrush"] as SolidColorBrush;
                    NavigationService.Navigate(new Uri("/InformationPage.xaml?msg=" +2, UriKind.Relative));
                    break;
                case 2:
                    list.Focus();
                    list.Background = App.Current.Resources["PhoneChromeBrush"] as SolidColorBrush;
                    NavigationService.Navigate(new Uri("/InformationPage.xaml?msg=" +3, UriKind.Relative));
                    break;
                case 3:
                    list.Focus();
                    list.Background = App.Current.Resources["PhoneChromeBrush"] as SolidColorBrush;
                    NavigationService.Navigate(new Uri("/InformationPage.xaml?msg=" +4, UriKind.Relative));
                    break;
                case 4:
                    list.Focus();
                    list.Background = App.Current.Resources["PhoneChromeBrush"] as SolidColorBrush;
                    NavigationService.Navigate(new Uri("/InformationPage.xaml?msg=" + 5, UriKind.Relative));
                    break;
                case 5:
                    list.Focus();
                    list.Background = App.Current.Resources["PhoneChromeBrush"] as SolidColorBrush;
                    NavigationService.Navigate(new Uri("/InformationPage.xaml?msg=" + 6, UriKind.Relative));
                    break;
                case 6:
                    list.Focus();
                    list.Background = App.Current.Resources["PhoneChromeBrush"] as SolidColorBrush;
                    NavigationService.Navigate(new Uri("/InformationPage.xaml?msg=" + 7, UriKind.Relative));
                    break;
                case 7:
                    list.Focus();
                    list.Background = App.Current.Resources["PhoneChromeBrush"] as SolidColorBrush;
                    NavigationService.Navigate(new Uri("/InformationPage.xaml?msg=" + 8, UriKind.Relative));
                    break;
                case 8:
                    list.Focus();
                    list.Background = App.Current.Resources["PhoneChromeBrush"] as SolidColorBrush;
                    NavigationService.Navigate(new Uri("/InformationPage.xaml?msg=" + 9, UriKind.Relative));
                    break;
            }
       }//end listItem_Tap method

       private void listItem2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
       {
           _iSelect = presentCarList.SelectedIndex;
           list = (ListBoxItem)sender;

           switch(_iSelect)
           {
               case 0:
                   list.Focus();
                   list.Background = App.Current.Resources["PhoneChromeBrush"] as SolidColorBrush;
                   NavigationService.Navigate(new Uri("/InformationPage.xaml?msg=" + 10, UriKind.Relative));
                   break;
               case 1:
                   list.Focus();
                   list.Background = App.Current.Resources["PhoneChromeBrush"] as SolidColorBrush;
                   NavigationService.Navigate(new Uri("/InformationPage.xaml?msg=" + 11, UriKind.Relative));
                   break;
               case 2:
                   list.Focus();
                   list.Background = App.Current.Resources["PhoneChromeBrush"] as SolidColorBrush;
                   NavigationService.Navigate(new Uri("/InformationPage.xaml?msg=" + 12, UriKind.Relative));
                   break;
               case 3:
                   list.Focus();
                   list.Background = App.Current.Resources["PhoneChromeBrush"] as SolidColorBrush;
                   NavigationService.Navigate(new Uri("/InformationPage.xaml?msg=" + 13, UriKind.Relative));
                   break;
               case 4:
                   list.Focus();
                   list.Background = App.Current.Resources["PhoneChromeBrush"] as SolidColorBrush;
                   NavigationService.Navigate(new Uri("/InformationPage.xaml?msg=" + 14, UriKind.Relative));
                   break;
               case 5:
                   list.Focus();
                   list.Background = App.Current.Resources["PhoneChromeBrush"] as SolidColorBrush;
                   NavigationService.Navigate(new Uri("/InformationPage.xaml?msg=" + 15, UriKind.Relative));
                   break;
           }
        }//end listItem_Tap2

        //Navigate to the about ferrari browser page
        private void btnAbout(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/AboutPage.xaml", UriKind.Relative));
        }//end btn_About

        //When focus is lost return the background color of the list item back to normal
        private void lostFocus(object sender, RoutedEventArgs e)
        {
            if (list.Focus() == false)
            {
                list.Background = App.Current.Resources["PhoneSubtleBrush"] as SolidColorBrush; 
            }
        }//end lostFocus

        //Finds selected listboxitem of context menu and passes id to images page(past ferraris only)
        private void showPics_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem selectedKey = this.pastCarList.ItemContainerGenerator.ContainerFromItem((sender as MenuItem).DataContext) as ListBoxItem;
            _selectedItem = pastCarList.ItemContainerGenerator.IndexFromContainer(selectedKey);
            
            switch(_selectedItem)
            {
                case 0:
                    NavigationService.Navigate(new Uri("/ImagesPage.xaml?msg=" + "1a", UriKind.Relative));
                    break;
                case 1:
                    NavigationService.Navigate(new Uri("/ImagesPage.xaml?msg=" + "1b", UriKind.Relative));
                    break;
                case 2:
                    NavigationService.Navigate(new Uri("/ImagesPage.xaml?msg=" + "1c", UriKind.Relative));
                    break;
                case 3:
                    NavigationService.Navigate(new Uri("/ImagesPage.xaml?msg=" + "1d", UriKind.Relative));
                    break;
                case 4:
                    NavigationService.Navigate(new Uri("/ImagesPage.xaml?msg=" + "1e", UriKind.Relative));
                    break;
                case 5:
                    NavigationService.Navigate(new Uri("/ImagesPage.xaml?msg=" + "1f", UriKind.Relative));
                    break;
                case 6:
                    NavigationService.Navigate(new Uri("/ImagesPage.xaml?msg=" + "1g", UriKind.Relative));
                    break;
                case 7:
                    NavigationService.Navigate(new Uri("/ImagesPage.xaml?msg=" + "1h", UriKind.Relative));
                    break;
                case 8:
                    NavigationService.Navigate(new Uri("/ImagesPage.xaml?msg=" + "1i", UriKind.Relative));
                    break;
            }//end switch
        }

        //Finds selected listboxitem of context menu and passes id to images page(present ferraris only)
        private void showPics2_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem selectedKey = this.presentCarList.ItemContainerGenerator.ContainerFromItem((sender as MenuItem).DataContext) as ListBoxItem;
            _selectedItem = presentCarList.ItemContainerGenerator.IndexFromContainer(selectedKey);

            switch (_selectedItem)
            {
                case 0:
                    NavigationService.Navigate(new Uri("/ImagesPage.xaml?msg=" + "2a", UriKind.Relative));
                    break;
                case 1:
                    NavigationService.Navigate(new Uri("/ImagesPage.xaml?msg=" + "2b", UriKind.Relative));
                    break;
                case 2:
                    NavigationService.Navigate(new Uri("/ImagesPage.xaml?msg=" + "2c", UriKind.Relative));
                    break;
                case 3:
                    NavigationService.Navigate(new Uri("/ImagesPage.xaml?msg=" + "2d", UriKind.Relative));
                    break;
                case 4:
                    NavigationService.Navigate(new Uri("/ImagesPage.xaml?msg=" + "2e", UriKind.Relative));
                    break;
                case 5:
                    NavigationService.Navigate(new Uri("/ImagesPage.xaml?msg=" + "2f", UriKind.Relative));
                    break;
            }

        }//end showPastPics_Click
    }//end class
}//end namespace