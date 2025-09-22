namespace Project.Models
{
    public record BookRoomRequest
    {
        public string Name { get; init; }
        public DateTime DateTime { get; init; }
    }
}