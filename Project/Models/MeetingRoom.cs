namespace Project.Models
{
    public record MeetingRoom
    {
        private string _name;
        public DateTime DateTime { get; init; }

        public MeetingRoom(string name, DateTime dateTime)
        {
            _name = name;
            DateTime = dateTime;
        }
    }
}