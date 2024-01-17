using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using Demoqa.DotNet.Tests.PageObject;

namespace TestsDemoqa.com.PageObject
{
    public class LoginPage : BasePage
    {
        [FindsBy(How = How.Id, Using = "userName")]
        public IWebElement LoginForm { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement Passwordform { get; set; }

        [FindsBy(How = How.Id, Using = "login")]
        public IWebElement Lognbutton { get; set; }

        [FindsBy(How = How.ClassName, Using = "mb-1")]
        public IWebElement WarningMessage { get; set; }

        public LoginPage(IWebDriver driver) : base(driver)
        {

        }

        public void LoginIn(string login, string password)
        {
            LoginForm.SendKeys(login);
            Passwordform.SendKeys(password);
            Lognbutton.Click();
        }

        public string GetLoginErrorMessage()
        {
            Wait(WarningMessage);
            return GetText(WarningMessage);
        }
    }
}
