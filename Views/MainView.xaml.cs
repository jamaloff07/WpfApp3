﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfApp16.ViewModels;
using WpfApp3.Command;

namespace WpfApp3.Views
{
    public partial class MainView : Window
    {
        private MainViewModel viewModel;

        public MainView()
        {
            InitializeComponent();
            viewModel = new MainViewModel();
            DataContext = viewModel;
        }


        private void CarImage_Click(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Image clickedImage = sender as Image;
            if (clickedImage != null && clickedImage.Tag is string carTag)
            {
                CarInfo selectedCar = GetCarInfoByTag(carTag);
                if (selectedCar != null)
                {
                    CarDetailsView carDetailsView = new CarDetailsView(selectedCar);
                    carDetailsView.Show();
                }
            }
        }

        private CarInfo GetCarInfoByTag(string carTag)
        {
            CarInfo selectedCar = null;



            switch (carTag)
            {
                case "Priora":
                    selectedCar = new CarInfo
                    {
                        Model = "Lada Priora",
                        Motor = "Motor: 1.6 L",
                        Year = "İl: 2010",
                        Kilometers = "Yürüş: 100,000 km",
                        Price = "Qiymet: 25,000 AZN",
                        Color = "Reng: Ag",
                        ImageSource = "/image/priora.jpg",
                        about = "Haqqinda: Priora hakkında bilgi...",
                    };
                    break;

                case "Tuareg":
                    selectedCar = new CarInfo
                    {
                        Model = "Wolksvagen Tuareg",
                        Motor = "Motor: 2.0 TDI",
                        Year = "İl: 2012",
                        Kilometers = "Yürüş: 80,000 km",
                        Price = "Qiymet: 40,000 AZN",
                        Color = "Reng: Qara",
                        ImageSource = "/Image/tuareg.jpg",
                        about = "Haqqinda: Tuareg hakkında bilgi...",
                    };
                    break;

                case "4Goz":
                    selectedCar = new CarInfo
                    {
                        Model = "Mercedes E290",
                        Motor = "Motor: 2.9 L",
                        Year = "İl:2015",
                        Kilometers = "Yürüş: 120,000 km",
                        Price = "Qiymet: 30,000 AZN",
                        Color = "Reng: White",
                        ImageSource = "/Image/4goz.jpg",
                        about = "Haqqinda: 4 Göz hakkında bilgi...",
                    };
                    break;


                case "e60":
                    selectedCar = new CarInfo
                    {
                        Model = "BMW E60",
                        Motor = "Motor: 2.0 L",
                        Year = "İl: 2008",
                        Kilometers = "Yürüş: 150,000 km",
                        Price = "Qiymet: 20,000 AZN",
                        Color = "Reng: Qara",
                        ImageSource = "/Image/60kuza.jpg",
                        about = "Haqqinda: e60 hakkında bilgi...",
                    };
                    break;

                case "camry":
                    selectedCar = new CarInfo
                    {
                        Model = "Toyota Camry",
                        Motor = "Motor: 2.5 L",
                        Year = "İl:2014",
                        Kilometers = "Yürüş: 90,000 km",
                        Price = "Qiymet: 35,000 AZN",
                        Color = "Reng: Silver",
                        ImageSource = "/Image/camry.jpg",
                        about = "HaqqindaCamry hakkında bilgi...",
                    };
                    break;

                case "2107":
                    selectedCar = new CarInfo
                    {
                        Model = "Lada VAZ 2107",
                        Motor = "Motor: 1.6 L",
                        Year = "İl: 2005",
                        Kilometers = "Yürüş: 180,000 km",
                        Price = "Qiymet: 12,000 AZN",
                        Color = "Reng: Green",
                        ImageSource = "/Image/07.jpg",
                        about = "HAqqinda: 2107 hakkında bilgi...",
                    };
                    break;

                case "brabus":
                    selectedCar = new CarInfo
                    {
                        Model = "Mercedes G-63",
                        Motor = "Motor: 4.0 L",
                        Year = "İl: 2018",
                        Kilometers = "Yürüş: 20,000 km",
                        Price = "Qiymet: 200,000 AZN",
                        Color = "Reng: Red",
                        ImageSource = "/image/qalikk.jpg",
                        about = "Haqqinda: Brabus hakkında bilgi...",
                    };
                    break;

                case "sessot":
                    selectedCar = new CarInfo
                    {
                        Model = "Mercedes S300",
                        Motor = "Motor: 3.0 L",
                        Year = "İl: 2016",
                        Kilometers = "Yürüş: 40,000 km",
                        Price = "Qiymet: 150,000 AZN",
                        Color = "Reng: Blue",
                        ImageSource = "/image/download.jpg",
                        about = "Haqqinda: Sessot hakkında bilgi...",
                    };
                    break;

                case "challenger":
                    selectedCar = new CarInfo
                    {
                        Model = "Dodge Challenger",
                        Motor = "Motor: 3.6 L",
                        Year = "İl: 2019",
                        Kilometers = "Yürüş: 15,000 km",
                        Price = "Qiymet: 180,000 AZN",
                        Color = "Reng: White",
                        ImageSource = "/image/dodge.jpg",
                        about = "Haqqinda: Challenger hakkında bilgi...",
                    };
                    break;


                default:
                    break;
            }

            return selectedCar;
        }




        public class CarInfo
        {
            public string? Model { get; set; }
            public string? Motor { get; set; }
            public string? Year { get; set; }
            public string? Kilometers { get; set; }
            public string? Price { get; set; }
            public string? Color { get; set; }
            public string? ImageSource { get; internal set; }
            public string? about { get; set; }
        }

        private void myImageButton_MouseEnter(object sender, MouseEventArgs e)
        {
            Uri textResourceUri = new Uri("/images/red_text.png", UriKind.Relative);
            selectionText.Foreground = new SolidColorBrush(Colors.Red);

        }

        private void myImageButton_MouseLeave(object sender, MouseEventArgs e)
        {
            Uri textResourceUri = new Uri("/images/SlateGray_text.png", UriKind.Relative);

            selectionText.Foreground = new SolidColorBrush(Colors.SlateGray);

        }

        private void myImageButton1_MouseEnter(object sender, MouseEventArgs e)
        {
            Uri textResourceUri = new Uri("/images/red_text.png", UriKind.Relative);
            selectionText1.Foreground = new SolidColorBrush(Colors.Red);

        }

        private void myImageButton1_MouseLeave(object sender, MouseEventArgs e)
        {
            Uri textResourceUri = new Uri("/images/SlateGray_text.png", UriKind.Relative);

            selectionText1.Foreground = new SolidColorBrush(Colors.SlateGray);

        }

        private void myImageButton2_MouseEnter(object sender, MouseEventArgs e)
        {
            Uri textResourceUri = new Uri("/images/red_text.png", UriKind.Relative);
            selectionText2.Foreground = new SolidColorBrush(Colors.Red);

        }

        private void myImageButton2_MouseLeave(object sender, MouseEventArgs e)
        {
            Uri textResourceUri = new Uri("/images/SlateGray_text.png", UriKind.Relative);

            selectionText2.Foreground = new SolidColorBrush(Colors.SlateGray);

        }

        private void ImageButton_MouseEnter(object sender, MouseEventArgs e)
        {
            Uri heartResourceUri = new Uri("/Red_image/RedHeart.png", UriKind.Relative);
            Uri textResourceUri = new Uri("/Red_image/red_text.png", UriKind.Relative);
            heartImage.Source = new BitmapImage(heartResourceUri);
            selectionTextt.Foreground = new SolidColorBrush(Colors.Red);
        }

        private void ImageButton_MouseLeave(object sender, MouseEventArgs e)
        {
            Uri heartResourceUri = new Uri("/Red_image/heart.png", UriKind.Relative);
            Uri textResourceUri = new Uri("/Red_image/SlateGray_text.png", UriKind.Relative);
            heartImage.Source = new BitmapImage(heartResourceUri);
            selectionTextt.Foreground = new SolidColorBrush(Colors.SlateGray);
        }

        private void ImageButtonn_MouseEnter(object sender, MouseEventArgs e)
        {
            Uri heartResourceUri = new Uri("/Red_image/RedUser.png", UriKind.Relative);
            Uri textResourceUri = new Uri("/Red_image/red_text.png", UriKind.Relative);
            userImage.Source = new BitmapImage(heartResourceUri);
            selectionTexttu.Foreground = new SolidColorBrush(Colors.Red);
        }

        private void ImageButtonn_MouseLeave(object sender, MouseEventArgs e)
        {
            Uri heartResourceUri = new Uri("/Red_image/user.png", UriKind.Relative);
            Uri textResourceUri = new Uri("/Red_image/SlateGray_text.png", UriKind.Relative);
            userImage.Source = new BitmapImage(heartResourceUri);
            selectionTexttu.Foreground = new SolidColorBrush(Colors.SlateGray);
        }
    }
    private void MarkaComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (DataContext is MainViewModel viewModel)
        {
            viewModel.modelNames.Clear();

            switch (viewModel.SelectedMarka)
            {
                case "Mercedes":
                    viewModel.modelNames.Add("4 goz");
                    viewModel.modelNames.Add("sessot");
                    viewModel.modelNames.Add("brabus");
                    break;
                case "BMW":
                    viewModel..Add("e60");
                    break;
                case "Toyota":
                    viewModel.Modeller.Add("camry");
                    break;
                case "Wolksvagen":
                    viewModel.Modeller.Add("tuareg");
                    break;
                case "Dodge":
                    viewModel.Modeller.Add("challenger");
                    break;
                case "VAZ":
                    viewModel.Modeller.Add("2107");
                    break;
                case "Lada":
                    viewModel.Modeller.Add("priora");
                    break;
                // Diğer markaların modellerini de buraya ekleyin...
                default:
                    break;
            }
        }


    }


    private void ModelComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (sender is ComboBox comboBox && DataContext is MainViewModel viewModel)
        {
            // Seçilen model adını alıyoruz
            string selectedModel = comboBox.SelectedItem as string;

            // Burada seçilen model adına göre yapmak istediğiniz işlemleri yapabilirsiniz
            // Örneğin, seçilen model adına göre araba bilgilerini alıp ekranda gösterebilirsiniz
            // Bu işlem için GetCarInfoByModel(selectedModel) gibi bir metodunuz olabilir.
            // Ancak, bu metodunuzun CarInfo tipinde bir nesne döndürmesi gerektiğini unutmayın.
            // Ardından carDetailsText.Text = selectedCar.ToString(); gibi bir kodla bilgileri gösterebilirsiniz.
        }
    }
}

// ViewModel sınıfı için kullanılabilecek örnek bir sınıf
public class MainViewModel
{
    public ObservableCollection<string> modelNames { get; set; }

    public MainViewModel()
    {
        modelNames = new ObservableCollection<string>();
    }
}
