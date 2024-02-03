namespace gym_management.Models.Entites
{
    public class Admin:User
    {
        public bool IsSuperAdmin { get; set; }

        public virtual ICollection<Client> Clients { get; set; } // One-to-Many with Client
        public virtual ICollection<Employee> Employees { get; set; } // One-to-Many with Employee


    }
}
