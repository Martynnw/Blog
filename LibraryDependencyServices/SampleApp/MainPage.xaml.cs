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

            var cultureProvider = DependencyService.Get<ICultureProvider>();
            var culture = cultureProvider.GetCultureString();
            CultureLabel.Text = $"Culture: {culture}";

            var timeProvider = new TimeProvider();
            var time = timeProvider.GetTimeString();
            TimeLabel.Text = $"Time: {time}";
        }
    }
}
