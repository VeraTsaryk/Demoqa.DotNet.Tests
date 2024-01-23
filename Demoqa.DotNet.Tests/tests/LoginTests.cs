using TestsDemoqa.com.PageObject;
using Demoqa.DotNet.Tests.Constants;

namespace Demoqa.DotNet.Tests.tests
{
    internal class LoginTests: BaseTest<LoginPage>
    {

        [SetUp]
        public new void Setup()
        {
            page = new LoginPage(driver);
            page.OpenPage(Url.LoginUrl);
        }



        [Test]
        public void LoginIn_Failed()
        {
            page.LoginIn(Name.FailedLoginName, Name.FailedPasswordName);
            Assert.AreEqual(Name.ErrorMessage, page.GetLoginErrorMessage());
        }
        [Test]
        public void LoginInOk()
        {
            page.LoginIn(Name.LoginName, Name.PasswordName);
            Assert.AreEqual(Name.TitleName, page.GetTitle());
        }
        [Test]
        public void LoginOut()
        {
            page.LoginInOut(Name.LoginName, Name.PasswordName);
            Assert.That(page.UserForm.Displayed);

           
        }
    }
}
