using static gym_management.Helper.Enums.Enums;

namespace gym_management.Models.Entites
{
    public class Subscription
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int DurationDays { get; set; }
        public int TrainingHoursPerDay { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public SubscriptionDuration Duration { get; set; }

        public virtual Client Client { get; set; } // One-to-One with Client
        public virtual ICollection<Coach> Coaches { get; set; } // Many-to-Many with Coach

    }
}
