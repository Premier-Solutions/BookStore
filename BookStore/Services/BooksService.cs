using BookStore.Models;

namespace BookStore.Services
{
    public class BooksService : IBooksService
    {
        public List<Book> GetBooks()
        {
            Book book1 = new Book() { Title = "Book 01", AuthorName = "Author 01", PublishingDate = new DateTime(2022, 01, 01), Price = 20 };
            Book book2 = new Book() { Title = "Book 02", AuthorName = "Author 02", PublishingDate = new DateTime(2022, 01, 01), Price = 30 };

            Book book3 = new Book() { Title = "Book 03", AuthorName = "Author 01", PublishingDate = new DateTime(2022, 01, 01), Price = 50 };
            Book book4 = new Book() { Title = "Book 04", AuthorName = "Author 02", PublishingDate = new DateTime(2022, 01, 01), Price = 100 };
            List<Book> allBooks = new();

            allBooks.Add(book1);
            allBooks.Add(book2);
            allBooks.Add(book3);
            allBooks.Add(book4);

            return allBooks;
        }
    }
}
