namespace gym_management.Models.Entites
{
    public class ClientCoach
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public int CoachId { get; set; }
        public Coach Coach { get; set; }
    }
}
