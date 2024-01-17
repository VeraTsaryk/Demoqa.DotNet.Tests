using OpenQA.Selenium;

namespace TestsDemoqa.com {
    internal class HomePage {
        private IWebDriver driver;

        public HomePage(IWebDriver driver) {
            this.driver = driver;
        }
    }
}