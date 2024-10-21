namespace Tourist_Attraction.Models
{
    public class Trip
    {
        public string Title { get; set; }
        public string Eid { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public List<string> Photos { get; set; }
        public List<string> Tags { get; set; }
    }
}
