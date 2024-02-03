using System.Data;
using static gym_management.Helper.Enums.Enums;

namespace gym_management.Models.Entites
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string FullName { get; set; }
        public DateTime? Birthdate { get; set; }
        public UserRole Role { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Admin Admin { get; set; } // One-to-One with Admin
        public virtual Client Client { get; set; } // One-to-One with Client
        public virtual ICollection<Employee> Employees { get; set; } // One-to-Many with Employee


    }
}
