using System.ComponentModel.DataAnnotations;

namespace task.Models
{
    public class EmployeeAddress
    {
        [Key]
        public int EmpId { get; set; }
        public string Address { get; set; }
        public EmployeeDetails EmployeeDetails { get; set; }
    }
}
