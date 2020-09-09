 using System.Collections.Generic;

namespace BookStore.Domain
{
    public class Category
    {
        public Category()
        {
            this.Books = new List<Book>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}