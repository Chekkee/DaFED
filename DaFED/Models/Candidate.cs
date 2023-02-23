namespace DaFED.Models
{
    public class Candidate
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Age { get; set; }
        public Quality Quality { get; set; }
    }

    public enum Quality
    {
        Bad = 0,
        Decent = 1,
        Good = 2,
    }
}
