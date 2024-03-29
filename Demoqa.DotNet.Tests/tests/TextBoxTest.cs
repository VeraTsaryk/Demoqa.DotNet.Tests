using Demoqa.DotNet.Tests.PageObject;
using Demoqa.DotNet.Tests.Constants;

namespace Demoqa.DotNet.Tests.tests
{
    internal class TextBoxTest : BaseTest<TextBoxPage>
    {
        [SetUp]
        public new void Setup()
        {
            page = new TextBoxPage(driver);
            page.OpenPage(Urls.TextBox);
        }

        [Test]
        public void CreateNewUserPass()
        {
            page.FillTextBox(Variables.FullName, Variables.TextBoxEmail, Variables.CurrentAddressName, Variables.PermanentAddressName);
            Assert.AreEqual(Variables.MessageFullName, page.GetText(page.OutPutName));
            Assert.AreEqual(Variables.MessageTextBoxEmail, page.GetText(page.OutPutEmail));
            Assert.AreEqual(Variables.MessageCurrentAddressName, page.GetText(page.OutPutCurrentAddress));
            Assert.AreEqual(Variables.MessagePermanentAddressName, page.GetText(page.OutPutPermanentAddress));
        }
    }
}
