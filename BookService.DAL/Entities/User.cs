using System;
using BookService.DAL.Interfaces;

namespace BookService.DAL.Entities
{
    public class User : IEntity
    {
        public Guid Id { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime RegisterDate { get; set; }
    }
}