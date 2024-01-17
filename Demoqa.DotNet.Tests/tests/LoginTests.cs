using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using TestsDemoqa.com.PageObject;

namespace Demoqa.DotNet.Tests.tests
{
    internal class LoginTests
    {
        private IWebDriver _driver;
        private LoginPage _page;

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _page = new LoginPage(_driver);
            _page.OpenPage("https://demoqa.com/login");
        }

        [TearDown]
        public void Cleanup()
        {
            _driver.Quit();
        }

        [Test]
        public void LoginIn_Failed()
        {
            _page.LoginIn("Verlo", "1234lol");
            Assert.AreEqual("Invalid username or password!", _page.GetLoginErrorMessage());
        }
    }
}
