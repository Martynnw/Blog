using System;
using System.Collections.Generic;
using SampleLibrary;
using Xamarin.Forms;

namespace SampleApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var platformStringProvider = DependencyService.Get<IPlatformStringProvider>();
            MainLabel.Text = platformStringProvider.GetPlatformString();
        }
    }
}
