using Demoqa.DotNet.Tests.PageObject;
using Demoqa.DotNet.Tests.Constants;

namespace Demoqa.DotNet.Tests.tests
{
    internal class ButtonsTests: BaseTest<ClickPage>
    {
        

        [SetUp]
        public new void Setup()
        {
           page = new ClickPage(driver);
        }


        [Test]
        public void ClickTheButton()
        {
           page.OpenPage(Url.ButtonUrl);
           page.DinamicClick();
           page.AssertIsDisplayed(page.TextDinamicClick);
        }

        [Test]
        public void DoubleClickTheButton()
        {
           page.OpenPage(Url.ButtonUrl);
           page.DoubleClick();
           page.AssertIsDisplayed(page.TextDoubleClick);
        }
        [Test]
        public void RightClickTheButton()
        {
           page.OpenPage(Url.ButtonUrl);
           page.RightClick();
           page.AssertIsDisplayed(page.TextRightClick);
        }
        [Test]
        public void YesClickTheButton()
        {
           page.OpenPage(Url.RadioButtonUrl);
           page.YesClick();
           page.AssertIsDisplayed(page.Answer);
        }
        [Test]
        public void ImpressiveClickTheButton()
        {
           page.OpenPage(Url.RadioButtonUrl);
           page.ImpressiveClick();
           page.AssertIsDisplayed(page.Answer);
        }


    }
}
