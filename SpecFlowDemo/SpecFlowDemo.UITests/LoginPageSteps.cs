using Xamarin.UITest;
using TechTalk.SpecFlow;

namespace SpecFlowDemo.UITests
{
    [Binding]
    public class LoginPageSteps
    {
        [Given("the login page is displayed")]
        public void TheLoginPageIsDisplayed()
        {
            Global.App.WaitForElement("LoginPage");
        }

        [When("Olivia enters the username (.*)")]
        public void OliviaEntersTheUsername(string username)
        {
            Global.App.EnterText("UsernameEntry", username);
        }

        [When("she enters the password (.*)")]
        public void WhenSheEntersThePassword(string password)
        {
            Global.App.EnterText("PasswordEntry", password);
            Global.App.DismissKeyboard();
        }

        [When("she presses the Logon button")]
        public void ShePressesTheLogonButton()
        {
            Global.App.Tap("LoginButton");
        }

        [Then("the home screen is displayed")]
        public void TheHomeScreenIsDisplayed()
        {
            Global.App.WaitForElement("MainPage");
        }

        [Then("an invalid username or password message is displayed")]
        public void AnInvalidUsernameOrPasswordMessageIsDisplayed()
        {
            Global.App.WaitForElement("Logon Failed");
            Global.App.WaitForElement("Invalid username or password");
        }
    }
}
