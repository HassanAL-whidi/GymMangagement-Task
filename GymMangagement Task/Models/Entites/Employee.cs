using static gym_management.Helper.Enums.Enums;

namespace gym_management.Models.Entites
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public EmployeeRole Role { get; set; } 
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public virtual required Department Departments { get; set; } // One-to-Many with Department
        public virtual User User { get; set; } // Many-to-One with User

    }
}
