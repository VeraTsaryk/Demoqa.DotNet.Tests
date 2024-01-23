using Demoqa.DotNet.Tests.PageObject;
using Demoqa.DotNet.Tests.Constants;

namespace Demoqa.DotNet.Tests.tests
{
    internal class TextBoxTest: BaseTest<TextBoxPage>
    {

        [SetUp]
        public new void Setup()
        {
            page = new TextBoxPage(driver);
            page.OpenPage(Url.TextBoxUrl);
        }


        [Test]
        public void CreateNewUserPass()
        {
            page.FillTextBox(Name.FullName,Name.TextBoxEmail,Name.CurrentAddressName, Name.PermanentAddressName);
            Assert.AreEqual(Name.MessageFullName, page.GetText(page.OutPutName));
            Assert.AreEqual(Name.MessageTextBoxEmail, page.GetText(page.OutPutEmail));
            Assert.AreEqual(Name.MessageCurrentAddressName, page.GetText(page.OutPutCurrentAddress));
            Assert.AreEqual(Name.MessagePermanentAddressName, page.GetText(page.OutPutPermanentAddress));
        }


    }
}
