using Demoqa.DotNet.Tests.PageObject;
using Demoqa.DotNet.Tests.Constants;

namespace Demoqa.DotNet.Tests.tests
{
    internal class DialogTests:BaseTest<DialogsPage>
    {

        [SetUp]
        public new void Setup()
        {
            page = new DialogsPage(driver);
            page.OpenPage(Url.DialogUrl);
        }



        [Test]
        public void SmallModalIsDisplayed()
        {
            page.DialogSmallModal();
            page.AssertIsDisplayed(page.TitleModal);
            Assert.AreEqual(Name.SmallModalDialog, page.GetTextModal());
        }

        [Test]
        public void LargeModalIsDisplayed()
        {
            page.DialogLargeModal();
            page.AssertIsDisplayed(page.TitleModal);
            Assert.AreEqual(Name.LargeModalDialog, page.GetTextModal());
        }

    }
}
