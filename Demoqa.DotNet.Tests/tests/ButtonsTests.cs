using Demoqa.DotNet.Tests.PageObject;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Demoqa.DotNet.Tests.tests
{
    internal class ButtonsTests
    {
        private IWebDriver _driver;
        private BasePage _page;

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _page = new ClickPage(_driver);
            _page.OpenPage("https://demoqa.com/buttons");
        }

        [Test]
        public void Test1()
        {
            
            Assert.Pass();
        }
    }
}
