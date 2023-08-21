namespace Traveler.Minimal.Api.Features.Models
{
    public class Journal
    {
        public string? Id { get; set; }

        public string JournalName { get; set; } = null!;

        public string Category { get; set; } = null!;

        public string Subject { get; set; } = null!;

        public string Author { get; set; } = null!;
        public DateTime CreatedDateTime { get; set; }

    }
}
