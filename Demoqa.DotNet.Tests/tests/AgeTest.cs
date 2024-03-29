using Demoqa.DotNet.Tests.PageObject;
using Demoqa.DotNet.Tests.Constants;

namespace Demoqa.DotNet.Tests.tests
{
    internal class AgeTest : BaseTest<AgePage>
    {
        public readonly string initialAge = "39";
        public readonly string NewAge = "84";

        [SetUp]
        public new void Setup()
        {
            page = new AgePage(driver);
            page.OpenPage(Urls.Age);
        }

        [Test]
        public void EditUserAge()
        {
            Assert.AreEqual(initialAge, page.GetText(page.EditFieldAge));
            page.EditAge(NewAge);
            Assert.AreEqual(NewAge, page.GetText(page.EditFieldAge));
        }
    }
}
