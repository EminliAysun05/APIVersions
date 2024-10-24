namespace WebAPI.Models
{
    public class Plant
    {
        public int Id { get; set; }
        public required string Name { get; set; }

        public required string Type { get; set; }
    }
}
