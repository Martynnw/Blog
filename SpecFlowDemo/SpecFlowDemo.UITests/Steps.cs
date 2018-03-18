using System;
using Xamarin.UITest;

using TechTalk.SpecFlow;

namespace SpecFlowDemo.UITests
{
    [Binding]
    public class Steps
    {
        private IApp app;

        [Given("the login page is displayed")]
        public void TheLoginPageIsDisplayed()
        {
            app = ConfigureApp.Android.StartApp();
            app.WaitForElement("LoginPage");
        }

        [When("Olivia enters the username Olivia")]
        public void OliviaEntersTheUsernameOlivia()
        {
            app.EnterText("UsernameEntry", "Olivia");
        }

        [When("she enters the password IHeartOwls")]
        public void WhenSheEntersThePasswordIHeartOwls()
        {
            app.EnterText("PasswordEntry", "IHeartOwls");
            app.DismissKeyboard();
        }

        [When("she enters the password IHateTrees")]
        public void WhenSheEntersThePasswordIHateTrees()
        {
            app.EnterText("PasswordEntry", "IHateTrees");
            app.DismissKeyboard();
        }

        [When("she presses the Logon button")]
        public void ShePressesTheLogonButton()
        {
            app.Tap("LoginButton");
        }

        [Then("the home screen is displayed")]
        public void TheHomeScreenIsDisplayed()
        {
            app.WaitForElement("MainPage");
        }

        [Then("an invalid username or password message is displayed")]
        public void AnInvalidUsernameOrPasswordMessageIsDisplayed()
        {
            app.WaitForElement("Logon Failed");
            app.WaitForElement("Invalid username or password");
        }
    }
}
