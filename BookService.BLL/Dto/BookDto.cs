using System;
using System.ComponentModel.DataAnnotations;
using BookService.DAL.Entities;

namespace BookService.BLL.Dto
{
    public class BookDto
    {
        public Guid Id { get; set; }
        
        [Required(ErrorMessage = "Title required")]
        public string Title { get; set; }
        
        [Required(ErrorMessage = "Description required")]
        public string Description { get; set; }
        
        public DateTime HostedAt { get; set; } = DateTime.Now;

        public Guid GenreId { get; set; }
        public Genre Genre { get; set; }
    }
}