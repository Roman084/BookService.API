using System;
using BookService.DAL.Interfaces;

namespace BookService.DAL.Entities
{
    public class Book : IEntity

    {
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime HostedAt { get; set; }

    public Guid GenreId { get; set; }
    public Genre Genre { get; set; }
    }
}