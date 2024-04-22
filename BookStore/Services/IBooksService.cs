using BookStore.Models;

namespace BookStore.Services
{
    public interface IBooksService
    {
        List<Book> GetBooks();
    }
}
