using System.ComponentModel.DataAnnotations;

namespace BookStore.ViewModels
{
    public class BookAuthorViewModel
    {
        [Required(ErrorMessage = "*")]
        public int AuthorId { get; set; }

        [Required(ErrorMessage = "*")]
        public int BookId { get; set; }
    }
}