using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SpecFlowDemo
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel();
        }
    }
}
