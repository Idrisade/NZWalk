namespace webtest.Models.Domains
{
    public class Region
    {
        public Guid Id { get; set; }    
        public string Code { get; set; }
        public string Name { get; set; }
        public double Area { get; set; }
        public double Lat { get; set; }
        public double Longitude { get; set; }
        public long Population { get; set; } 

        // Navigation Property 
        public IEnumerable<Walk> Walks { get; set; }    
        // this means WAlk can have multiple walks in one Region
    }
}
