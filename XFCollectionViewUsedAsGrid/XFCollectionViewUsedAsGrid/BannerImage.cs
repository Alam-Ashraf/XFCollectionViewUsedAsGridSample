using System;
using Xamarin.Forms;

namespace XFCollectionViewUsedAsGrid
{
    public class BannerImage
    {
        public ImageSource ImageUrl { get; set; }
        public string ImageName { get; set; }
        public string ImageDesc { get; set; } = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.";
        public bool IsSquareView { get; set; }
        public Color HeaderColor { get; set; }
    }
}

