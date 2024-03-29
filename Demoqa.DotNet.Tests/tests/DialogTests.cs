using Demoqa.DotNet.Tests.PageObject;
using Demoqa.DotNet.Tests.Constants;

namespace Demoqa.DotNet.Tests.tests
{
    internal class DialogTests : BaseTest<DialogsPage>
    {
        [SetUp]
        public new void Setup()
        {
            page = new DialogsPage(driver);
            page.OpenPage(Urls.Dialog);
        }

        [Test]
        public void SmallModalIsDisplayed()
        {
            page.DialogSmallModal();
            Assert.That(page.IsElementVisible(page.TitleModal, true));
            Assert.AreEqual(Variables.SmallModalDialog, page.GetTextModal());
        }

        [Test]
        public void LargeModalIsDisplayed()
        {
            page.DialogLargeModal();
            Assert.That(page.IsElementVisible(page.TitleModal, true));
            Assert.AreEqual(Variables.LargeModalDialog, page.GetTextModal());
        }

    }
}
