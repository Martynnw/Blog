using Xamarin.UITest;
using TechTalk.SpecFlow;

namespace SpecFlowDemo.UITests
{
    [Binding]
    public class SetupSteps
    {
        [Given("a started app")]
        public void TheMainPageIsDisplayed()
        {
            if (Global.Platform == Platform.iOS)
            {
                Global.App = ConfigureApp.iOS.StartApp();
            }
            else
            {
                Global.App = ConfigureApp.Android.StartApp();
            }
        }
    }
}
