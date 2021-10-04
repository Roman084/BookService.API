using System;
using System.ComponentModel.DataAnnotations;

namespace BookService.BLL.Dto
{
    public class UserDto
    {
        public int Id { get; private set; }
        
        [Required(ErrorMessage = "Name is required")]
        public string FirstName { get; set; }
        
        [Required(ErrorMessage = "Lastname is required")]
        public string LastName { get; set; }
        
        [DataType((DataType.Date))]
        [Required(ErrorMessage = "The field DateRegister is required...")]
        public DateTime RegisterDate { get; set; } = DateTime.Now;
    }
}