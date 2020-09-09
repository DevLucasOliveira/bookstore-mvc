using System;
using System.Collections.Generic;

namespace BookStore.Domain
{
    public class Book
    {
        public Book()
        {
            this.Authors = new List<Author>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string ISBN { get; set; }
        public DateTime CreatedAt { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<Author> Authors { get; set; }
    }
}