using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestsDemoqa.com.PageObject;
using static System.Net.Mime.MediaTypeNames;

namespace Demoqa.DotNet.Tests.PageObject
{
    internal class BookPage : LoginPage
    {
        public BookPage(IWebDriver driver) : base(driver)
        {
        }
        [FindsBy(How = How.Id, Using = "see-book-Git Pocket Guide")]
        public IWebElement Book { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div[class = \"text-right fullButton\"] #addNewRecordButton")]
        public IWebElement AddToCollectionBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".accordion :nth-child(6) > div > ul> li:nth-child(3)")]
        public IWebElement UserProfile { get; set; }

        [FindsBy(How = How.Id, Using = "login")]
        public IWebElement LoginFormName { get; set; }

        [FindsBy(How = How.Id, Using = "searchBox")]
        public IWebElement SearchField { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#notLoggin-label > a:nth-child(1)")]
        public IWebElement LoginBtnInProfile { get; set; }

        //Some problem with Css-Selector
        [FindsBy(How = How.CssSelector, Using = ".text-left #addNewRecordButton")]
        public IWebElement BtnGoToStore { get; set; }

        [FindsBy(How = How.Id, Using = "delete-record-undefined")]
        public IWebElement DeleteBtn { get; set; }

        [FindsBy(How = How.Id, Using = "closeSmallModal-ok")]
        public IWebElement SmallModal { get; set; }

        [FindsBy(How = How.ClassName, Using = "main-header")]
        public IWebElement BookStore { get; set; }

        public void BookIntoYourProfile()
        {
            Book.Click();
            LoginFormName.Click();
            LoginIn("Ola", "12345@Ola");
            var js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
            Wait(AddToCollectionBtn);
            AddToCollectionBtn.Click();
            WaitAlert();
            IAlert simpleAlert = driver.SwitchTo().Alert();
            simpleAlert.Accept();
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
            UserProfile.Click();
        }
        public void DeleteBookFromProfile()
        {
            DeleteBtn.Click();
            SmallModal.Click();
            WaitAlert();
            IAlert simpleAlert = driver.SwitchTo().Alert();
            simpleAlert.Accept();
        }
        public string GetTextNameBook()
        {
            return GetText(Book);
        }
        public string GetTextBookStore()
        {
            return GetText(BookStore);
        }

        public void SearchBook(string bookName, string changeName)
        {
            SearchField.SendKeys(bookName);
            Assert.AreEqual("Git Pocket Guide", GetTextNameBook());
            SearchField.Clear();
            SearchField.SendKeys(changeName);


        }
        public void GoToTheBookStore()
        {
            Book.Click();
            LoginFormName.Click();
            LoginIn("Ola", "12345@Ola");
            WaitUntilClickable(BtnGoToStore);
            Actions action = new Actions(driver);
            action.DoubleClick(BtnGoToStore).Perform();

        }
    }
}
