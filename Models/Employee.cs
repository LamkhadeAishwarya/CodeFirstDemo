using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDemo.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Email { get; set; }
        //  public string? City { get; set; }->when we need to drop col we just need comment it
        [Required]
        public decimal Salary { get; set; }
        [ForeignKey("DeptId")]
        public int DeptId { get; set; }
    }
}
