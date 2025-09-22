namespace Project.Models
{
    public record IsFreeRequest
    {
        public DateTime From {  get; init; }
        public DateTime To { get; init; }
    }
}