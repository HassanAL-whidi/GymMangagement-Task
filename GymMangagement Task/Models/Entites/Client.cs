namespace gym_management.Models.Entites
{
    public class Client: User 
    {
        public int SubscriptionId { get; set; }
        public Subscription Subscription { get; set; }
    }
}
