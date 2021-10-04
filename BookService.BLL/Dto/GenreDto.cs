using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BookService.DAL.Entities;

namespace BookService.BLL.Dto
{
    public class GenreDto
    {
        public Guid Id { get; set; }
        
        [Required(ErrorMessage = "Genre name required")]
        public string Name { get; set; }
        
        // Navigation property:
        public ICollection<Book> Books { get; set; }
    }
}