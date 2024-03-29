using Demoqa.DotNet.Tests.PageObject;
using Demoqa.DotNet.Tests.Constants;

namespace Demoqa.DotNet.Tests.tests
{
    internal class BookTests : BaseTest<BookPage>
    {
        [SetUp]
        public new void Setup()
        {
            page = new BookPage(driver);
            page.OpenPage(Urls.Book);
        }

        [Test]
        public void AddBookIntoProfile()
        {
            page.AddBookIntoYourProfile();
            Assert.That(page.IsElementVisible(page.Book, true));
        }

        [Test]
        public void SearchBook()
        {
            page.SearchBook(Variables.BooksName);
            Assert.AreEqual("Git Pocket Guide", page.GetTextNameBook());
            page.SearchField.Clear();
            page.SearchBook(Variables.ChangeBooksName);
            Assert.That(page.IsElementVisible(page.Book) == false);
        }

        [Test]
        public void GoToBookStore()
        {
            page.GoToTheBookStore();
            Assert.That(page.IsElementVisible(page.Book, true));
            Assert.AreEqual(Variables.StoreName, page.GetTextBookStore());
        }

        [Test]
        public void DeleteBookFromProfile()
        {
            page.AddBookIntoYourProfile();
            Assert.That(page.IsElementVisible(page.Book, true));
            page.DeleteBookFromProfile();
            Assert.That(page.IsElementVisible(page.Book) == false);
        }
    }
}
