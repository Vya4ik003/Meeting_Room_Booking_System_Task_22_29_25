using Project.Models;

namespace Project.Services
{
    public interface IMeetingRoomService
    {
        void BookRoom(string name, DateTime dateTime);
        bool IsFree(DateTime from, DateTime to);
        List<MeetingRoom> ReturnMeetingRooms();
    }
}