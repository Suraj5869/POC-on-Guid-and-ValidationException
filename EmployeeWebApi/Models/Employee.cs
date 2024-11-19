using System.ComponentModel.DataAnnotations;

namespace EmployeeWebApi.Models
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage ="Name is required field")]
        [StringLength(20, ErrorMessage = "Name must be fewer than 20 characters.")]
        public string Name { get; set; }
        [Required(ErrorMessage ="EmailAddress is required field")]
        [EmailAddress(ErrorMessage ="Enter email in correct format!!")]
        public string Email { get; set; }
        public double Salary { get; set; }
    }
}
