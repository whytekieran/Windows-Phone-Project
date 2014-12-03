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
    public partial class ImagesPage : PhoneApplicationPage
    {
        List<Ferrari> listOfFerrari125sImages;
        List<Ferrari> listOfFerrari166mmImages;
        List<Ferrari> listOfFerrariGTLussoImages;
        List<Ferrari> listOfFerrari375AmericaImages;
        List<Ferrari> listOfFerrari250TestaRossaImages;
        List<Ferrari> listOfFerrariGTOImages;
        List<Ferrari> listOfFerrariF40Images;
        List<Ferrari> listOfFerrariF50Images;
        List<Ferrari> listOfFerrariEnzoImages;
        List<Ferrari> listOfFerrariF12BerlinettaImages;
        List<Ferrari> listOfFerrariLaFerrariImages;
        List<Ferrari> listOfFerrariFFImages;
        List<Ferrari> listOfFerrari458ChallengeImages;
        List<Ferrari> listOfFerrariCaliforniaImages;
        List<Ferrari> listOfFerrari458ItaliaImages;

        public ImagesPage()
        {
            InitializeComponent();
            createFerrari125sImages();
            createFerrari166mmImages();
            createFerrariGTLussoImages();
            createFerrari375AmericaImages();
            createFerrari250TestaRossaImages();
            createFerrariGTOImages();
            createFerrariF40Images();
            createFerrariF50Images();
            createFerrariEnzoImages();
            createFerrariF12BerlinettaImages();
            createFerrariLaFerrariImages();
            createFerrariFFImages();
            createFerrari458ChallengeImages();
            createFerrariCaliforniaImages();
            createFerrari458ItaliaImages();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            try
            {
                string msg = "";

                //This will recieve a string id number from the main page
                if (NavigationContext.QueryString.TryGetValue("msg", out msg))
                {
                    (Application.Current as App).informationMessage = msg;
                    displayImages((Application.Current as App).informationMessage);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There has been a problem getting the images",
                         "Information Error", MessageBoxButton.OK);
            }
        }

        private void displayImages(string msg)
        {
            switch (msg)
            {
                case "1a":
                    listCarImages.ItemsSource = listOfFerrari125sImages;
                    break;
                case "1b":
                    listCarImages.ItemsSource = listOfFerrari166mmImages;
                    break;
                case "1c":
                    listCarImages.ItemsSource = listOfFerrariGTLussoImages;
                    break;
                case "1d":
                    listCarImages.ItemsSource = listOfFerrari375AmericaImages;
                    break;
                case "1e":
                    listCarImages.ItemsSource = listOfFerrari250TestaRossaImages;
                    break;
                case "1f":
                    listCarImages.ItemsSource = listOfFerrariGTOImages;
                    break;
                case "1g":
                    listCarImages.ItemsSource = listOfFerrariF40Images;
                    break;
                case "1h":
                    listCarImages.ItemsSource = listOfFerrariF50Images;
                    break;
                case "1i":
                    listCarImages.ItemsSource = listOfFerrariEnzoImages;
                    break;
                case "2a":
                    listCarImages.ItemsSource = listOfFerrariF12BerlinettaImages;
                    break;
                case "2b":
                    listCarImages.ItemsSource = listOfFerrariLaFerrariImages;
                    break;
                case "2c":
                    listCarImages.ItemsSource = listOfFerrariFFImages;
                    break;
                case "2d":
                    listCarImages.ItemsSource = listOfFerrari458ChallengeImages;
                    break;
                case "2e":
                    listCarImages.ItemsSource = listOfFerrariCaliforniaImages;
                    break;
                case "2f":
                    listCarImages.ItemsSource = listOfFerrari458ItaliaImages;
                    break;
            }
        }

        private void createFerrari125sImages()
        {
            Ferrari car;

            if (listOfFerrari125sImages == null)
            {
                listOfFerrari125sImages = new List<Ferrari>();
            }

            car = new Ferrari();
            car.ferrariImage = "Images/Ferrari_125_S-1.jpg";
            listOfFerrari125sImages.Add(car);

            car = new Ferrari();
            car.ferrariImage = "Images/Ferrari125s-2.jpg";
            listOfFerrari125sImages.Add(car);
        }

        private void createFerrari166mmImages()
        {
            Ferrari car;

            if (listOfFerrari166mmImages == null)
            {
                listOfFerrari166mmImages = new List<Ferrari>();
            }

            car = new Ferrari();
            car.ferrariImage = "Images/Ferrari166MM-1.jpg";
            listOfFerrari166mmImages.Add(car);

            car = new Ferrari();
            car.ferrariImage = "Images/Ferrari166mm-2.jpg";
            listOfFerrari166mmImages.Add(car);
        }

        private void createFerrariGTLussoImages()
        {
            Ferrari car;

            if (listOfFerrariGTLussoImages == null)
            {
                listOfFerrariGTLussoImages = new List<Ferrari>();
            }

            car = new Ferrari();
            car.ferrariImage = "Images/FerrariGTLusso-1.jpg";
            listOfFerrariGTLussoImages.Add(car);

            car = new Ferrari();
            car.ferrariImage = "Images/FerrariGTLusso-2.jpg";
            listOfFerrariGTLussoImages.Add(car);
        }

        private void createFerrari375AmericaImages()
        {
            Ferrari car;

            if (listOfFerrari375AmericaImages == null)
            {
                listOfFerrari375AmericaImages = new List<Ferrari>();
            }

            car = new Ferrari();
            car.ferrariImage = "Images/Ferrari375America-1.jpg";
            listOfFerrari375AmericaImages.Add(car);

            car = new Ferrari();
            car.ferrariImage = "Images/Ferrari375America-2.jpg";
            listOfFerrari375AmericaImages.Add(car);
        }

        private void createFerrari250TestaRossaImages()
        {
            Ferrari car;

            if (listOfFerrari250TestaRossaImages == null)
            {
                listOfFerrari250TestaRossaImages = new List<Ferrari>();
            }

            car = new Ferrari();
            car.ferrariImage = "Images/Ferrari250TestaRossa-1.jpg";
            listOfFerrari250TestaRossaImages.Add(car);

            car = new Ferrari();
            car.ferrariImage = "Images/Ferrari250TestaRossa-2.jpg";
            listOfFerrari250TestaRossaImages.Add(car);

            car = new Ferrari();
            car.ferrariImage = "Images/Ferrari250TestaRossa-3.jpg";
            listOfFerrari250TestaRossaImages.Add(car);
        }

        private void createFerrariGTOImages()
        {
            Ferrari car;

            if (listOfFerrariGTOImages == null)
            {
                listOfFerrariGTOImages = new List<Ferrari>();
            }

            car = new Ferrari();
            car.ferrariImage = "Images/FerrariGTO-1.jpg";
            listOfFerrariGTOImages.Add(car);

            car = new Ferrari();
            car.ferrariImage = "Images/FerrariGTO-2.jpg";
            listOfFerrariGTOImages.Add(car);
        }

        private void createFerrariF40Images()
        {
            Ferrari car;

            if (listOfFerrariF40Images == null)
            {
                listOfFerrariF40Images = new List<Ferrari>();
            }

            car = new Ferrari();
            car.ferrariImage = "Images/FerrariF40-1.jpg";
            listOfFerrariF40Images.Add(car);

            car = new Ferrari();
            car.ferrariImage = "Images/FerrariF40-2.jpg";
            listOfFerrariF40Images.Add(car);
        }

        private void createFerrariF50Images()
        {
            Ferrari car;

            if (listOfFerrariF50Images == null)
            {
                listOfFerrariF50Images = new List<Ferrari>();
            }

            car = new Ferrari();
            car.ferrariImage = "Images/FerrariF50-1.jpg";
            listOfFerrariF50Images.Add(car);

            car = new Ferrari();
            car.ferrariImage = "Images/FerrariF50-2.jpg";
            listOfFerrariF50Images.Add(car);
        }

        private void createFerrariEnzoImages()
        {
            Ferrari car;

            if (listOfFerrariEnzoImages == null)
            {
                listOfFerrariEnzoImages = new List<Ferrari>();
            }

            car = new Ferrari();
            car.ferrariImage = "Images/FerrariEnzo-1.jpg";
            listOfFerrariEnzoImages.Add(car);

            car = new Ferrari();
            car.ferrariImage = "Images/FerrariEnzo-2.jpg";
            listOfFerrariEnzoImages.Add(car);
        }

        private void createFerrariF12BerlinettaImages()
        {
            Ferrari car;

            if (listOfFerrariF12BerlinettaImages == null)
            {
                listOfFerrariF12BerlinettaImages = new List<Ferrari>();
            }

            car = new Ferrari();
            car.ferrariImage = "Images/FerrariF12Berlinetta-1.jpg";
            listOfFerrariF12BerlinettaImages.Add(car);

            car = new Ferrari();
            car.ferrariImage = "Images/FerrariF12Berlinetta-2.jpg";
            listOfFerrariF12BerlinettaImages.Add(car);

            car = new Ferrari();
            car.ferrariImage = "Images/FerrariF12Berlinetta-3.jpg";
            listOfFerrariF12BerlinettaImages.Add(car);
        }

        private void createFerrariLaFerrariImages()
        {
            Ferrari car;

            if (listOfFerrariLaFerrariImages == null)
            {
                listOfFerrariLaFerrariImages = new List<Ferrari>();
            }

            car = new Ferrari();
            car.ferrariImage = "Images/FerrariLaFerrari-1.jpg";
            listOfFerrariLaFerrariImages.Add(car);

            car = new Ferrari();
            car.ferrariImage = "Images/FerrariLaFerrari-2.jpg";
            listOfFerrariLaFerrariImages.Add(car);
        }

        private void createFerrariFFImages()
        {
            Ferrari car;

            if (listOfFerrariFFImages == null)
            {
                listOfFerrariFFImages = new List<Ferrari>();
            }

            car = new Ferrari();
            car.ferrariImage = "Images/FerrariFF-1.jpg";
            listOfFerrariFFImages.Add(car);

            car = new Ferrari();
            car.ferrariImage = "Images/FerrariFF-2.jpg";
            listOfFerrariFFImages.Add(car);
        }

        private void createFerrari458ChallengeImages()
        {
            Ferrari car;

            if (listOfFerrari458ChallengeImages == null)
            {
                listOfFerrari458ChallengeImages = new List<Ferrari>();
            }

            car = new Ferrari();
            car.ferrariImage = "Images/Ferrari458Challenge-1.jpg";
            listOfFerrari458ChallengeImages.Add(car);

            car = new Ferrari();
            car.ferrariImage = "Images/Ferrari458Challenge-2.jpg";
            listOfFerrari458ChallengeImages.Add(car);
        }

        private void createFerrariCaliforniaImages()
        {
            Ferrari car;

            if (listOfFerrariCaliforniaImages == null)
            {
                listOfFerrariCaliforniaImages = new List<Ferrari>();
            }

            car = new Ferrari();
            car.ferrariImage = "Images/FerrariCalifornia-1.jpg";
            listOfFerrariCaliforniaImages.Add(car);

            car = new Ferrari();
            car.ferrariImage = "Images/FerrariCalifornia-2.jpg";
            listOfFerrariCaliforniaImages.Add(car);

            car = new Ferrari();
            car.ferrariImage = "Images/FerrariCalifornia-3.jpg";
            listOfFerrariCaliforniaImages.Add(car);
        }

        private void createFerrari458ItaliaImages()
        {
            Ferrari car;

            if (listOfFerrari458ItaliaImages == null)
            {
                listOfFerrari458ItaliaImages = new List<Ferrari>();
            }

            car = new Ferrari();
            car.ferrariImage = "Images/Ferrari458Italia-1.jpg";
            listOfFerrari458ItaliaImages.Add(car);

            car = new Ferrari();
            car.ferrariImage = "Images/Ferrari458Italia-2.jpg";
            listOfFerrari458ItaliaImages.Add(car);

            car = new Ferrari();
            car.ferrariImage = "Images/Ferrari458Italia-3.jpg";
            listOfFerrari458ItaliaImages.Add(car);
        }

    }
}