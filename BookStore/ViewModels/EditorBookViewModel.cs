using BookStore.Validators;
using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace BookStore.ViewModels
{
    public class EditorBookViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Nome do Livro")]
        public string Name { get; set; }
        [Required(ErrorMessage = "*")]
        public string ISBN { get; set; }
        [Required(ErrorMessage = "*")]
        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }
        [Required(ErrorMessage = "*")]
        public int CategoryId { get; set; }
        public SelectList CategoryOptions { get; set; }

        [CheckAgeValidator]
        public DateTime Age { get; set; }
    }
}