using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace SpecFlowDemo
{
    public class LoginViewModel : MvvmHelpers.BaseViewModel
    {
        private string username;
        private string password;

        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await ExecuteLoginAsync());
        }

        public ICommand LoginCommand { get; private set; }

        public string Username
        {
            get { return username; }
            set { SetProperty(ref username, value); }
        }

        public string Password
        {
            get { return password; }
            set { SetProperty(ref password, value); }
        }

        private async Task ExecuteLoginAsync()
        {
            IsBusy = true;

            await Task.Delay(2000);

            if (CheckUserIsValid())
            {
                await ShowMainPage();
            }
            else
            {
                await ShowInvalidLogon();
            }

            IsBusy = false;
        }

        private bool CheckUserIsValid()
        {
            return Username.Equals("Olivia", StringComparison.CurrentCultureIgnoreCase) && Password.Equals("IHeartOwls");
        }

        private async Task ShowMainPage()
        {
            var mainPage = new MainPage();
            await Application.Current.MainPage.Navigation.PushAsync(mainPage);
        }

        private async Task ShowInvalidLogon()
        {
            var title = "Logon Failed";
            var text = "Invalid username or password";
            await Application.Current.MainPage.DisplayAlert(title, text, "OK");
        }
    }
}
