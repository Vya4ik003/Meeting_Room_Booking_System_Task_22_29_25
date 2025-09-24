namespace Project.Models
{
    public record MeetingRoom
    {
        public string Name;
        public DateTime DateTime { get; init; }

        public MeetingRoom(string name, DateTime dateTime)
        {
            Name = name;
            DateTime = dateTime;
        }
    }
}