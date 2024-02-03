namespace gym_management.Models.Entites
{
    public class Department
    {
        public int Id { get; set; }
        public string NameArabic { get; set; }
        public string NameEnglish { get; set; }
        public virtual ICollection<Coach> Coaches { get; set; } // One-to-Many with Coach
        public virtual ICollection<Employee> Employees { get; set; } // Many-to-Many with Employee

    }
}
