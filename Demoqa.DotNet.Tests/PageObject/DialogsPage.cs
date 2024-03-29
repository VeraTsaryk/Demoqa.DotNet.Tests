using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoqa.DotNet.Tests.PageObject
{
    internal class DialogsPage : BasePage
    {
        public DialogsPage(IWebDriver driver) : base(driver)
        {
        }
        [FindsBy(How = How.Id, Using = "showSmallModal")]
        public IWebElement SmallModal { get; set; }

        [FindsBy(How = How.Id, Using = "showLargeModal")]
        public IWebElement LargeModal { get; set; }

        [FindsBy(How = How.ClassName, Using = "modal-title")]
        public IWebElement TitleModal { get; set; }

        public void DialogSmallModal()
        {
            SmallModal.Click();
        }

        public void DialogLargeModal()
        {
            LargeModal.Click();
        }
  
        public string GetTextModal()
        {
            GetText(TitleModal); return TitleModal.Text;

        }
    }
}
