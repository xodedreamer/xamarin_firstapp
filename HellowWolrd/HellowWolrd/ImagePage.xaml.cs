﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HellowWolrd
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImagePage : ContentPage
    {
        public ImagePage()
        {
            InitializeComponent();

            //  var imageSource = new UriImageSource { Uri = new Uri("http://lorempixel.com/1920/1080/sports/7/") };
            //  imageSource.CachingEnabled = false;
            ////imageSource.CacheValidity = TimeSpan.FromHours(1);
            //  image.Source = imageSource;

            var imageSource = ImageSource.FromResource("HellowWolrd.images.background.jpg");
            image.Source = imageSource;

        }
    }
}