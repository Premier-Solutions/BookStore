using Microsoft.AspNetCore.Components;

namespace BookStore.Models
{
    public class Book
    {
        public string? Title { get; set; }

        public string? AuthorName { get; set; }

        public DateTime? PublishingDate { get; set; }
        public int Price { get; set; }
    }
}
