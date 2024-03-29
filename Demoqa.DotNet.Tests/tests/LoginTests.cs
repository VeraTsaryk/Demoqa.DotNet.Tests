using TestsDemoqa.com.PageObject;
using Demoqa.DotNet.Tests.Constants;

namespace Demoqa.DotNet.Tests.tests
{
    internal class LoginTests : BaseTest<LoginPage>
    {
        [SetUp]
        public new void Setup()
        {
            page = new LoginPage(driver);
            page.OpenPage(Urls.Login);
        }

        [Test]
        public void LoginIn_Failed()
        {
            page.LoginIn(Variables.FailedLoginName, Variables.FailedPasswordName);
            Assert.AreEqual(Variables.ErrorMessage, page.GetLoginErrorMessage());
        }

        [Test]
        public void LoginInOk()
        {
            page.LoginIn(Variables.LoginName, Variables.PasswordName);
            Assert.AreEqual(Variables.TitleName, page.GetTitle());
        }

        [Test]
        public void LoginOut()
        {
            page.LoginInOut(Variables.LoginName, Variables.PasswordName);
            Assert.That(page.UserForm.Displayed);


        }
    }
}
