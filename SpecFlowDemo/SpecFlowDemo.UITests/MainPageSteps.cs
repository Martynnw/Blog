using Xamarin.UITest;
using TechTalk.SpecFlow;

namespace SpecFlowDemo.UITests
{
    [Binding]
    public class MainPageSteps
    {
        [Then("the main page is displayed")]
        public void TheMainPageIsDisplayed()
        {
            Global.App.WaitForElement("MainPage");
        }
    }
}
