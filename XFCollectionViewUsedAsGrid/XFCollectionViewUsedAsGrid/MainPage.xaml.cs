using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFCollectionViewUsedAsGrid
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<BannerImage> ImageList;

        public MainPage()
        {
            InitializeComponent();

            GetImageList();

            Device.BeginInvokeOnMainThread(() =>
            {
                BannerList.ItemsLayout = new GridItemsLayout(2, ItemsLayoutOrientation.Vertical);
                BannerList.ItemsSource = ImageList;
            });
        }

        public ObservableCollection<BannerImage> GetImageList()
        {
            ImageList = new ObservableCollection<BannerImage>();

            ImageList.Add(new BannerImage()
            {
                HeaderColor = Color.FromHex("#F7DC6F"),
                ImageName = "Image img6",
                ImageUrl = ImageSource.FromFile("img6.jpg")
            });

            ImageList.Add(new BannerImage()
            {
                HeaderColor = Color.FromHex("#7DCEA0"),
                ImageName = "Image img7",
                ImageUrl = ImageSource.FromFile("img7.jpg")
            });

            ImageList.Add(new BannerImage()
            {
                HeaderColor = Color.FromHex("#7FB3D5"),
                ImageName = "Image img8",
                ImageUrl = ImageSource.FromFile("img8.jpeg")
            });

            ImageList.Add(new BannerImage()
            {
                HeaderColor = Color.FromHex("#9B59B6"),
                ImageName = "Red season",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/33109/fall-autumn-red-season.jpg?cs=srgb&dl=autumn-colorful-colourful-33109.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                HeaderColor = Color.FromHex("#641E16"),
                ImageName = "Pexels 556416",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/556416/pexels-photo-556416.jpeg?cs=srgb&dl=bridge-clouds-cloudy-556416.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                HeaderColor = Color.FromHex("#F1948A"),
                ImageName = "Pexels 257840",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/257840/pexels-photo-257840.jpeg?cs=srgb&dl=agriculture-apple-blur-257840.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                HeaderColor = Color.FromHex("#00FF00"),
                ImageName = "Pexels 257840",
                ImageUrl = ImageSource.FromFile("gif4.gif")
            });

            ImageList.Add(new BannerImage()
            {
                HeaderColor = Color.FromHex("#1ABC9C"),
                ImageName = "Pexels 853199",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/853199/pexels-photo-853199.jpeg?cs=srgb&dl=4k-wallpaper-background-beautiful-853199.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                HeaderColor = Color.FromHex("#1B4F72"),
                ImageName = "Pexels 462118",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/462118/pexels-photo-462118.jpeg?cs=srgb&dl=bloom-blooming-blossom-462118.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                HeaderColor = Color.FromHex("#F0048A"),
                ImageName = "Pexels 257840",
                ImageUrl = ImageSource.FromFile("gif5.gif")
            });

            ImageList.Add(new BannerImage()
            {
                HeaderColor = Color.FromHex("#6E2C00"),
                ImageName = "Waterfall thac",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/68147/waterfall-thac-dray-nur-buon-me-thuot-daklak-68147.jpeg?cs=srgb&dl=hd-wallpaper-landscape-long-exposure-68147.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                HeaderColor = Color.FromHex("#F4D03F"),
                ImageName = "Pexels 753626",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/753626/pexels-photo-753626.jpeg?cs=srgb&dl=beach-bora-bora-clouds-753626.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                HeaderColor = Color.FromHex("#5B2C6F"),
                ImageName = "Pexels 1402787",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/1402787/pexels-photo-1402787.jpeg?cs=srgb&dl=4k-wallpaper-audi-audi-r8-1402787.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                HeaderColor = Color.FromHex("#0E6655"),
                ImageName = "Rose blue flower",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/67636/rose-blue-flower-rose-blooms-67636.jpeg?cs=srgb&dl=beauty-bloom-blue-67636.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                HeaderColor = Color.FromHex("#B7950B"),
                ImageName = "Pexels 443446",
                ImageUrl = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/443446/pexels-photo-443446.jpeg?cs=srgb&dl=daylight-forest-glossy-443446.jpg&fm=jpg"))
            });

            ImageList.Add(new BannerImage()
            {
                HeaderColor = Color.FromHex("#D7DBDD"),
                ImageName = "Image img5",
                ImageUrl = ImageSource.FromFile("img5.jpeg")
            });


            ImageList.Add(new BannerImage()
            {
                HeaderColor = Color.FromHex("#C39BD3"),
                ImageName = "Image img9",
                ImageUrl = ImageSource.FromFile("img9.jpeg")
            });


            return ImageList;
        }
    }
}

