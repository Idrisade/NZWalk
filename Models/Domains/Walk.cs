namespace webtest.Models.Domains
{
    public class Walk
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Lenght { get; set; }
        public double code { get; set; }
        public Guid WalkdifficultyId { get; set; }

        // Navigation properties 
        public Region Region { get; set; }
        public Walkdifficulty Walkdifficulty { get; set; }


    } 
}
