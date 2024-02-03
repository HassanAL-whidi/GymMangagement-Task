namespace gym_management.Models.Entites
{
    public class SubscriptionCoach
    {
        public int Id { get; set; }
        public int SubscriptionId { get; set; }
        public Subscription Subscription { get; set; }
        public int CoachId { get; set; }
        public Coach Coach { get; set; }
    }
}
