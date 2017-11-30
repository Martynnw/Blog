using Newtonsoft.Json;
using Xamarin.Forms;

namespace AutomatedStateTesting
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = CreateMainPage();
        }

        protected override void OnSleep()
        {
            var vm = (MainPageViewModel)((NavigationPage)MainPage).CurrentPage.BindingContext;
            var json = JsonConvert.SerializeObject(vm);
            Properties["State"] = json;
        }

        private Page CreateMainPage()
        {
            MainPageViewModel vm;

            if (Properties.ContainsKey("State"))
            {
                var json = (string)Properties["State"];
                vm = JsonConvert.DeserializeObject<MainPageViewModel>(json);
            }
            else
            {
                vm = new MainPageViewModel();
            }

            var page = new MainPage();
            page.BindingContext = vm;
            return new NavigationPage(page);
        }
    }
}
