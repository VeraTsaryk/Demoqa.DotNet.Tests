using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoqa.DotNet.Tests.PageObject
{
    public class TextBoxPage : BasePage

    {
        public TextBoxPage(IWebDriver driver) : base(driver)
        {
        }

        [FindsBy(How = How.Id, Using = "userName")]
        public IWebElement FullName { get; set; }

        [FindsBy(How = How.Id, Using = "userEmail")]
        public IWebElement Email { get; set; }

        [FindsBy(How = How.Id, Using = "currentAddress")]
        public IWebElement CurrentAddress { get; set; }

        [FindsBy(How = How.Id, Using = "permanentAddress")]
        public IWebElement PermanentAddress { get; set; }

        [FindsBy(How = How.Id, Using = "submit")]
        public IWebElement BtnSubmit { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#output #name")]
        public IWebElement OutPutName { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#output #email")]
        public IWebElement OutPutEmail { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#output #currentAddress")]
        public IWebElement OutPutCurrentAddress { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#output #permanentAddress")]
        public IWebElement OutPutPermanentAddress { get; set; }



        public void FillTextBox(string fullName, string email, string currentAddress, string permanentAddress)
        {
            FullName.SendKeys(fullName);
            Email.SendKeys(email);
            CurrentAddress.SendKeys(currentAddress);
            PermanentAddress.SendKeys(permanentAddress);
            BtnSubmit.Click();
        }
    }
}
