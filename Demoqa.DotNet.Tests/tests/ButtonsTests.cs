using Demoqa.DotNet.Tests.PageObject;
using Demoqa.DotNet.Tests.Constants;

namespace Demoqa.DotNet.Tests.tests
{
    internal class ButtonsTests : BaseTest<ClickPage>
    {
        [SetUp]
        public new void Setup()
        {
            page = new ClickPage(driver);
        }

        [Test]
        public void TheButtonIsClickable()
        {
            page.OpenPage(Urls.Button);
            page.DinamicClick();
            Assert.That(page.IsElementVisible(page.TextDinamicClick, true));
        }

        [Test]
        public void TheButtonIsDoubleClickable()
        {
            page.OpenPage(Urls.Button);
            page.DoubleClick();
            Assert.That(page.IsElementVisible(page.TextDoubleClick, true));
        }

        [Test]
        public void TheButtonIsRightClickable()
        {
            page.OpenPage(Urls.Button);
            page.RightClick();
            Assert.That(page.IsElementVisible(page.TextRightClick, true));
        }

        [Test]
        public void TheButtonYesIsClickable()
        {
            page.OpenPage(Urls.RadioButton);
            page.YesClick();
            Assert.That(page.IsElementVisible(page.Answer, true));
        }

        [Test]
        public void TheButtonImpressiveIsClickable()
        {
            page.OpenPage(Urls.RadioButton);
            page.ImpressiveClick();
            Assert.That(page.IsElementVisible(page.Answer, true));
        }
    }
}
