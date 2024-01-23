using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using Demoqa.DotNet.Tests.PageObject;
using Demoqa.DotNet.Tests.Constants;

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

        [FindsBy(How = How.Id, Using = "userName-value")]
        public IWebElement ActualName { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div[class = \"text-right col-md-5 col-sm-12\"] #submit")]
        public IWebElement LogOutBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#userForm > div:nth-child(1)")]
        public IWebElement UserForm { get; set; }

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

        public void LoginInOut(string login, string password)
        {
            LoginForm.SendKeys(login);
            Passwordform.SendKeys(password);
            Lognbutton.Click();
            Wait(ActualName);
            Assert.That(ActualName.Displayed);
            Assert.AreEqual(Name.LoginName,GetText(ActualName));
            LogOutBtn.Click();
        }

    }
}
