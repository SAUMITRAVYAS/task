using System.ComponentModel.DataAnnotations;

namespace task.Models

{
    public class EmployeeDetails
    {
        [Key]
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string Experience { get; set; }
        public string Gender { get; set; }
        public string Role { get; set; }



    }
}
