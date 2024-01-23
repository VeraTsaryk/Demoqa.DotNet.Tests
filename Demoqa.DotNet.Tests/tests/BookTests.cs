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
            page.OpenPage(Url.BookUrl);
        }

        [Test]
        public void AddBookIntoProfile()
        {
            page.BookIntoYourProfile();
            page.AssertIsDisplayed(page.Book);
        }

        [Test]
        public void SearchBook()
        {
            page.SearchBook(Name.BooksName, Name.ChangeBooksName);
            Assert.That(page.ElementIsVisible(page.Book) == false);
        }

        [Test]
        public void GoToBookStore()
        {
            page.GoToTheBookStore();
            page.AssertIsDisplayed(page.Book);
            Assert.AreEqual(Name.StoreName, page.GetTextBookStore());
        }

        [Test]
        public void DeleteBookFromProfile()
        {
            page.BookIntoYourProfile();
            page.AssertIsDisplayed(page.Book);
            page.DeleteBookFromProfile();
            Assert.That(page.ElementIsVisible(page.Book) == false);
           
        }
    }
}
