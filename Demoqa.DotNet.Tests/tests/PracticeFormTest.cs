using Demoqa.DotNet.Tests.PageObject;
using Demoqa.DotNet.Tests.Constants;

namespace Demoqa.DotNet.Tests.tests
{
    internal class PracticeFormTest : BaseTest<PracticeFormPage>
    {
        [SetUp]
        public new void Setup()
        {
            page = new PracticeFormPage(driver);
            page.OpenPage(Urls.PracticeForm);
        }

        [Test]
        public void AddUserInformation()
        {
            page.FillPracticeFormInformation(Variables.FullName, Variables.LastName, Variables.PracticeFormEmail, Variables.MobileNumber);
            Assert.That(page.IsElementVisible(page.SubmitForm, true));

        }
    }
}
