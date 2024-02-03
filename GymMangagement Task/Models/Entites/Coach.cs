using static gym_management.Helper.Enums.Enums;

namespace gym_management.Models.Entites
{
    public class Coach
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int? Age { get; set; }
        public string Specialization { get; set; }
        public CoahGender Gender { get; set; } 
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        public virtual Department Departments { get; set; } // One-to-Many with Department
        public virtual ICollection<Client> Clients { get; set; } // Many-to-Many with Client

    }
}
