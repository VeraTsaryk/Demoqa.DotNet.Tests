using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoqa.DotNet.Tests.PageObject
{
    public class PracticeFormPage : BasePage
    {
        public PracticeFormPage(IWebDriver driver) : base(driver)
        {
        }

        [FindsBy(How = How.Id, Using = "firstName")]
        public IWebElement LastNameField { get; set; }

        [FindsBy(How = How.Id, Using = "lastName")]
        public IWebElement FirstNameField { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div [class = \"col-md-9 col-sm-12\"] #userEmail")]
        public IWebElement EmailNameField { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div [class = \"col-md-9 col-sm-12\"] #gender-radio-2")]
        public IWebElement Gender { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div[class =\"col-md-9 col-sm-12\"] #userNumber")]
        public IWebElement MobileNumberField { get; set; }

        [FindsBy(How = How.Id, Using = "dateOfBirthInput")]
        public IWebElement DataOfBirth { get; set; }

        //[FindsBy(How = How.CssSelector, Using = "div[class =\"col-md-9 col-sm-12\"] #userNumber")]
        //public IWebElement DataOfBirth2 { get; set; }

        [FindsBy(How = How.Id, Using = "hobbies-checkbox-1")]
        public IWebElement Hobbies { get; set; }

        [FindsBy(How = How.Id, Using = "submit")]
        public IWebElement SubmitBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".modal-content")]
        public IWebElement SubmitForm { get; set; }

        public void FillPracticeFormInformation(string firstName, string lastName, string email, string mobileNumber)
        {
            FirstNameField.SendKeys(firstName);
            LastNameField.SendKeys(lastName);
            EmailNameField.SendKeys(email);
            MobileNumberField.SendKeys(mobileNumber);
            DataOfBirth.Click();
            var js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click();", Gender);
            js.ExecuteScript("arguments[0].click();", Hobbies);
            js.ExecuteScript("document.getElementById('submit').style.marginTop = '-600px';");
            SubmitBtn.Click();
        }

    }
}
