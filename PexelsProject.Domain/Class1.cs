namespace PexelsProject.Domain.Entities
{
    public class Photo
    {
        public int Id { get; set; }
        public string Url { get; set; } = string.Empty;
        public string Photographer { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
