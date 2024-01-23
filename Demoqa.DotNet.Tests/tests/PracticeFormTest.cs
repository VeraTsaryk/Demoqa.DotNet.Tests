using Demoqa.DotNet.Tests.PageObject;
using Demoqa.DotNet.Tests.Constants;

namespace Demoqa.DotNet.Tests.tests
{
    internal class PracticeFormTest: BaseTest<PracticeFormPage>
    {


        [SetUp]
        public new void Setup()
        {
            page = new PracticeFormPage(driver);
            page.OpenPage(Url.PracticeFormUrl);
        }

        [Test]
        public void AddUserInformation()
        {
            page.FillPracticeFormInformation(Name.FullName,Name.LastName,Name.PracticeFormEmail,Name.MobileNumber);
            page.AssertIsDisplayed(page.SubmitForm);
           
        }




    }
}
