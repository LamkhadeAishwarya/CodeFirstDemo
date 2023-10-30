using System.ComponentModel.DataAnnotations;

namespace CodeFirstDemo.Models
{
    public class Department
    {
        [Key]
        public int DeptId { get; set; }
        public string? DeptName { get; set; }
    }
}
