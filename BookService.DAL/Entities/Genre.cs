using System;
using System.Collections.Generic;
using BookService.DAL.Interfaces;

namespace BookService.DAL.Entities
{
    public class Genre : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        
        // Navigation property:
        public ICollection<Book> Books { get; set; }
    }
}