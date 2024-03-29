using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Demoqa.DotNet.Tests.PageObject
{
    internal class AgePage : BasePage
    {
        public AgePage(IWebDriver driver) : base(driver)
        {
        }

        [FindsBy(How = How.CssSelector, Using = ".rt-tbody > div:nth-child(1) .rt-td:nth-child(3)")]
        public IWebElement EditFieldAge { get; set; }

        [FindsBy(How = How.Id, Using = "edit-record-1")]
        public IWebElement RenameBtn { get; set; }

        [FindsBy(How = How.Id, Using = "age")]
        public IWebElement FieldAge { get; set; }

        [FindsBy(How = How.Id, Using = "submit")]
        public IWebElement SubmitBtn { get; set; }

        public void EditAge(string age)
        {
            RenameBtn.Click();
            FieldAge.Clear();
            FieldAge.SendKeys(age);
            SubmitBtn.Click();
        }
    }
}
