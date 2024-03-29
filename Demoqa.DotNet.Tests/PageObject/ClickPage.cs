using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;

namespace Demoqa.DotNet.Tests.PageObject
{
    public class ClickPage : BasePage
    {
        public ClickPage(IWebDriver driver) : base(driver)
        {
        }
        [FindsBy(How = How.Id, Using = "doubleClickBtn")]
        public IWebElement DoubleClickBtn { get; set; }

        [FindsBy(How = How.Id, Using = "rightClickBtn")]
        public IWebElement RightClickBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.col-12.mt-4.col-md-6 > div:nth-child(2) > div:nth-child(3)>button")]
        public IWebElement DinamicClickBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "label[for= \"yesRadio\"]")]
        public IWebElement YesClickBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "label[for= \"impressiveRadio\"]")]
        public IWebElement ImpressiveClickBtn { get; set; }

        [FindsBy(How = How.Id, Using = "dynamicClickMessage")]
        public IWebElement TextDinamicClick { get; set; }

        [FindsBy(How = How.Id, Using = "rightClickMessage")]
        public IWebElement TextRightClick { get; set; }

        [FindsBy(How = How.Id, Using = "doubleClickMessage")]
        public IWebElement TextDoubleClick { get; set; }

        [FindsBy(How = How.ClassName, Using = "text-success")]
        public IWebElement Answer { get; set; }

        public void DoubleClick()
        {
            Actions action = new Actions(driver);
           action.DoubleClick(DoubleClickBtn).Perform();
        }

        public void DinamicClick()
        {
            DinamicClickBtn.Click();
        }

        public void YesClick()
        {
            YesClickBtn.Click();
        }

        public void ImpressiveClick()
        {
            ImpressiveClickBtn.Click();
        }

        public void RightClick()
        {
            Actions action = new Actions(driver);
            action.ContextClick(RightClickBtn).Perform();
        }
    }
}
