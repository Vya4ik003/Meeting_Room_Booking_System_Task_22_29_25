using Project.Models;

namespace Project.Services
{
    public class MeetingRoomService : IMeetingRoomService
    {
        public List<MeetingRoom> meetingRooms {  get; set; } = new List<MeetingRoom>();

        public void BookRoom(string name, DateTime dateTime) //доделать
        {
            if (dateTime >= DateTime.Today && !meetingRooms.Any(x => x.DateTime == dateTime))
            {
                meetingRooms.Add(new MeetingRoom(name, dateTime));
            }
        }

        public bool IsFree(DateTime from, DateTime to)
        {
            return meetingRooms.Any(x => x.DateTime >= from && x.DateTime <= to);
        }
 
        public List<MeetingRoom> ReturnMeetingRooms()
        {
            return meetingRooms;
        }
    }
}