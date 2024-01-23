using Demoqa.DotNet.Tests.PageObject;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Demoqa.DotNet.Tests.tests
{
    internal class BaseTest<TPage>
        where TPage : BasePage
    {
        protected TPage page;

        protected IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void Cleanup()
        {
            driver.Quit();
        }
    }
}
