namespace TestAPI.Models.DTO
{
    public class Testtbl
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string? City { get; set; }

        public string? State { get; set; }

        public string? Country { get; set; }

        public long? ContactNumber { get; set; }
    }
}
